using System.Xml.Serialization;

namespace Showplan.RelOps
{
    /// <remarks/>
    [XmlInclude(typeof(RemoteQuery))]
    [XmlInclude(typeof(Put))]
    [XmlInclude(typeof(RemoteModify))]
    [XmlInclude(typeof(RemoteFetch))]
    [XmlInclude(typeof(RemoteRange))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("RemoteType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class Remote : RelOpBase
    {
        /// <remarks/>
        [XmlAttribute()]
        public string RemoteDestination { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string RemoteSource { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string RemoteObject { get; set; }
    }
}
