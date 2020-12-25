using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Showplan.Tests.Data
{
    public partial class StackOverflowContext : DbContext
    {
        public StackOverflowContext()
        {
        }

        public StackOverflowContext(DbContextOptions<StackOverflowContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Badge> Badges { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<LinkType> LinkTypes { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<PostHistory> PostHistories { get; set; }
        public virtual DbSet<PostHistoryType> PostHistoryTypes { get; set; }
        public virtual DbSet<PostLink> PostLinks { get; set; }
        public virtual DbSet<PostType> PostTypes { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Vote> Votes { get; set; }
        public virtual DbSet<VoteType> VoteTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https: //go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=.;database=math;integrated security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Badge>(entity =>
            {
                entity.HasIndex(e => new {e.Id, e.UserId}, "IX_Badges__Id_UserId");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.HasIndex(e => new {e.Id, e.PostId}, "IX_Comments__Id_PostId");

                entity.HasIndex(e => new {e.Id, e.UserId}, "IX_Comments__Id_UserId");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(700);

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comments_PostId__Posts_Id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Comments_UserId__Users_Id");
            });

            modelBuilder.Entity<LinkType>(entity =>
            {
                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasIndex(e => new {e.Id, e.AcceptedAnswerId}, "IX_Posts_Id_AcceptedAnswerId")
                    .IsUnique();

                entity.HasIndex(e => new {e.Id, e.OwnerUserId}, "IX_Posts_Id_OwnerUserId")
                    .IsUnique();

                entity.HasIndex(e => new {e.Id, e.ParentId}, "IX_Posts_Id_ParentId")
                    .IsUnique();

                entity.HasIndex(e => new {e.Id, e.PostTypeId}, "IX_Posts__Id_PostTypeId");

                entity.HasIndex(e => e.PostTypeId, "IX_Posts__PostType");

                entity.Property(e => e.Body).IsRequired();

                entity.Property(e => e.ClosedDate).HasColumnType("datetime");

                entity.Property(e => e.CommunityOwnedDate).HasColumnType("datetime");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LastEditDate).HasColumnType("datetime");

                entity.Property(e => e.LastEditorDisplayName).HasMaxLength(40);

                entity.Property(e => e.Tags).HasMaxLength(150);

                entity.Property(e => e.Title).HasMaxLength(250);

                entity.HasOne(d => d.AcceptedAnswer)
                    .WithMany(p => p.InverseAcceptedAnswer)
                    .HasForeignKey(d => d.AcceptedAnswerId)
                    .HasConstraintName("FK_Posts_AcceptedAnswerId__Posts_Id");

                entity.HasOne(d => d.OwnerUser)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.OwnerUserId)
                    .HasConstraintName("FK_Posts_OwnerUserId__Users_Id");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Posts_ParentId__Posts_Id");

                entity.HasOne(d => d.PostType)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.PostTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Posts_PostTypeId__PostTypes_Id");
            });

            modelBuilder.Entity<PostHistory>(entity =>
            {
                entity.ToTable("PostHistory");

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.RevisionGuid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("RevisionGUID")
                    .IsFixedLength(true);

                entity.Property(e => e.Text).HasColumnType("ntext");

                entity.Property(e => e.UserDisplayName).HasMaxLength(40);

                entity.HasOne(d => d.PostHistoryType)
                    .WithMany(p => p.PostHistories)
                    .HasForeignKey(d => d.PostHistoryTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostHistory_PostHistoryTypeId__PostHistoryTypes_Id");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostHistories)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostHistory_PostId__Posts_Id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PostHistories)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_PostHistory_UserId__Users_Id");
            });

            modelBuilder.Entity<PostHistoryType>(entity =>
            {
                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PostLink>(entity =>
            {
                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.HasOne(d => d.LinkType)
                    .WithMany(p => p.PostLinks)
                    .HasForeignKey(d => d.LinkTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostLinks_LinkTypeId__LinkTypes_Id");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostLinkPosts)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostLinks_PostId__Posts_Id");

                entity.HasOne(d => d.RelatedPost)
                    .WithMany(p => p.PostLinkRelatedPosts)
                    .HasForeignKey(d => d.RelatedPostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostLinks_RelatedPostId__Posts_Id");
            });

            modelBuilder.Entity<PostType>(entity =>
            {
                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.Property(e => e.TagName)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.DisplayName, "IX_Users__DisplayName");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.EmailHash).HasMaxLength(40);

                entity.Property(e => e.LastAccessDate).HasColumnType("datetime");

                entity.Property(e => e.Location).HasMaxLength(100);

                entity.Property(e => e.WebsiteUrl).HasMaxLength(200);
            });

            modelBuilder.Entity<Vote>(entity =>
            {
                entity.HasIndex(e => new {e.Id, e.PostId}, "IX_Votes__Id_PostId");

                entity.HasIndex(e => e.VoteTypeId, "IX_Votes__VoteTypeId");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.Votes)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Votes_PostId__Posts_Id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Votes)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Votes_UserId__Users_Id");

                entity.HasOne(d => d.VoteType)
                    .WithMany(p => p.Votes)
                    .HasForeignKey(d => d.VoteTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Votes_UserId__VoteTypes_Id");
            });

            modelBuilder.Entity<VoteType>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
