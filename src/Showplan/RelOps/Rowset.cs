using System.Xml.Serialization;

namespace Showplan.RelOps
{
    /// <remarks/>
    [XmlInclude(typeof(ScalarInsert))]
    [XmlInclude(typeof(CreateIndex))]
    [XmlInclude(typeof(Update))]
    [XmlInclude(typeof(SimpleUpdate))]
    [XmlInclude(typeof(IndexScan))]
    [XmlInclude(typeof(TableScan))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("RowsetType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class Rowset : RelOpBase
    {
        /// <remarks/>
        [XmlElement("Object")]
        public DatabaseObject[] Object { get; set; }
    }
}
