using Microsoft.EntityFrameworkCore;
using Shouldly;
using ShowPlan.EntityFrameworkCore7.Interceptor;
using Showplan.Extras;
using Showplan.Shouldly;
using Showplan.Tests.Interceptor7.Data;
using Xunit;

namespace Showplan.Tests.Interceptor7;

public class InterceptorTests
{
    [Fact]
    public void Can_get_showplan()
    {
        List<ShowPlanXML> showPlans = new();

        var action = new ShowplanXmlAction(s => showPlans.Add(s));
        var interceptor = new ShowplanInterceptor(action);
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
