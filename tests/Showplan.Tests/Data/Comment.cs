using System;

#nullable disable

namespace Showplan.Tests.Data
{
    public partial class Comment
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public int PostId { get; set; }
        public int? Score { get; set; }
        public string Text { get; set; }
        public int? UserId { get; set; }

        public virtual Post Post { get; set; }
        public virtual User User { get; set; }
    }
}
