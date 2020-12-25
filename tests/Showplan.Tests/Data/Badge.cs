using System;

#nullable disable

namespace Showplan.Tests.Data
{
    public partial class Badge
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
    }
}
