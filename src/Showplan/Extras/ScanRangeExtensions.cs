namespace Showplan.Extras
{
    public static class ScanRangeExtensions
    {
        public static string ToFriendlyName(this CompareOp compareOp)
        {
            switch (compareOp)
            {
                case CompareOp.Eq:
                    return "=";
                case CompareOp.Ge:
                    return ">=";
                case CompareOp.Gt:
                    return ">";
                case CompareOp.Le:
                    return "<=";
                case CompareOp.Lt:
                    return "<";
                case CompareOp.Ne:
                    return "!=";
                default:
                    return compareOp.ToString();
            }
        }
    }
}
