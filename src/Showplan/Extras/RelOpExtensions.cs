using System;
using System.Linq;
using Showplan.RelOps;

namespace Showplan.Extras
{
    public static class RelOpExtensions
    {
        public static double EstimatedTotalCost(this RelOp relOp)
        {
            if (relOp.Item.RelOp == null || relOp.Item.RelOp.Length == 0)
            {
                return relOp.EstimatedTotalSubtreeCost;
            }

            var sum = relOp.Item.RelOp.Aggregate(relOp.EstimatedTotalSubtreeCost,
                (current, childRelOp) => current - childRelOp.EstimatedTotalSubtreeCost);
            return Math.Max(sum, 0);
        }
    }
}
