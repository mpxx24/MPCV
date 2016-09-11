using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPCV.DatabaseAccess {
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
        public virtual User User { get; set; }
    }
}