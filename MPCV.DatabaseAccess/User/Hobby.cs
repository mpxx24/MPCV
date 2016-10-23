using System.ComponentModel.DataAnnotations;

namespace MPCV.DatabaseAccess.User {
    public class Hobby {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSport { get; set; }

        public virtual User User { get; set; }
    }
}