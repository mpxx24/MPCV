using System.Collections.Generic;
using MPCV.DatabaseAccess.Blog;

namespace MPCV.Services.Interfaces {
    public interface IBlogService {
        IEnumerable<Post> GetAllPosts();
    }
}