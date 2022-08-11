namespace Showplan.Tests.Interceptor7.Data
{
    public partial class PostHistory
    {
        public int Id { get; set; }
        public int PostHistoryTypeId { get; set; }
        public int PostId { get; set; }

        /// <summary>
        /// At times more than one type of history record can be recorded by a single action. All of these will be grouped using the same RevisionGUID.
        /// </summary>
        public string RevisionGuid { get; set; } = null!;

        public DateTime CreationDate { get; set; }
        public int? UserId { get; set; }
        public string? UserDisplayName { get; set; }
        public string? Comment { get; set; }

        /// <summary>
        /// A raw version of the new value for a given revision.
        /// 
        /// If PostHistoryTypeId in (10,11,12,13,14,15,19,20,35) this column will contain a JSON encoded string with all users who have voted for the PostHistoryTypeId
        /// 
        /// If it is a duplicate close vote, the JSON string will contain an array of original questions as OriginalQuestionIds
        /// 
        /// If PostHistoryTypeId = 17 this column will contain migration details of either from &lt;url&gt; or to &lt;url&gt;
        /// </summary>
        public string? Text { get; set; }

        public string? ContentLicense { get; set; }

        public virtual Post Post { get; set; } = null!;
        public virtual PostHistoryType PostHistoryType { get; set; } = null!;
        public virtual User? User { get; set; }
    }
}
