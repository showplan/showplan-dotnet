using System.Xml.Serialization;

namespace Showplan.RelOps
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("ComputeScalarType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class ComputeScalar : RelOpBase
    {
        /// <remarks/>
        [XmlAttribute()]
        public bool ComputeSequence { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ComputeSequenceSpecified { get; set; }
    }
}
