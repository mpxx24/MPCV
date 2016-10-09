using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MPCV.DatabaseAccess;
using MPCV.DatabaseAccess.Blog;
using MPCV.Services.Interfaces;

namespace MPCV.Controllers {
    public class HomeController : Controller {
        private IBlogService blogService;
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
            //var testPost = new Post
            //{
            //    Id = 1,
            //    Category = PostCategory.Other,
            //    Title = "first post",
            //    Author = "mpx",
            //    ShortDescription = "this is just test, to create sth like a placeholder for post",
            //    Content = @"the code is:"+

            //          "<div class=\"code\">" +
            //          "<span class=\"class\">public class</span> UserWebApiService : IUserWebApiService { " +
            //          "<span class=\"method\">public IEnumerable</span><UserApiModel> GetWebApiUserResults() {" +
            //          "using (var ctx = new UserContext()) {" +
            //          "ctx.Configuration.ProxyCreationEnabled = false;" +
            //          "<span class\"type\">var</span> users = UserModelConverter.ConvertUserToApiModel(ctx.Users.Include(x => x.ProgrammingSkills).First());" +
            //          "return users;" +
            //          "}" +
            //          "}" +
            //          "}" +
            //          "</div>",
            //    Added = DateTime.Today,
            //    Comments = new List<string> { "hey", "helloooooooo"}

            //};

            //var testPost2 = new Post
            //{
            //    Id = 2,
            //    Category = PostCategory.Other,
            //    Title = "second post",
            //    Author = "mpx",
            //    ShortDescription = "weeee",
            //    Content = @"I don't know
            //                qwcdqnwcjouqnwjcunqwqwokedjmndokjqnwjdkn
            //                alksjndakjdnakjnkjasndk

            //                asldka
            //                aklsjndkasjdnakjdjakwjnd
            //                aksjdnaksjdnakdanie wiemasdnaiskjd nie wiem co tu napisac ale to i tak tylko terst
            //                co nie
            //                !@@##$^%*&%%%%%%",
            //    Added = DateTime.Today,
            //    Comments = new List<string> { "hey", "helloooooooo" }

            //};
            //var testPost3 = new Post
            //{
            //    Id = 2,
            //    Category = PostCategory.Other,
            //    Title = "third post",
            //    Author = "mpx",
            //    ShortDescription = "its nr 3",
            //    Content = @"I don't know
            //                qwcdqnwcjouqnwjcunqwqwokedjmndokjqnwjdkn
            //                alksjndakjdnakjnkjasndk

            //                asldka
            //                aklsjndkasjdnakjdjakwjnd
            //                aksjdnaksjdnakdanie wiemasdnaiskjd nie wiem co tu napisac ale to i tak tylko terst
            //                co nie
            //                !@@##$^%*&%%%%%%",
            //    Added = DateTime.Today,
            //    Comments = new List<string> { "hey", "helloooooooo" }

            //};
            //var testPost4 = new Post
            //{
            //    Id = 2,
            //    Category = PostCategory.Other,
            //    Title = "fourth post",
            //    Author = "mpx",
            //    ShortDescription = "#4",
            //    Content = @"I don't know
            //                qwcdqnwcjouqnwjcunqwqwokedjmndokjqnwjdkn
            //                alksjndakjdnakjnkjasndk

            //                asldka
            //                aklsjndkasjdnakjdjakwjnd
            //                aksjdnaksjdnakdanie wiemasdnaiskjd nie wiem co tu napisac ale to i tak tylko terst
            //                co nie
            //                !@@##$^%*&%%%%%%",
            //    Added = DateTime.Today,
            //    Comments = new List<string> { "hey", "helloooooooo" }

            //};
            //posts.Add(testPost);
            //posts.Add(testPost2);
            //posts.Add(testPost3);
            //posts.Add(testPost4);

            return View(posts.ToList());
        }
    }
}