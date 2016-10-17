using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPCV.DatabaseAccess.User {
    /// <summary>
    ///     Programing skill class
    /// </summary>
    public class ProgrammingSkill {
        [Key]
        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public int SkillLevel { get; set; }

        public Guid UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual DatabaseAccess.User.User User { get; set; }
    }
}