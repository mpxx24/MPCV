using System.Web.Mvc;
using MPCV.DatabaseAccess.Blog;

namespace MPCV.Controllers {
    public class BlogController : Controller {
        public ActionResult Post(Post post) {
            return View(post);
        }
    }
}