using System.Linq;
using Shouldly;
using Showplan.Extras;
using Showplan.StatementBlocks;

namespace Showplan.Shouldly
{
    [ShouldlyMethods]
    public static class ShowplanShouldlyExtensions
    {
        public static void ShouldCostLessThan(this StmtSimple statement, double cost)
        {
            statement.AssertAwesomely(a => a.StatementSubTreeCost < cost, statement.StatementSubTreeCost, cost);
        }

        public static void ShouldNotHaveAnyTableScans(this StmtSimple statement, string? customMessage = null)
        {
            var flattenedRelOps = statement.QueryPlan.GetFlattenedRelOps();
            var tablesScans = flattenedRelOps.Where(i => i.PhysicalOp == PhysicalOp.TableScan).ToList();
            if (tablesScans.Any())
            {
                throw new ShouldAssertException(new ExpectedActualShouldlyMessage("PhysicalOp == PhysicalOp.TableScan", tablesScans, customMessage).ToString());
            }
        }
    }
}
