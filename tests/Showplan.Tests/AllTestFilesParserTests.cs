using System.Collections.Generic;
using System.IO;
using System.Linq;
using Shouldly;
using Showplan.Extras;
using Showplan.Shouldly;
using Xunit;

namespace Showplan.Tests
{
    public class AllTestFilesParserTests
    {
        private static readonly ShowplanDeserializer s_showplanDeserializer = new();

        [Theory]
        [MemberData(nameof(Data))]
        public void Can_parse(string fileName)
        {
            var showplan = s_showplanDeserializer.Deserialize(File.OpenRead(fileName));

            showplan.BatchSequence.ShouldNotBeEmpty();
            var statements = showplan
                .GetStatementsWithQueryPlans()
                .ToList();

            statements.FirstOrDefault()?.ShouldSatisfyAllConditions(
                s => s.ShouldCostLessThan(100),
                s => s.QueryPlan.ShouldNotHaveAnyTableScans()
            );

            // verify that we can at least get the estimated total cost of all statements
            var allRelOps = statements.SelectMany(i => i.QueryPlan.GetFlattenedRelOps()).ToList();
            foreach (var op in allRelOps)
            {
                op
                    .EstimatedTotalCost()
                    .ShouldBeGreaterThanOrEqualTo(0);
            }
        }

        public static IEnumerable<object[]> Data => Directory.GetFiles("plans").Select(i => new object[] {i});
    }
}
