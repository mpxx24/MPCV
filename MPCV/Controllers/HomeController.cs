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
            var posts = this.blogService.GetXLatestPosts(6);

            return this.View(posts);
        }
        
        public ActionResult ProgrammingSkills() {
            var user = this.userService.GetFirstUser();

            return this.View(user);
        }

        public ActionResult ProjectExamples() {
            return this.View();
        }

        public ActionResult Contact() {
            return this.View();
        }

        public ActionResult Blog() {
            var posts = this.blogService.GetAllPosts();

            return this.View(posts);
        }

        public JsonResult SkillsForGraph() {
            var skills = this.userService.GetFirstUser().ProgrammingSkills;

            var result = new ProgrammingSkillForChart();

            foreach (var programmingSkill in skills) {
                result.ProgrammingSkills.Add(new ChatSkillSerializable
                {
                    name = programmingSkill.SkillName,
                    value = programmingSkill.SkillLevel
                });
            }

            return this.Json(result);
        }
    }
}