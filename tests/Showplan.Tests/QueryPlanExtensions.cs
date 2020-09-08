using System.Collections.Generic;
using Showplan.RelOps;

namespace Showplan.Tests
{
    public static class QueryPlanExtensions
    {
        public static IEnumerable<RelOp> GetFlattenedRelOps(this QueryPlan queryPlan)
        {
            return GetFlattenedRelOpsRecurse(queryPlan.RelOp);

            static List<RelOp> GetFlattenedRelOpsRecurse(RelOp current)
            {
                var items = new List<RelOp> {current};

                if (current.Item?.RelOp == null)
                {
                    return items;
                }

                foreach (var relOp in current.Item.RelOp)
                {
                    items.AddRange(GetFlattenedRelOpsRecurse(relOp));
                }

                return items;
            }
        }
    }
}
