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

        public ActionResult BlogPost(int id) {
            var post = this.blogService.GetPost(id);
            return View(post);      
        }

        public ActionResult AddComment(string p) {
            return null;
        }
    }
}