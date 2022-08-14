using System;
using System.Collections.Generic;

namespace Showplan.Tests.Data
{
    public partial class Vote
    {
        /// <summary>
        /// The bounty amount. Present only if VoteTypeId in (8, 9)
        /// </summary>
        public int Id { get; set; }
        public int PostId { get; set; }
        /// <summary>
        /// The user Id of the voter. Present only if VoteTypeId in (5,8).
        /// </summary>
        public int? UserId { get; set; }
        public int? BountyAmount { get; set; }
        public int VoteTypeId { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual Post Post { get; set; } = null!;
        public virtual User? User { get; set; }
        public virtual VoteType VoteType { get; set; } = null!;
    }
}
