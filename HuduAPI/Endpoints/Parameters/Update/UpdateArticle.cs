using HuduAPI.Endpoints.Parameters.AbstractBases;
using Newtonsoft.Json;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Provides all the properties needed to update an existing article using the hudu api api/v1/articles
    /// </summary>
    public class UpdateArticle : Article, IParameters
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateArticle" /> class with the required
        /// properties to update and existing article.
        /// </summary>
        /// <param name="id">
        /// The Article identifier.
        /// </param>
        /// <param name="name">
        /// The name of the article.
        /// </param>
        /// <param name="content">
        /// The content to be displayed in the article.
        /// </param>
        public UpdateArticle(int id, string name, string content) : base(name, content)
        {
            this.Id = id;
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonIgnore]
        public int Id { get; }

        public string PayloadType
        {
            get
            {
                return "article";
            }
        }
    }
}