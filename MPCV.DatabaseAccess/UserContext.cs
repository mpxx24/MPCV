using System.Data.Entity;

namespace MPCV.DatabaseAccess {
    /// <summary>
    ///     User context
    /// </summary>
    public class UserContext : DbContext {
        public DbSet<User> Users { get; set; }
        public DbSet<ProgrammingSkill> ProgrammingSkills { get; set; }
    }
}