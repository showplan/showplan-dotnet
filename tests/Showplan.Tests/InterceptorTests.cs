using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shouldly;
using ShowPlan.EntityFrameworkCore.Interceptor;
using Showplan.Extras;
using Showplan.Shouldly;
using Showplan.Tests.Data;
using Xunit;

namespace Showplan.Tests
{
    public class InterceptorTests
    {
        [Fact]
        public void Can_get_showplan()
        {
            List<ShowPlanXML> showPlans = new();

            var interceptor = new ShowplanInterceptor(s => showPlans.Add(s));
            var options = new DbContextOptionsBuilder<StackExchangeContext>()
                .AddInterceptors(interceptor)
                .Options;


            var dbContext = new StackExchangeContext(options);
            var chattyUsers = dbContext.Users.Where(i => i.Comments.Count > 25).ToList();
            chattyUsers.ShouldNotBeEmpty();

            var plan = showPlans.First().GetStatementsWithQueryPlans().First();
            plan.ShouldCostLessThan(5);
            plan.ShouldNotHaveAnyTableScans();
        }
    }

}
