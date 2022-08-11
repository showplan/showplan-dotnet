using System;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Showplan;

namespace ShowPlan.EntityFrameworkCore.Interceptor
{
    public class ShowplanInterceptor : DbCommandInterceptor
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

        public override InterceptionResult<DbDataReader> ReaderExecuting(DbCommand command, CommandEventData eventData, InterceptionResult<DbDataReader> result)
        {
            command.CommandText = $"SET STATISTICS XML ON{Environment.NewLine}{command.CommandText}";
            return base.ReaderExecuting(command, eventData, result);
        }

        public override ValueTask<InterceptionResult<DbDataReader>> ReaderExecutingAsync(DbCommand command,
            CommandEventData eventData, InterceptionResult<DbDataReader> result,
            CancellationToken cancellationToken = new())
        {
            command.CommandText = $"SET STATISTICS XML ON{Environment.NewLine}{command.CommandText}";

            return base.ReaderExecutingAsync(command, eventData, result, cancellationToken);
        }


        public override DbDataReader ReaderExecuted(DbCommand command, CommandExecutedEventData eventData,
            DbDataReader result)
        {
            return base.ReaderExecuted(command, eventData, GetShowplanDbReader(result));
        }

        public override ValueTask<DbDataReader> ReaderExecutedAsync(DbCommand command,
            CommandExecutedEventData eventData, DbDataReader result,
            CancellationToken cancellationToken = new())
        {
            return base.ReaderExecutedAsync(command, eventData, GetShowplanDbReader(result), cancellationToken);
        }

        private ShowplanDbReader GetShowplanDbReader(DbDataReader result)
        {
            var wrappedResult = new ShowplanDbReader(result, s =>
            {
                _foundShowPlanString?.Invoke(s);
                _foundShowPlanXml?.Invoke(s_deserializer.Deserialize(s));
            });
            return wrappedResult;
        }
    }
}
