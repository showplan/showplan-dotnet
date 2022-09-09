using System.Data;
using System.Data.Common;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;

namespace ShowPlan.EntityFrameworkCore7.Interceptor;

public class ShowplanInterceptor : IDbCommandInterceptor
{
    private readonly IShowplanInterceptorAction[] _interceptorActions;

    public ShowplanInterceptor(IEnumerable<IShowplanInterceptorAction> interceptorActions)
    {
        _interceptorActions = interceptorActions.ToArray();
    }

    public ValueTask<InterceptionResult<DbDataReader>> ReaderExecutingAsync(DbCommand command,
        CommandEventData eventData, InterceptionResult<DbDataReader> result,
        CancellationToken cancellationToken = new CancellationToken())
    {
        SetStatisticsXmlOn(command);
        return ValueTask.FromResult(result);
    }

    public InterceptionResult<DbDataReader> ReaderExecuting(DbCommand command, CommandEventData eventData,
        InterceptionResult<DbDataReader> result)
    {
        SetStatisticsXmlOn(command);
        return result;
    }

    public InterceptionResult DataReaderClosing(DbCommand command, DataReaderClosingEventData eventData,
        InterceptionResult result)
    {
        if (eventData.DataReader.NextResult() && IsShowPlan(eventData))
        {
            eventData.DataReader.Read();
            RunActions(eventData);
        }

        return result;
    }

    public async ValueTask<InterceptionResult> DataReaderClosingAsync(DbCommand command,
        DataReaderClosingEventData eventData, InterceptionResult result)
    {
        if (await eventData.DataReader.NextResultAsync() && IsShowPlan(eventData))
        {
            await eventData.DataReader.ReadAsync();
            RunActions(eventData);
        }

        return result;
    }

    private static bool IsShowPlan(DataReaderEventData eventData)
    {
        var columnName = eventData.DataReader.GetName(0);
        return columnName == "Microsoft SQL Server 2005 XML Showplan";
    }

    private void RunActions(DataReaderEventData eventData)
    {
        var plan = eventData.DataReader.GetString(0);
        foreach (var action in _interceptorActions)
        {
            action.Intercepted(plan);
        }
    }

    private static void SetStatisticsXmlOn(IDbCommand command)
    {
        command.CommandText = $"SET STATISTICS XML ON{Environment.NewLine}{command.CommandText}";
    }
}
