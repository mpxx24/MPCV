using System;

namespace MPCV.Models.JsonModels {
    /// <summary>
    ///     Model for adding new blog post
    /// </summary>
    [Serializable]
    public class AddPostModel {
        /// <summary>
        /// Gets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        ///     Gets or sets the title.
        /// </summary>
        /// <value>
        ///     The title.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        ///     Gets or sets the text.
        /// </summary>
        /// <value>
        ///     The text.
        /// </value>
        public string Text { get; set; }
    }
}