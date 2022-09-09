using Microsoft.Extensions.Logging;
using Showplan;
using Showplan.Extras;
using Showplan.RelOps;
using Showplan.StatementBlocks;

namespace ShowPlan.EntityFrameworkCore7.Interceptor;

public class ShowplanLoggerAction : IShowplanInterceptorAction
{
    private readonly ILogger<ShowplanLoggerAction> _logger;
    private static readonly ShowplanDeserializer s_deserializer = new();

    public ShowplanLoggerAction(ILogger<ShowplanLoggerAction> logger)
    {
        _logger = logger;
    }

    public void Intercepted(string showPlan)
    {
        var plan = s_deserializer.Deserialize(showPlan);
        var statements = plan.GetStatementsWithQueryPlans();
        foreach (var statement in statements)
        {
            var costLimit = 5;
            if (statement.StatementSubTreeCost > costLimit)
            {
                _logger.LogWarning("Statement {queryText} cost of {cost} exceeded total cost limit {limit}.",
                    statement.QueryHash, statement.StatementSubTreeCost, costLimit);
            }
        }
    }
}
