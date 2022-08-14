using Microsoft.Extensions.Logging;
using Showplan;
using Showplan.Extras;
using Showplan.RelOps;
using Showplan.StatementBlocks;

namespace ShowPlan.EntityFrameworkCore7.Interceptor;

public class ShowplanLoggerActionContext
{
    private readonly ILogger _logger;

    public ShowplanLoggerActionContext(ILogger logger) => _logger = logger;

    public void LogInfo(string message) => _logger.LogInformation(message);
    public void LogWarning(string message) => _logger.LogWarning(message);
    public void LogError(string message) => _logger.LogError(message);
}

public interface IChecker<T>
{
    void Check(T item, ShowplanLoggerActionContext context);
}

public class ShowplanLoggerAction : IShowplanInterceptorAction
{
    private readonly ILogger<ShowplanLoggerAction> _logger;
    private readonly IChecker<StmtSimple>[] _statementCheckers;
    private readonly IChecker<RelOp>[] _relopCheckers;
    private readonly IChecker<QueryPlan> _queryPlanCheckers;
    private static readonly ShowplanDeserializer s_deserializer = new();

    public ShowplanLoggerAction(
        ILogger<ShowplanLoggerAction> logger,
        IChecker<StmtSimple>[] statementCheckers,
        IChecker<RelOp>[] relopCheckers,
        IChecker<QueryPlan> queryPlanCheckers)
    {
        _logger = logger;
        _statementCheckers = statementCheckers;
        _relopCheckers = relopCheckers;
        _queryPlanCheckers = queryPlanCheckers;
    }

    public void Intercepted(string showPlan)
    {
        var plan = s_deserializer.Deserialize(showPlan);
        var statements = plan.GetStatementsWithQueryPlans();
        foreach (var statement in statements)
        {
            if (statement.StatementSubTreeCost > 5)
            {
                _logger.LogWarning("Statement {queryText} cost of {cost} exceeded total cost limit {limit}.",
                    statement.QueryHash, statement.StatementSubTreeCost, 5);
            }
        }
    }
}
