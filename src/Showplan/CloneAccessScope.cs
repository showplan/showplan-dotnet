using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType("CloneAccessScopeType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum CloneAccessScope
    {
        /// <remarks/>
        Primary,

        /// <remarks/>
        Secondary,

        /// <remarks/>
        Both,

        /// <remarks/>
        Either,

        /// <remarks/>
        ExactMatch,

        /// <remarks/>
        Local,
    }
}
