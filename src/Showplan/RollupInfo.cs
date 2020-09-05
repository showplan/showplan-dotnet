using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("RollupInfoType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class RollupInfo
    {
        /// <remarks/>
        [XmlElement("RollupLevel")]
        public RollupLevel[] RollupLevel { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int HighestLevel { get; set; }
    }
}
