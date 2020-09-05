using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType("LogicalOperationType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum LogicalOperation
    {
        /// <remarks/>
        [XmlEnum("AND")] And,

        /// <remarks/>
        [XmlEnum("IMPLIES")] Implies,

        /// <remarks/>
        [XmlEnum("IS NOT NULL")] IsNotNull,

        /// <remarks/>
        [XmlEnum("IS NULL")] Isnull,

        /// <remarks/>
        [XmlEnum("IS")] Is,

        /// <remarks/>
        [XmlEnum("IsFalseOrNull")] IsFalseOrNull,

        /// <remarks/>
        [XmlEnum("NOT")] Not,

        /// <remarks/>
        [XmlEnum("OR")] Or,

        /// <remarks/>
        [XmlEnum("XOR")] Xor,
    }
}
