using System.Xml.Serialization;

namespace Showplan.RelOps
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("ScalarInsertType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class ScalarInsert : Rowset
    {
        /// <remarks/>
        public ScalarExpression SetPredicate { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool DmlRequestSort { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool DmlRequestSortSpecified { get; set; }
    }
}
