using System.Xml.Serialization;

namespace Showplan.RelOps
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("ConstantScanType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class ConstantScan : RelOpBase
    {
        /// <remarks/>
        [XmlArrayItem("Row", IsNullable = false)]
        [XmlArrayItem("ScalarOperator", IsNullable = false, NestingLevel = 1)]
        public Scalar[][] Values { get; set; }
    }
}
