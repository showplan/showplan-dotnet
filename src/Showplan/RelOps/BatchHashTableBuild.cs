using System.Xml.Serialization;

namespace Showplan.RelOps
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("BatchHashTableBuildType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class BatchHashTableBuild : RelOpBase
    {
        /// <remarks/>
        [XmlAttribute()]
        public bool BitmapCreator { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool BitmapCreatorSpecified { get; set; }
    }
}
