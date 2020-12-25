using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shouldly;
using ShowPlan.EntityFrameworkCore.Interceptor;
using Showplan.Tests.Data;
using Xunit;

namespace Showplan.Tests
{
    public class InterceptorTests
    {
        [Fact]
        public async Task Test1()
        {
            List<ShowPlanXML> showPlans = new();
            var interceptor = new ShowplanInterceptor((s) => showPlans.Add(s));
            var options = new DbContextOptionsBuilder<StackOverflowContext>()
                .AddInterceptors(interceptor)
                .Options;

            var dbContext = new StackOverflowContext(options);
            var results = await dbContext.Comments.Where(i => i.Score > 5)
                .Select(i => i.UserId)
                .Distinct()
                .ToListAsync();

            results.ShouldNotBeEmpty();
            showPlans.ShouldNotBeEmpty();
        }

        [Fact]
        public async Task Split_queries_work_too()
        {
            List<ShowPlanXML> showPlans = new();
            var interceptor = new ShowplanInterceptor((s) => showPlans.Add(s));
            var options = new DbContextOptionsBuilder<StackOverflowContext>()
                .AddInterceptors(interceptor)
                .Options;

            var dbContext = new StackOverflowContext(options);
            var results = await dbContext.Users
                .AsSplitQuery()
                .Include(i => i.Comments)
                .ThenInclude(i => i.Post)
                .Take(10)
                .ToListAsync();

            results.ShouldNotBeEmpty();
            showPlans.ShouldNotBeEmpty();
        }
    }
}
