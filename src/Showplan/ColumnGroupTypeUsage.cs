﻿using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum ColumnGroupTypeUsage
    {
        /// <remarks/>
        [XmlEnum("EQUALITY")] Equality,

        /// <remarks/>
        [XmlEnum("INEQUALITY")] Inequality,

        /// <remarks/>
        [XmlEnum("INCLUDE")] Include,
    }
}
