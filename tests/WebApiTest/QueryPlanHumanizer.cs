using System.Text;
using Showplan;

namespace WebApiTest;

internal static class QueryPlanHumanizer
{
    public static string Humanize(this ScalarExpression scalarExpression)
    {
        return scalarExpression.ScalarOperator.ScalarString;
    }
    
    public static string Humanize(this DatabaseObject databaseObject)
    {
        var outString = new StringBuilder();

        if (!string.IsNullOrWhiteSpace(databaseObject.Table))
        {
            outString.Append(databaseObject.Table);
        }

        if (!string.IsNullOrWhiteSpace(databaseObject.Alias))
        {
            outString.Append($" as {databaseObject.Alias}");
        }

        return outString.ToString();
    }

    public static string Humanize(this ColumnReference columnReference)
    {
        var outString = new StringBuilder();

        if (!string.IsNullOrWhiteSpace(columnReference.Table))
        {
            outString.Append($"{columnReference.Table}.");
        }

        outString.Append(columnReference.Column);

        if (!string.IsNullOrWhiteSpace(columnReference.Alias))
        {
            outString.Append(" as ${columnReference.Alias}");
        }

        return outString.ToString();
    }
}
