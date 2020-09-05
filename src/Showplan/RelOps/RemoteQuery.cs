using System.Xml.Serialization;

namespace Showplan.RelOps
{
    /// <remarks/>
    [XmlInclude(typeof(Put))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("RemoteQueryType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class RemoteQuery : Remote
    {
        /// <remarks/>
        [XmlAttribute("RemoteQuery")]
        public string Query { get; set; }
    }
}
