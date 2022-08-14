using Humanizer;
using Showplan;
using ShowPlan.EntityFrameworkCore7.Interceptor;
using Showplan.Extras;
using Showplan.RelOps;
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
            var header =
                new Markup(
                    $"{plan.StatementType} [grey]Total Cost[/]:[blue]{plan.StatementSubTreeCost}[/] [grey]Est Rows[/]:{plan.StatementEstRows}");
            var tree = new PlanTree(header) { Guide = new RoundedTreeGuide(), Style = new Style(Color.Grey) };

            var root = new PlanTreeNode(RelOpToRenderable(plan.QueryPlan.RelOp),
                plan.QueryPlan.RelOp.PhysicalOp.ToString());
            tree.Nodes.Add(root);
            if (plan.QueryPlan.RelOp.Item is { RelOp: { } })
            {
                AddRecurse(root, plan.QueryPlan.RelOp.Item.RelOp);
            }

            AnsiConsole.Write(tree);
        }
    }

    private void AddRecurse(PlanTreeNode currentNode, IEnumerable<RelOp> children)
    {
        foreach (var child in children)
        {
            var childNode = new PlanTreeNode(RelOpToRenderable(child), child.PhysicalOp.ToString());
            currentNode.Nodes.Add(childNode);
            if (child.Item is { RelOp: { } })
            {
                AddRecurse(childNode, child.Item.RelOp);
            }
        }
    }

    private IRenderable RelOpToRenderable(RelOp relOp)
    {
        var table = new Table().NoBorder().HideHeaders();
        table.AddColumn(new TableColumn("Operation"));

        var other = relOp.Item switch
        {
            IndexScan indexScan => GetIndexScan(indexScan).EscapeMarkup(),
            TableScan tableScan => tableScan.Object[0].Humanize().EscapeMarkup() + " " + tableScan.Predicate.Humanize().EscapeMarkup(),
            Filter filter => filter.Predicate.Humanize().EscapeMarkup(),
            
            _ => string.Empty
        };

        table.AddRow(
            $"[grey]Cost[/]:[blue]{relOp.EstimatedTotalCost():F2}[/] [grey]Rows[/]:[blue]{relOp.EstimateRows.ToMetric(decimals: 1)}[/]");

        if (string.IsNullOrWhiteSpace(other) == false)
        {
            table.AddRow(other);
        }

        return table;
    }

    private static string GetIndexScan(IndexScan indexScan)
    {
        var s = "Object:" + indexScan.Object[0].Humanize();

        if (indexScan.Predicate != null)
        {
            foreach (var scalarExpression in indexScan.Predicate)
            {
                s +=  Environment.NewLine + "Predicate: " +  scalarExpression.Humanize();
            }
        }

        return s;
    }
}
