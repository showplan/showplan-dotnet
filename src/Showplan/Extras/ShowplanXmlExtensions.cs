using System.Collections.Generic;
using System.Linq;
using Showplan.StatementBlocks;

namespace Showplan.Extras
{
    public static class ShowplanXmlExtensions
    {
        public static IEnumerable<StmtSimple> GetStatementsWithQueryPlans(this ShowPlanXML showplan)
        {
            return showplan.BatchSequence
                .SelectMany(i => i)
                .SelectMany(i => i.Items)
                .OfType<StmtSimple>()
                .Where(i => i.QueryPlan != null);
        }
    }
}
