using System.Linq;
using System.Web.Mvc;
using MPCV.Services.Interfaces;

namespace MPCV.Controllers {
    public class HomeController : Controller {
        private readonly IBlogService blogService;

        public HomeController(IBlogService blogService) {
            this.blogService = blogService;
        }

        public ActionResult Index() {
            return View();
        }

        public ActionResult PersonalInfo() {
            return View();
        }

        public ActionResult ProgrammingSkills() {
            return View();
        }

        public ActionResult ProjectExamples() {
            return View();
        }

        public ActionResult GithubRepository() {
            return View();
        }

        public ActionResult DownloadCv() {
            return View();
        }

        public ActionResult Contact() {
            return View();
        }

        public ActionResult Blog() {
            var posts = blogService.GetAllPosts();

            return View(posts);
        }
    }
}