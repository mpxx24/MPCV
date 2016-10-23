using System;
using System.ComponentModel.DataAnnotations;

namespace MPCV.DatabaseAccess.User {
    public class Activity {
        [Key]
        public int Id { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Description { get; set; }
        public ActivityCategory Category { get; set; }
        
        public virtual User User { get; set; }
    }
}