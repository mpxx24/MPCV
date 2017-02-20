using System.Collections.Generic;
using MPCV.DatabaseAccess.Blog;
using MPCV.Models.JsonModels;

namespace MPCV.Services.Interfaces {
    public interface IBlogService : IBaseService {
        /// <summary>
        ///     Gets the post with specified id.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        ///     <see cref="Post" />
        /// </returns>
        Post GetPost(int id);

        /// <summary>
        ///     Saves the comment.
        /// </summary>
        /// <param name="comment">The comment.</param>
        void SaveComment(BlogComment comment);

        /// <summary>
        ///     Gets all posts.
        /// </summary>
        /// <returns>
        ///     <see cref="List{T}" />
        /// </returns>
        List<Post> GetAllPosts();

        /// <summary>
        ///     Gets the x latest posts.
        /// </summary>
        /// <param name="howMany">The how many.</param>
        /// <returns>
        ///     <see cref="List{T}" />
        /// </returns>
        List<Post> GetXLatestPosts(int howMany);

    }
}