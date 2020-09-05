using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(TypeName = "ColumnReferenceListType",
        Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class ColumnReferenceList
    {
        /// <remarks/>
        [XmlElement("ColumnReference")]
        public ColumnReference[] ColumnReference { get; set; }
    }
}
