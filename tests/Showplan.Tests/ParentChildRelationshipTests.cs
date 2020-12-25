using System.IO;
using System.Linq;
using Shouldly;
using Showplan.Extras;
using Xunit;

namespace Showplan.Tests
{
    public class ParentChildRelationshipTests
    {
        [Fact]
        public void Parent_is_set_on_statements()
        {
            var deserializer = new ShowplanDeserializer();
            var showplan = deserializer.Deserialize(File.OpenRead("plans/nested-loops.sqlplan"));
            var plans = showplan
                .GetStatementsWithQueryPlans()
                .Select(i => i.QueryPlan);

            plans.ShouldAllBe(i => i.Statement != null);
        }
    }
}
