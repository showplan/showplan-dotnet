using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType("IndexKindType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum IndexKind
    {
        /// <remarks/>
        Heap,

        /// <remarks/>
        Clustered,

        /// <remarks/>
        FtsChangeTracking,

        /// <remarks/>
        FtsMapping,

        /// <remarks/>
        NonClustered,

        /// <remarks/>
        PrimaryXml,

        /// <remarks/>
        SecondaryXml,

        /// <remarks/>
        Spatial,

        /// <remarks/>
        ViewClustered,

        /// <remarks/>
        ViewNonClustered,

        /// <remarks/>
        NonClusteredHash,

        /// <remarks/>
        SelectiveXml,

        /// <remarks/>
        SecondarySelectiveXml,
    }
}
