using System;

#nullable disable

namespace Showplan.Tests.Data
{
    public partial class PostHistory
    {
        public int Id { get; set; }
        public int PostHistoryTypeId { get; set; }
        public int PostId { get; set; }
        public string RevisionGuid { get; set; }
        public DateTime CreationDate { get; set; }
        public int? UserId { get; set; }
        public string UserDisplayName { get; set; }
        public string Comment { get; set; }
        public string Text { get; set; }

        public virtual Post Post { get; set; }
        public virtual PostHistoryType PostHistoryType { get; set; }
        public virtual User User { get; set; }
    }
}
