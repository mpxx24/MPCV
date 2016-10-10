using System.Linq;
using System.Web.Mvc;
using MPCV.DatabaseAccess.Blog;
using MPCV.Services.Interfaces;

namespace MPCV.Controllers {
    public class BlogController : Controller {
        private readonly IBlogService blogService;

        public BlogController(IBlogService blogService) {
            this.blogService = blogService;
        }

        public ActionResult BlogPost(int postId) {
            var post = this.blogService.GetPost(postId);
            return View(post);  
        }
    }
}