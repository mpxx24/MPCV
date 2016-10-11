using System.Collections.Generic;
using System.Linq;
using MPCV.DatabaseAccess.Blog;
using MPCV.Repository;
using MPCV.Services.Interfaces;

namespace MPCV.Services {
    public class BlogService : IBlogService {
        private readonly IRepository repository;

        public BlogService(IRepository repository) {
            this.repository = repository;
        }

        public List<Post> GetAllPosts() {
            return repository.GetAll<Post>().ToList();
        }

        public Post GetPost(int id) {
            return repository.GetFirst<Post>(x => x.Id == id);
        }
    }
}