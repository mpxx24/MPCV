using System.Linq;
using System.Web.Mvc;
using MPCV.DatabaseAccess.Blog;
using MPCV.Models.JsonModels;
using MPCV.Services.Interfaces;
using Newtonsoft.Json;

namespace MPCV.Controllers {
    public class BlogController : Controller {
        private readonly IBlogService blogService;

        public BlogController(IBlogService blogService) {
            this.blogService = blogService;
        }

        public ActionResult BlogPost(int id) {
            var post = this.blogService.GetPost(id);
            return this.View(post);      
        }

        public void AddComment(string p) {
            var comment = JsonConvert.DeserializeObject<BlogComment>(p);

            this.blogService.SaveComment(comment);
        }

        public ActionResult AddPost() {
            return this.View();
        }

        public void SavePost(string p) {
            var data = JsonConvert.DeserializeObject<AddPostModel>(p);

            this.blogService.AddPost(data);
        }
    }
}