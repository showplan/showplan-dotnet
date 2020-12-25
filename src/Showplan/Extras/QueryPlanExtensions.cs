using System.Collections.Generic;
using Showplan.RelOps;

namespace Showplan.Extras
{
    public static class QueryPlanExtensions
    {
        public static IEnumerable<RelOp> GetFlattenedRelOps(this QueryPlan queryPlan)
        {
            return GetFlattenedRelOpsRecurse(queryPlan.RelOp);

            static IEnumerable<RelOp> GetFlattenedRelOpsRecurse(RelOp current)
            {
                if (current.Item?.RelOp == null)
                {
                    yield return current;
                }
                else
                {
                    foreach (var relOp in current.Item.RelOp)
                    {
                        foreach (var op in GetFlattenedRelOpsRecurse(relOp))
                        {
                            yield return op;
                        }
                    }
                }
            }
        }
    }
}
