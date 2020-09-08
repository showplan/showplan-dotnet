using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Shouldly;
using Showplan.Extras;
using Xunit;

namespace Showplan.Tests
{
    public class AllTestFilesParserTests
    {
        private static readonly XmlSerializer s_xmlSerializer = new XmlSerializer(typeof(ShowPlanXML));

        [Theory]
        [MemberData(nameof(Data))]
        public void Can_parse(string fileName)
        {
            var showplan = (ShowPlanXML)s_xmlSerializer.Deserialize(File.OpenRead(fileName));
            showplan.BatchSequence.ShouldNotBeEmpty();
            var statements = showplan
                .GetStatementsWithQueryPlans()
                .ToList();

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
