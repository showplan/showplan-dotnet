namespace Showplan.Tests.Interceptor7.Data
{
    public partial class Badge
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        /// <summary>
        /// The class of the badge. 1 = Gold, 2 = Silver, 3 = Bronze.
        /// </summary>
        public int Class { get; set; }
        /// <summary>
        /// True if badge is for a tag, otherwise it is a named badge.
        /// </summary>
        public bool TagBased { get; set; }
    }
}
