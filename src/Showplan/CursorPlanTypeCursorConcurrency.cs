using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum CursorPlanTypeCursorConcurrency
    {
        /// <remarks/>
        [XmlEnum("Read Only")] ReadOnly,

        /// <remarks/>
        Pessimistic,

        /// <remarks/>
        Optimistic,
    }
}
