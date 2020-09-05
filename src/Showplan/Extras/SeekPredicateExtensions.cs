using System;
using System.Collections.Generic;

namespace Showplan.Extras
{
    public static class SeekPredicateExtensions
    {
        public static IList<(string name, string value)> GetFriendlyStrings(this SeekPredicateBase seekPredicate)
        {
            switch (seekPredicate)
            {
                case SeekPredicate sp:
                    return GetString(sp);
                case SeekPredicateNew spn:
                    return GetString(spn);
                case SeekPredicatePart spp:
                    return GetString(spp);
                default:
                    return Array.Empty<(string name, string value)>();
            }
        }

        private static IList<(string name, string value)> GetString(SeekPredicatePart seekPredicate)
        {
            var result = new List<(string name, string value)>();
            foreach (var predicate in seekPredicate.Items)
            {
                result.AddRange(GetString(predicate));
            }

            return result;
        }

        private static IList<(string name, string value)> GetString(SeekPredicateNew seekPredicate)
        {
            var result = new List<(string name, string value)>();
            foreach (var predicate in seekPredicate.SeekKeys)
            {
                result.AddRange(GetString(predicate));
            }

            return result;
        }

        private static IList<(string name, string value)> GetString(SeekPredicate seekPredicate)
        {
            var result = new List<(string name, string value)>();
            if (seekPredicate.Prefix != null)
            {
                var output =
                    $"{seekPredicate.Prefix.RangeColumns[0].GetFriendlyName()} ${seekPredicate.Prefix.ScanType.ToFriendlyName()} ${seekPredicate.Prefix.RangeExpressions[0].ScalarString}";
                result.Add(("Prefix", output));
            }

            if (seekPredicate.StartRange != null)
            {
                var output =
                    $"{seekPredicate.StartRange.RangeColumns[0].GetFriendlyName()} ${seekPredicate.StartRange.ScanType.ToFriendlyName()} ${seekPredicate.StartRange.RangeExpressions[0].ScalarString}";
                result.Add(("StartRange", output));
            }

            if (seekPredicate.EndRange != null)
            {
                var output =
                    $"{seekPredicate.EndRange.RangeColumns[0].GetFriendlyName()} ${seekPredicate.EndRange.ScanType.ToFriendlyName()} ${seekPredicate.EndRange.RangeExpressions[0].ScalarString}";
                result.Add(("EndRange", output));
            }

            if (seekPredicate.IsNotNull != null)
            {
                result.Add(("Is Not Null", seekPredicate.IsNotNull.ColumnReference.GetFriendlyName()));
            }

            return result;
        }
    }
}
