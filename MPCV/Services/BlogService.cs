using System.Collections.Generic;
using System.Linq;
using MPCV.DatabaseAccess;
using MPCV.DatabaseAccess.Blog;
using MPCV.Services.Interfaces;

namespace MPCV.Services {
    public class BlogService : IBlogService {
        public List<Post> GetAllPosts() {
            using (var ctx = new UserContext()) {
                return ctx.Posts.ToList();
            }
        }
    }
}