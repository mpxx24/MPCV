using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPCV.DatabaseAccess.User {
    public class Language {
        [Key]
        public int Id { get; set; }
        [Column("Language")]
        public LanguageItem LanguageItem { get; set; }
        public LanguageLevel LanguageLevel { get; set; }

        public virtual User User { get; set; }
    }
}