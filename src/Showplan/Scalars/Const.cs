using System.Xml.Serialization;

namespace Showplan.Scalars
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("ConstType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class Const
    {
        /// <remarks/>
        [XmlAttribute()]
        public string ConstValue { get; set; }
    }
}
