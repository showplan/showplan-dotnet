﻿using System.Xml.Serialization;

namespace Showplan.RelOps
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("BitmapType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class Bitmap : RelOpBase
    {
        /// <remarks/>
        [XmlArrayItem("ColumnReference", IsNullable = false)]
        public ColumnReference[] HashKeys { get; set; }
    }
}
