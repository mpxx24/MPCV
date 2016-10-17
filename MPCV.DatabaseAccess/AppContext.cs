using System.Data.Entity;
using MPCV.DatabaseAccess.Blog;
using MPCV.DatabaseAccess.User;

namespace MPCV.DatabaseAccess {
    /// <summary>
    ///     User context
    /// </summary>
    public class AppContext : DbContext {
        public DbSet<User.User> Users { get; set; }
        public DbSet<ProgrammingSkill> ProgrammingSkills { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Activity> Activities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            Database.SetInitializer<AppContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}