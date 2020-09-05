using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType("PartitionType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum Partition
    {
        /// <remarks/>
        Broadcast,

        /// <remarks/>
        Demand,

        /// <remarks/>
        Hash,

        /// <remarks/>
        NoPartitioning,

        /// <remarks/>
        Range,

        /// <remarks/>
        RoundRobin,

        /// <remarks/>
        CloneLocation,
    }
}
