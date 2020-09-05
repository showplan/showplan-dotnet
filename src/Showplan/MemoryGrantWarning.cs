using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType("MemoryGrantWarningType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum MemoryGrantWarning
    {
        /// <remarks/>
        [XmlEnum("Excessive Grant")] ExcessiveGrant,

        /// <remarks/>
        [XmlEnum("Used More Than Granted")] UsedMoreThanGranted,

        /// <remarks/>
        [XmlEnum("Grant Increase")] GrantIncrease,
    }
}
