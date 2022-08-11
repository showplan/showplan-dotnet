using System.Data.Common;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Showplan;

namespace ShowPlan.EntityFrameworkCore7.Interceptor;

public class ShowplanInterceptor : IDbCommandInterceptor
{
    private readonly Action<ShowPlanXML>? _foundShowPlanXml;
    private readonly Action<string>? _foundShowPlanString;
    private static readonly ShowplanDeserializer s_deserializer = new();

    public ShowplanInterceptor(Action<ShowPlanXML>? foundShowPlanXml = null,
        Action<string>? foundShowPlanString = null)
    {
        _foundShowPlanXml = foundShowPlanXml;
        _foundShowPlanString = foundShowPlanString;
    }

    public async ValueTask<InterceptionResult<DbDataReader>> ReaderExecutingAsync(DbCommand command, CommandEventData eventData, InterceptionResult<DbDataReader> result,
        CancellationToken cancellationToken = new CancellationToken())
    {
        command.CommandText = $"SET STATISTICS XML ON{Environment.NewLine}{command.CommandText}";
        return result;
    }

    public InterceptionResult<DbDataReader> ReaderExecuting(DbCommand command, CommandEventData eventData, InterceptionResult<DbDataReader> result)
    {
        command.CommandText = $"SET STATISTICS XML ON{Environment.NewLine}{command.CommandText}";
        return result;
    }

    public InterceptionResult DataReaderClosing(DbCommand command, DataReaderClosingEventData eventData,
        InterceptionResult result)
    {
        if (!eventData.DataReader.NextResult())
        {
            return result;
        }

        var columnName = eventData.DataReader.GetName(0);
        if (columnName != "Microsoft SQL Server 2005 XML Showplan")
        {
            return result;
        }

        eventData.DataReader.Read();
        var plan = eventData.DataReader.GetString(0);
        _foundShowPlanString?.Invoke(plan);
        _foundShowPlanXml?.Invoke(s_deserializer.Deserialize(plan));

        return result;
    }

    public async ValueTask<InterceptionResult> DataReaderClosingAsync(DbCommand command, DataReaderClosingEventData eventData, InterceptionResult result)
    {
        if (!await eventData.DataReader.NextResultAsync())
        {
            return result;
        }

        var columnName = eventData.DataReader.GetName(0);
        if (columnName != "Microsoft SQL Server 2005 XML Showplan")
        {
            return result;
        }

        await eventData.DataReader.ReadAsync();
        var plan = eventData.DataReader.GetString(0);
        _foundShowPlanString?.Invoke(plan);
        _foundShowPlanXml?.Invoke(s_deserializer.Deserialize(plan));

        return result;
    }
}
