using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [XmlType("ItemChoiceType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan",
        IncludeInSchema = false)]
    public enum ItemChoice
    {
        /// <remarks/>
        AdaptiveJoin,

        /// <remarks/>
        Assert,

        /// <remarks/>
        BatchHashTableBuild,

        /// <remarks/>
        Bitmap,

        /// <remarks/>
        Collapse,

        /// <remarks/>
        ComputeScalar,

        /// <remarks/>
        Concat,

        /// <remarks/>
        ConstantScan,

        /// <remarks/>
        CreateIndex,

        /// <remarks/>
        DeletedScan,

        /// <remarks/>
        Extension,

        /// <remarks/>
        Filter,

        /// <remarks/>
        ForeignKeyReferencesCheck,

        /// <remarks/>
        Generic,

        /// <remarks/>
        Hash,

        /// <remarks/>
        IndexScan,

        /// <remarks/>
        InsertedScan,

        /// <remarks/>
        LogRowScan,

        /// <remarks/>
        Merge,

        /// <remarks/>
        MergeInterval,

        /// <remarks/>
        NestedLoops,

        /// <remarks/>
        OnlineIndex,

        /// <remarks/>
        Parallelism,

        /// <remarks/>
        ParameterTableScan,

        /// <remarks/>
        PrintDataflow,

        /// <remarks/>
        Put,

        /// <remarks/>
        RemoteFetch,

        /// <remarks/>
        RemoteModify,

        /// <remarks/>
        RemoteQuery,

        /// <remarks/>
        RemoteRange,

        /// <remarks/>
        RemoteScan,

        /// <remarks/>
        RowCountSpool,

        /// <remarks/>
        ScalarInsert,

        /// <remarks/>
        Segment,

        /// <remarks/>
        Sequence,

        /// <remarks/>
        SequenceProject,

        /// <remarks/>
        SimpleUpdate,

        /// <remarks/>
        Sort,

        /// <remarks/>
        Split,

        /// <remarks/>
        Spool,

        /// <remarks/>
        StreamAggregate,

        /// <remarks/>
        Switch,

        /// <remarks/>
        TableScan,

        /// <remarks/>
        TableValuedFunction,

        /// <remarks/>
        Top,

        /// <remarks/>
        TopSort,

        /// <remarks/>
        Update,

        /// <remarks/>
        WindowAggregate,

        /// <remarks/>
        WindowSpool,
    }
}
