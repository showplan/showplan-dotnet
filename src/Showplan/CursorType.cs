using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum CursorType
    {
        /// <remarks/>
        Dynamic,

        /// <remarks/>
        FastForward,

        /// <remarks/>
        Keyset,

        /// <remarks/>
        SnapShot,
    }
}
