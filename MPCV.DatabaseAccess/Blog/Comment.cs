using System;
using System.ComponentModel.DataAnnotations;

namespace MPCV.DatabaseAccess.Blog {
    public class Comment {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Added { get; set; }
        public string Author { get; set; }

        public virtual Post Post { get; set; }
    }
}