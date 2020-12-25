using System.Collections.Generic;

#nullable disable

namespace Showplan.Tests.Data
{
    public partial class VoteType
    {
        public VoteType()
        {
            Votes = new HashSet<Vote>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Vote> Votes { get; set; }
    }
}
