using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType("SubqueryOperationType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum SubqueryOperation
    {
        /// <remarks/>
        [XmlEnum("EQ ALL")] EqAll,

        /// <remarks/>
        [XmlEnum("EQ ANY")] EqAny,

        /// <remarks/>
        [XmlEnum("EXISTS")] Exists,

        /// <remarks/>
        [XmlEnum("GE ALL")] GeAll,

        /// <remarks/>
        [XmlEnum("GE ANY")] GeAny,

        /// <remarks/>
        [XmlEnum("GT ALL")] GtAll,

        /// <remarks/>
        [XmlEnum("GT ANY")] GtAny,

        /// <remarks/>
        [XmlEnum("IN")] In,

        /// <remarks/>
        [XmlEnum("LE ALL")] LeAll,

        /// <remarks/>
        [XmlEnum("LE ANY")] LeAny,

        /// <remarks/>
        [XmlEnum("LT ALL")] LtAll,

        /// <remarks/>
        [XmlEnum("LT ANY")] LtAny,

        /// <remarks/>
        [XmlEnum("NE ALL")] NeAll,

        /// <remarks/>
        [XmlEnum("NE ANY")] NeAny,
    }
}
