using System.Collections.Generic;
using System.Web.Mvc;
using MPCV.Models.JsonModels;
using MPCV.Services.Interfaces;

namespace MPCV.Controllers {
    public class HomeController : Controller {
        private readonly IBlogService blogService;
        private readonly IUserService userService;

        public HomeController(IBlogService blogService, IUserService userService) {
            this.blogService = blogService;
            this.userService = userService;
        }

        public ActionResult Index() {
            var posts = blogService.GetXLatestPosts(6);

            return View(posts);
        }

        public ActionResult PersonalInfo() {
            return View();
        }

        public ActionResult ProgrammingSkills() {
            var user = userService.GetFirstUser();

            return View(user);
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

        public JsonResult SkillsForGraph() {
            var skills = userService.GetFirstUser().ProgrammingSkills;

            var result = new ProgrammingSkillForChart();

            foreach (var programmingSkill in skills) {
                result.ProgrammingSkills.Add(new ChatSkillSerializable
                {
                    name = programmingSkill.SkillName,
                    value = programmingSkill.SkillLevel
                });
            }

            return Json(result);
        }
    }
}