using System;
using System.Collections.Generic;
using System.Web.Mvc;
using MPCV.DatabaseAccess;

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
        public ActionResult Blog() {
            var posts = new List<Post>();
            var testPost = new Post
            {
                Id = 1,
                Category = PostCategory.Other,
                Title = "first post",
                Author = "mpx",
                ShortDescription = "this is just test, to create sth like a placeholder for post...",
                Content = @"I don't know
                            qwcdqnwcjouqnwjcunqwqwokedjmndokjqnwjdkn
                            alksjndakjdnakjnkjasndk

                            asldka
                            aklsjndkasjdnakjdjakwjnd
                            aksjdnaksjdnakdanie wiemasdnaiskjd nie wiem co tu napisac ale to i tak tylko terst
                            co nie
                            !@@##$^%*&%%%%%%",
                Added = DateTime.Today,
                Comments = new List<string> { "hey", "helloooooooo"}

            };
            posts.Add(testPost);

            return View(posts);
        }
    }
}