using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MPCV.DatabaseAccess.Blog {
    public class Post {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set;}
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime Added { get; set; }
        public PostCategory Category { get; set; }

        public virtual List<Comment> Comments { get; set; } 
    }
}