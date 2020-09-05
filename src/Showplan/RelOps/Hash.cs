using System.Xml.Serialization;

namespace Showplan.RelOps
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("HashType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class Hash : RelOpBase
    {
        /// <remarks/>
        [XmlArrayItem("ColumnReference", IsNullable = false)]
        public ColumnReference[] HashKeysBuild { get; set; }

        /// <remarks/>
        [XmlArrayItem("ColumnReference", IsNullable = false)]
        public ColumnReference[] HashKeysProbe { get; set; }

        /// <remarks/>
        public ScalarExpression BuildResidual { get; set; }

        /// <remarks/>
        public ScalarExpression ProbeResidual { get; set; }

        /// <remarks/>
        public StarJoinInfo StarJoinInfo { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool BitmapCreator { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool BitmapCreatorSpecified { get; set; }
    }
}
