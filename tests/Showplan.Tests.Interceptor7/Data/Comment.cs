namespace Showplan.Tests.Interceptor7.Data
{
    public partial class Comment
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public int PostId { get; set; }
        public int? Score { get; set; }
        public string Text { get; set; } = null!;
        public int? UserId { get; set; }
        public string ContentLicense { get; set; } = null!;

        public virtual Post Post { get; set; } = null!;
        public virtual User? User { get; set; }
    }
}
