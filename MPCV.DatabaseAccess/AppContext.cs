using System.Data.Entity;
using MPCV.DatabaseAccess.Blog;

namespace MPCV.DatabaseAccess {
    /// <summary>
    ///     User context
    /// </summary>
    public class AppContext : DbContext {
        public DbSet<User> Users { get; set; }
        public DbSet<ProgrammingSkill> ProgrammingSkills { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}