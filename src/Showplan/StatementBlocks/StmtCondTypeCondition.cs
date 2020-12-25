using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Showplan.StatementBlocks
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class StmtCondTypeCondition
    {
        /// <remarks/>
        public QueryPlan QueryPlan { get; set; }

        /// <remarks/>
        [XmlElement("UDF")]
        public Function[] Udf { get; set; }
    }
}
