using System.Xml.Serialization;

namespace Showplan.Scalars
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("IdentType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class Ident
    {
        /// <remarks/>
        public ColumnReference ColumnReference { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Table { get; set; }
    }
}
