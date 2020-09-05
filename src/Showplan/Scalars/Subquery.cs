using System.Xml.Serialization;
using Showplan.RelOps;

namespace Showplan.Scalars
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("SubqueryType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class Subquery
    {
        /// <remarks/>
        public Scalar ScalarOperator { get; set; }

        /// <remarks/>
        public RelOp RelOp { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public SubqueryOperation Operation { get; set; }
    }
}
