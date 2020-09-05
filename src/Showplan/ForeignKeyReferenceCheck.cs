using System.Xml.Serialization;
using Showplan.RelOps;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("ForeignKeyReferenceCheckType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class ForeignKeyReferenceCheck
    {
        /// <remarks/>
        public IndexScan IndexScan { get; set; }
    }
}
