using System.Xml.Serialization;

namespace Showplan.RelOps
{
    /// <remarks/>
    [XmlInclude(typeof(Generic))]
    [XmlInclude(typeof(Remote))]
    [XmlInclude(typeof(RemoteQuery))]
    [XmlInclude(typeof(Put))]
    [XmlInclude(typeof(RemoteModify))]
    [XmlInclude(typeof(RemoteFetch))]
    [XmlInclude(typeof(RemoteRange))]
    [XmlInclude(typeof(BatchHashTableBuild))]
    [XmlInclude(typeof(Spool))]
    [XmlInclude(typeof(WindowAggregate))]
    [XmlInclude(typeof(Window))]
    [XmlInclude(typeof(Udx))]
    [XmlInclude(typeof(Top))]
    [XmlInclude(typeof(Split))]
    [XmlInclude(typeof(Sequence))]
    [XmlInclude(typeof(Segment))]
    [XmlInclude(typeof(NestedLoops))]
    [XmlInclude(typeof(Merge))]
    [XmlInclude(typeof(Concat))]
    [XmlInclude(typeof(Switch))]
    [XmlInclude(typeof(Collapse))]
    [XmlInclude(typeof(Bitmap))]
    [XmlInclude(typeof(Sort))]
    [XmlInclude(typeof(TopSort))]
    [XmlInclude(typeof(StreamAggregate))]
    [XmlInclude(typeof(Parallelism))]
    [XmlInclude(typeof(ComputeScalar))]
    [XmlInclude(typeof(Hash))]
    [XmlInclude(typeof(TableValuedFunction))]
    [XmlInclude(typeof(ConstantScan))]
    [XmlInclude(typeof(Filter))]
    [XmlInclude(typeof(SimpleIteratorOneChild))]
    [XmlInclude(typeof(Rowset))]
    [XmlInclude(typeof(ScalarInsert))]
    [XmlInclude(typeof(CreateIndex))]
    [XmlInclude(typeof(Update))]
    [XmlInclude(typeof(SimpleUpdate))]
    [XmlInclude(typeof(IndexScan))]
    [XmlInclude(typeof(TableScan))]
    [XmlInclude(typeof(ForeignKeyReferencesCheck))]
    [XmlInclude(typeof(AdaptiveJoin))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("RelOpBaseType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class RelOpBase
    {
        /// <remarks/>
        [XmlArrayItem("DefinedValue", IsNullable = false)]
        public DefinedValuesListTypeDefinedValue[] DefinedValues { get; set; }

        /// <remarks/>
        public InternalInfo InternalInfo { get; set; }

        /// <remarks/>
        [XmlElementAttribute("RelOp")]
        public RelOp[] RelOp { get; set; }
    }
}
