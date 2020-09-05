using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("SeekPredicateType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class SeekPredicate : SeekPredicateBase
    {
        /// <remarks/>
        public ScanRange Prefix { get; set; }

        /// <remarks/>
        public ScanRange StartRange { get; set; }

        /// <remarks/>
        public ScanRange EndRange { get; set; }

        /// <remarks/>
        public SingleColumnReference IsNotNull { get; set; }
    }
}
