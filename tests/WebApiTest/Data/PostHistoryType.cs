using System;
using System.Collections.Generic;

namespace Showplan.Tests.Data
{
    public partial class PostHistoryType
    {
        public PostHistoryType()
        {
            PostHistories = new HashSet<PostHistory>();
        }

        public int Id { get; set; }
        public string Type { get; set; } = null!;

        public virtual ICollection<PostHistory> PostHistories { get; set; }
    }
}
