using System.Collections.Generic;
using System.Linq;
using MPCV.DatabaseAccess.Blog;
using MPCV.Repository;
using MPCV.Services.Interfaces;

namespace MPCV.Services {
    /// <summary>
    /// BlogService class
    /// </summary>
    public class BlogService : IBlogService {
        private readonly IRepository repository;

        public BlogService(IRepository repository) {
            this.repository = repository;
        }

        /// <summary>
        /// Gets all posts.
        /// </summary>
        /// <returns><see cref="List{T}"/></returns>
        public List<Post> GetAllPosts() {
            return repository.GetAll<Post>().ToList();
        }

        /// <summary>
        /// Gets the post with specified id.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><see cref="Post"/></returns>
        public Post GetPost(int id) {
            return repository.GetFirst<Post>(x => x.Id == id);
        }

        /// <summary>
        /// Gets the x latest posts.
        /// </summary>
        /// <param name="howMany">The how many.</param>
        /// <returns><see cref="List{T}"/></returns>
        public List<Post> GetXLatestPosts(int howMany) {
            var allPosts = repository.GetAll<Post>().ToList();

            if (allPosts.Count >= howMany) {
                return allPosts;
            }
            return allPosts.OrderByDescending(x => x.Added).Take(howMany).ToList();
        } 
    }
}