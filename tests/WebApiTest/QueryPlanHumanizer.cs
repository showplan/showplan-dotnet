using System.Text;
using Showplan;

namespace WebApiTest;

internal class QueryPlanHumanizer
{
    private readonly string _givenDb;
    private readonly string _givenSchema;

    public QueryPlanHumanizer(string givenDb, string givenSchema)
    {
        _givenDb = givenDb;
        _givenSchema = givenSchema;
    }

    public string Humanize(ScalarExpression scalarExpression)
    {
        return StripExpressionOfDbAndSchema(scalarExpression.ScalarOperator.ScalarString).Replace("[", "").Replace("]", "");
    }

    public string Humanize(DatabaseObject databaseObject)
    {
        var outString = new StringBuilder();

        if (!string.IsNullOrWhiteSpace(databaseObject.Table))
        {
            outString.Append(Unescape(databaseObject.Table));
        }

        if (!string.IsNullOrWhiteSpace(databaseObject.Alias))
        {
            outString.Append($" as {Unescape(databaseObject.Alias)}");
        }

        return outString.ToString();
    }

    public string Humanize(ColumnReference columnReference)
    {
        var outString = new StringBuilder();

        if (!string.IsNullOrWhiteSpace(columnReference.Table))
        {
            outString.Append($"{Unescape(columnReference.Table)}.");
        }

        outString.Append(columnReference.Column);

        if (!string.IsNullOrWhiteSpace(columnReference.Alias))
        {
            outString.Append($" as {Unescape(columnReference.Alias)}");
        }

        return outString.ToString();
    }

    private string StripExpressionOfDbAndSchema(string input)
    {
        return input.Replace(_givenDb + ".", string.Empty).Replace(_givenSchema + ".", string.Empty);
    }
    
    private static string Unescape(string input)
    {
        return input.Contains(" ")
            ? input
            : input.Replace("[", "").Replace("]", "");
    }
}
