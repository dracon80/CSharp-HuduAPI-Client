using Newtonsoft.Json;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Provides the paramaters used to create a new article when calling the endpoint api/v1/articles
    /// </summary>
    public class CreateArticle : IParameters
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateArticle" /> class with the two
        /// required fields for the endpoint API..
        /// </summary>
        /// <param name="name">
        /// The name of the article.
        /// </param>
        /// <param name="content">
        /// The content to be displayed in the article.
        /// </param>
        public CreateArticle(string name, string content)
        {
            Name = name;
            Content = content;
        }

        /// <summary>
        /// Gets or sets the company identifier Used to associate article with company.
        /// </summary>
        /// <value>
        /// The company identifier.
        /// </value>
        [JsonProperty("company_id")]
        public int? CompanyId { get; set; }

        /// <summary>
        /// Gets or sets the content of the article.
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the article is shared. When true, this article
        /// has a public URL for users to view it non-authenticated.
        /// </summary>
        [JsonProperty("enable_sharing")]
        public bool EnableSharing { get; set; } = false;

        /// <summary>
        /// Gets or sets the id Used to associate article with folder.
        /// </summary>
        /// <value>
        /// The folder identifier.
        /// </value>
        [JsonProperty("folder_id")]
        public int? FolderId { get; set; }

        /// <summary>
        /// Gets or sets the name of the article.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}