using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Shouldly;
using Showplan.Extras;
using Showplan.RelOps;
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

            foreach (var columnReference in allRelOps.SelectMany(op => op.OutputList))
            {
                columnReference
                    .GetFriendlyName()
                    .ShouldNotBeNullOrWhiteSpace();
            }
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void Assumptions(string fileName)
        {
            var showplan = (ShowPlanXML)s_xmlSerializer.Deserialize(File.OpenRead(fileName));
            showplan.BatchSequence.ShouldNotBeEmpty();
            var statements = showplan
                .GetStatementsWithQueryPlans()
                .ToList();

            var allRelOps = statements.SelectMany(i => i.QueryPlan.GetFlattenedRelOps()).ToList();
            allRelOps.ShouldAllBe(i => i.EstimatedTotalCost() >= 0);

            var allScanOps = allRelOps.Select(i => i.Item).OfType<IndexScan>();
            foreach (var scanOp in allScanOps.Where(i => i.SeekPredicates != null))
            {
                foreach (var scanOpSeekPredicate in scanOp.SeekPredicates.Items)
                {
                    var output = scanOpSeekPredicate.GetFriendlyStrings();
                    foreach (var (name, value) in output)
                    {
                        name.ShouldNotBeNullOrWhiteSpace();
                        value.ShouldNotBeNullOrWhiteSpace();
                    }
                }
            }


            foreach (var columnReference in allRelOps.SelectMany(op => op.OutputList))
            {
                columnReference
                    .GetFriendlyName()
                    .ShouldNotBeNullOrWhiteSpace();
            }
        }

        [Fact]
        public void Can_calc_estimated_operator_cost()
        {
            var fileName = Path.Combine("plans", "How many upvotes do I have for each tag.sqlplan");
            var showplan = (ShowPlanXML)s_xmlSerializer.Deserialize(File.OpenRead(fileName));
            var ops = showplan
                .GetStatementsWithQueryPlans()
                .First()
                .QueryPlan
                .GetFlattenedRelOps()
                .ToList();

            ops.First().EstimatedTotalCost().ShouldBeInRange(0.013, 0.014);
            ops.Skip(1).First().EstimatedTotalCost().ShouldBeInRange(0.02, 0.03);
        }

        public static IEnumerable<object[]> Data => Directory.GetFiles("plans").Select(i => new object[] {i});
    }
}
