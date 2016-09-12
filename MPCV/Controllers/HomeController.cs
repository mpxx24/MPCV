using System.Web.Mvc;

namespace MPCV.Controllers {
    public class HomeController : Controller {
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
    }
}