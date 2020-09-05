﻿using System.Xml.Serialization;

namespace Showplan.Scalars
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("UdAggregateType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class UdAggregate
    {
        /// <remarks/>
        public DatabaseObject UdAggObject { get; set; }

        /// <remarks/>
        [XmlElement("ScalarOperator")]
        public Scalar[] ScalarOperator { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool Distinct { get; set; }
    }
}
