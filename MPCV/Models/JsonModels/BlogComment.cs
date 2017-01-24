namespace MPCV.Models.JsonModels {
    /// <summary>
    /// Deserialize class used to add new comment
    /// </summary>
    public class BlogComment {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Comment { get; set; }
    }
}