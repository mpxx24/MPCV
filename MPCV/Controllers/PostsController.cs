using System.Collections.Generic;
using System.Web.Http;
using MPCV.DatabaseAccess.Blog;
using MPCV.Services.Interfaces;

namespace MPCV.Controllers {
    public class PostsController : ApiController {
        private readonly IBlogService blogService;

        public PostsController(IBlogService blogService) {
            this.blogService = blogService;
        }

        public IEnumerable<Post> Get() {
            return this.blogService.GetAllPosts();
        }

        public Post Get(int id) {
            return this.blogService.GetPost(id);
        }
    }
}