using System.Text;

namespace Showplan.Extras
{
    public static class ColumnReferenceExtensions
    {
        public static string GetFriendlyName(this ColumnReference columnReference, bool stripBrackets = true)
        {
            var sb = new StringBuilder();
            if (!string.IsNullOrWhiteSpace(columnReference.Database))
            {
                sb.Append($"{columnReference.Database}.");
            }

            if (!string.IsNullOrWhiteSpace(columnReference.Schema))
            {
                sb.Append($"{columnReference.Schema}.");
            }

            if (!string.IsNullOrWhiteSpace(columnReference.Table))
            {
                sb.Append($"{columnReference.Table}.");
            }

            if (!string.IsNullOrWhiteSpace(columnReference.Column))
            {
                sb.Append($"{columnReference.Column}");
            }
            else
            {
                sb.Append("(unknown)");
            }

            if (!string.IsNullOrWhiteSpace(columnReference.Alias))
            {
                sb.Append($" as {columnReference.Alias}");
            }

            return sb.ToString();
        }
    }
}
