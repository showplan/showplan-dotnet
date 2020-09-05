using System.Xml.Serialization;

namespace Showplan
{
    [XmlInclude(typeof(SeekPredicate))]
    [XmlInclude(typeof(SeekPredicateNew))]
    [XmlInclude(typeof(SeekPredicatePart))]
    public class SeekPredicateBase
    {
    }
}
