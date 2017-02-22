using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using Castle.Core.Logging;
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
        private readonly ILogger log;

        public BlogService(IRepository repository, ILogger log) {
            this.repository = repository;
            this.log = log;
        }

        public void SaveComment(BlogComment comment) {
            var post = this.GetPost(comment.Id);

            if (post == null) {
                throw new ObjectNotFoundException($"Post with specified ID ({comment.Id}) doesn't exist");
            }

            if (string.IsNullOrEmpty(comment.Name)) {
                throw new ArgumentNullException($"{nameof(comment.Name)} can not be empty");
            }

            if (string.IsNullOrEmpty(comment.Comment)) {
                throw new ArgumentNullException($"{nameof(comment.Comment)} can not be empty");
            }

            post.Comments.Add(new Comment
            {
                Added = DateTime.Now,
                Author = comment.Name,
                Post = post,
                Text = comment.Comment
            });

            this.repository.Edit(post);
            this.log.InfoFormat($"Comment by {comment.Name} was added to post {post.Title}");
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

        /// <summary>
        /// Adds the post.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public void AddPost(AddPostModel data) {
            if (string.IsNullOrEmpty(data.Title)) {
                throw new ArgumentNullException($"{nameof(data.Title)} can not be empty");
            }

            if (string.IsNullOrEmpty(data.Description)) {
                throw new ArgumentNullException($"{nameof(data.Description)} can not be null");
            }

            if (string.IsNullOrEmpty(data.Text)) {
                throw new ArgumentNullException($"{nameof(data.Text)} can not be empty");
            }

            this.repository.Add(new Post {Title = data.Title, ShortDescription = data.Description, Content = data.Text, Added = DateTime.Now, Author = "Mariusz Piątkowski", Comments = new List<Comment>()});
            this.log.InfoFormat($"New post '{data.Title}' was added!");
        }
    }
}