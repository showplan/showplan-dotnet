using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType("OrderType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum Order
    {
        /// <remarks/>
        [XmlEnum("BACKWARD")] Backward,

        /// <remarks/>
        [XmlEnum("FORWARD")] Forward,
    }
}
