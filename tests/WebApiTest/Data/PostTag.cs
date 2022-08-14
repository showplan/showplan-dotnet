using System;
using System.Collections.Generic;

namespace Showplan.Tests.Data
{
    public partial class PostTag
    {
        public int PostId { get; set; }
        public string Tag { get; set; } = null!;

        public virtual Post Post { get; set; } = null!;
    }
}
