using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using MPCV.DatabaseAccess.Blog;
using MPCV.Models.JsonModels;
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

        public void SaveComment(BlogComment comment) {
            var post = this.GetPost(comment.Id);

            if (post == null) {
                throw new ObjectNotFoundException($"Post with specified ID ({comment.Id}) doesn't exist");
            }

            if (string.IsNullOrEmpty(comment.Name)) {
                throw new ArgumentException($"Name can not be empty");
            }

            if (string.IsNullOrEmpty(comment.Comment)) {
                throw new ArgumentException("Comment can not be empty");
            }

            post.Comments.Add(new Comment
            {
                Added = DateTime.Now,
                Author = comment.Name,
                Post = post,
                Text = comment.Comment
            });

            this.repository.Edit(post);
        }

        /// <summary>
        /// Gets all posts.
        /// </summary>
        /// <returns><see cref="List{T}"/></returns>
        public List<Post> GetAllPosts() {
            return this.repository.GetAll<Post>().ToList();
        }

        /// <summary>
        /// Gets the post with specified id.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><see cref="Post"/></returns>
        public Post GetPost(int id) {
            return this.repository.GetFirst<Post>(x => x.Id == id);
        }

        /// <summary>
        /// Gets the x latest posts.
        /// </summary>
        /// <param name="howMany">The how many.</param>
        /// <returns><see cref="List{T}"/></returns>
        public List<Post> GetXLatestPosts(int howMany) {
            var allPosts = this.repository.GetAll<Post>().ToList();

            return allPosts.Count >= howMany 
                ? allPosts 
                : allPosts.OrderByDescending(x => x.Added).Take(howMany).ToList();
        } 
    }
}