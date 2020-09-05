using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType("CompareOpType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum CompareOp
    {
        /// <remarks/>
        [XmlEnum("BINARY IS")] BinaryIs,

        /// <remarks/>
        [XmlEnum("BOTH NULL")] BothNull,

        /// <remarks/>
        [XmlEnum("EQ")] Eq,

        /// <remarks/>
        [XmlEnum("GE")] Ge,

        /// <remarks/>
        [XmlEnum("GT")] Gt,

        /// <remarks/>
        [XmlEnum("IS")] Is,

        /// <remarks/>
        [XmlEnum("IS NOT")] IsNot,

        /// <remarks/>
        [XmlEnum("IS NOT NULL")] IsNotNull,

        /// <remarks/>
        [XmlEnum("IS NULL")] IsNull,

        /// <remarks/>
        [XmlEnum("LE")] Le,

        /// <remarks/>
        [XmlEnum("LT")] Lt,

        /// <remarks/>
        [XmlEnum("NE")] Ne,

        /// <remarks/>
        [XmlEnum("ONE NULL")] OneNull,
    }
}
