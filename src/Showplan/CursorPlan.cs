using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("CursorPlanType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class CursorPlan
    {
        /// <remarks/>
        [XmlElement("Operation")]
        public CursorPlanTypeOperation[] Operation { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string CursorName { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public CursorType CursorActualType { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool CursorActualTypeSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public CursorType CursorRequestedType { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool CursorRequestedTypeSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public CursorPlanTypeCursorConcurrency CursorConcurrency { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool CursorConcurrencySpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool ForwardOnly { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ForwardOnlySpecified { get; set; }
    }
}
