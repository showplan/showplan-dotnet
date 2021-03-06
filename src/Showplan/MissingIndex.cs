﻿using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("MissingIndexType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class MissingIndex
    {
        /// <remarks/>
        [XmlElement("ColumnGroup")]
        public ColumnGroup[] ColumnGroup { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Database { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Schema { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Table { get; set; }
    }
}
