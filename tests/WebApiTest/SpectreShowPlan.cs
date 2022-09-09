using Humanizer;
using Showplan;
using ShowPlan.EntityFrameworkCore7.Interceptor;
using Showplan.Extras;
using Showplan.RelOps;
using Showplan.StatementBlocks;
using Spectre.Console;
using Spectre.Console.Rendering;
using WebApiTest.Spectre;

namespace WebApiTest;

internal class SpectreShowPlan : IShowplanInterceptorAction
{
    private static readonly ShowplanDeserializer s_deserializer = new();

    public void Intercepted(string showPlan)
    {
        var showPlanXml = s_deserializer.Deserialize(showPlan);
        var plans = showPlanXml.GetStatementsWithQueryPlans().ToList();
        if (plans.Count == 0)
        {
            return;
        }

        foreach (var plan in plans)
        {
            var header = new Markup($"{plan.StatementType} [grey]Total Cost[/]:[blue]{plan.StatementSubTreeCost}[/] [grey]Est Rows[/]:{plan.StatementEstRows}");
            var tree = new PlanTree(header) { Guide = new RoundedTreeGuide(), Style = new Style(Color.Grey) };


            var (givenDb, givenSchema) = GetGivenDbAndSchema(plan);

            var root = new PlanTreeNode(RelOpToRenderable(plan.QueryPlan.RelOp, givenDb, givenSchema), plan.QueryPlan.RelOp.PhysicalOp.ToString());
            tree.Nodes.Add(root);
            if (plan.QueryPlan.RelOp.Item is { RelOp: { } })
            {
                AddRecurse(root, plan.QueryPlan.RelOp.Item.RelOp, givenDb, givenSchema);
            }

            AnsiConsole.Write(tree);
        }
    }

    private static (string GivenDb, string GivenSchema) GetGivenDbAndSchema(StmtSimple plan)
    {
        var givenDb = string.Empty;
        var givenSchema = string.Empty;
        var databaseNamesInPlan = plan.QueryPlan
            .GetFlattenedRelOps()
            .Select(i => i.Item)
            .OfType<Rowset>()
            .SelectMany(i => i.Object.Select(o => o.Database))
            .Distinct().ToArray();

        var schemasInPlan = plan.QueryPlan
            .GetFlattenedRelOps()
            .Select(i => i.Item)
            .OfType<Rowset>()
            .SelectMany(i => i.Object.Select(o => o.Schema))
            .Distinct().ToArray();

        if (databaseNamesInPlan.Length == 1)
        {
            givenDb = databaseNamesInPlan.First();
        }

        if (schemasInPlan.Length == 1)
        {
            givenSchema = schemasInPlan.First();
        }

        return (givenDb, givenSchema);
    }

    private void AddRecurse(PlanTreeNode currentNode, IEnumerable<RelOp> children, string givenDb, string givenSchema)
    {
        foreach (var child in children)
        {
            var childNode = new PlanTreeNode(RelOpToRenderable(child, givenDb, givenSchema), child.PhysicalOp.ToString());
            currentNode.Nodes.Add(childNode);
            if (child.Item is { RelOp: { } })
            {
                AddRecurse(childNode, child.Item.RelOp, givenDb, givenSchema);
            }
        }
    }

    private IRenderable RelOpToRenderable(RelOp relOp, string givenDb, string givenSchema)
    {
        var table = new Table().NoBorder().HideHeaders();
        table.AddColumn(new TableColumn("Operation"));

        var h = new QueryPlanHumanizer(givenDb, givenSchema);
        string[] other = relOp.Item switch
        {
            IndexScan indexScan => new[] { GetIndexScan(indexScan, h).EscapeMarkup() },
            TableScan tableScan => new[] { "Object: " + h.Humanize(tableScan.Object[0]).EscapeMarkup() + " " + h.Humanize(tableScan.Predicate).EscapeMarkup() },
            Filter filter => new[] { h.Humanize(filter.Predicate).EscapeMarkup() },
            StreamAggregate streamAggregate => GetStreamAggregate(streamAggregate, h).ToArray(),

            _ => Array.Empty<string>()
        };

        table.AddRow(
            $"[grey]Cost[/]:[blue]{relOp.EstimatedTotalCost():F2}[/] [grey]Rows[/]:[blue]{relOp.EstimateRows.ToMetric(decimals: 1)}[/]");


            table.AddRow(other);

        return table;
    }

    private static IEnumerable<string> GetStreamAggregate(StreamAggregate streamAggregate, QueryPlanHumanizer h)
    {
        if (streamAggregate.GroupBy is { Length: 1 })
        {
            yield return "Group by: " + h.Humanize(streamAggregate.GroupBy[0]).EscapeMarkup();
        }

        if (streamAggregate.DefinedValues is {Length: 1})
        {
            
        }
    }

    private static IEnumerable<string> BreakApartDefinedValue(DefinedValuesListTypeDefinedValue definedValue,
        QueryPlanHumanizer h)
    {
        if (definedValue.Item is ColumnReference itemColumnReference)
        {
            yield return h.Humanize(itemColumnReference);
        }

        if (definedValue.Item is DefinedValuesListTypeDefinedValueValueVector valueVector)
        {
            foreach (var columnReference in valueVector.ColumnReference)
            {
                yield return h.Humanize(columnReference);
            }
        }

        foreach (var item in definedValue.Items)
        {
            if (item is ColumnReference itemsColumnReference)
            {
                yield return h.Humanize(itemsColumnReference);
            }
            else if (item is Scalar scalar)
            {
                //yield return h.Humanize(scalar.);
            }
        }
    }

    private static string GetIndexScan(IndexScan indexScan, QueryPlanHumanizer queryPlanHumanizer)
    {
        var s = "Object: " + queryPlanHumanizer.Humanize(indexScan.Object[0]);

        if (indexScan.Predicate != null)
        {
            foreach (var scalarExpression in indexScan.Predicate)
            {
                s += Environment.NewLine + "Predicate: " + queryPlanHumanizer.Humanize(scalarExpression);
            }
        }

        return s;
    }
}
