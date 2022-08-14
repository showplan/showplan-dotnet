using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace WebApiTest.Data;

internal static class QueryableExtensions
{
    public static IQueryable<T> TagWithSource<T>(this IQueryable<T> queryable,
        [NotParameterized] string? tag = default,
        [NotParameterized] [CallerLineNumber] int lineNumber = 0,
        [NotParameterized] [CallerFilePath] string filePath = "",
        [NotParameterized] [CallerMemberName] string memberName = "",
        [NotParameterized] [CallerArgumentExpression("queryable")]
        string argument = "")
    {
        return queryable.TagWith(GetTagContent(tag, lineNumber, filePath, memberName, argument));
    }

    private static string GetTagContent(string? tag, int lineNumber, string filePath, string memberName,
        string argument)
    {
        // argument could be multiple lines with whitespace so let's normalize it down to one line
        var trimmedLines = string.Join(
            string.Empty,
            argument.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries).Select(i => i.Trim())
        );

        var tagContent = string.IsNullOrWhiteSpace(tag)
            ? default
            : tag + Environment.NewLine;

        tagContent += trimmedLines + Environment.NewLine + $" at {memberName}() - {filePath}:{lineNumber}";

        return tagContent;
    }
}
