using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType("StorageType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public enum Storage
    {
        /// <remarks/>
        RowStore,

        /// <remarks/>
        ColumnStore,

        /// <remarks/>
        MemoryOptimized,
    }
}
