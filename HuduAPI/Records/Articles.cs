using Newtonsoft.Json;

namespace HuduAPI.Records
{
    /// <summary>
    /// This internal class is used to help read the returned json from the HuduAPI endpoint. As the
    /// data contains a named element, there is a parent wrapper object, which this is
    /// </summary>
    /// <seealso cref="HuduAPI.Records.IRecord" />
    internal class ArticleRoot : IRecord
    {
        [JsonProperty("article")]
        public Article Article { get; set; }
    }

    /// <summary>
    /// Represents a single Article returned from the Hudu API
    /// </summary>
    /// <seealso cref="HuduAPI.Records.IRecord" />
    public class Article : IRecord
    {
        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("company_id")]
        public int? CompanyID { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("draft")]
        public bool? Draft { get; set; }

        [JsonProperty("enable_sharing")]
        public bool? EnableSharing { get; set; }

        [JsonProperty("folder_id")]
        public int? FolderID { get; set; }

        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("object_type")]
        public string ObjectType { get; set; }

        [JsonProperty("public_photos")]
        public IList<PublicPhoto> PublicPhotos { get; set; }

        [JsonProperty("share_url")]
        public string ShareUrl { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    /// <summary>
    /// Represents a list of articles returned from the Hudu API. Its a very basic class with a
    /// indexer to allow getting an article by name or id
    /// </summary>
    /// <seealso cref="HuduAPI.Records.IRecord" />
    public class Articles : IRecord
    {
        [JsonProperty("articles")]
        public IList<Article> ArticleList { get; set; }

        /// <summary>
        /// Gets the <see cref="System.Nullable{Article}" /> with the specified identifier. If no
        /// Article exists then returns null.
        /// </summary>
        /// <value>
        /// The <see cref="System.Nullable{Article}" /> with the ID value equal to id.
        /// </value>
        /// <param name="id">
        /// The Article ID.
        /// </param>
        /// <returns>
        /// </returns>
        public Article? this[int id]
        {
            get => ArticleList.FirstOrDefault(t => t.ID == id);
        }

        /// <summary>
        /// Gets the <see cref="System.Nullable{Article}" /> with the specified name for the
        /// specified company. If no Article exists then null is returned
        /// </summary>
        /// <value>
        /// The <see cref="System.Nullable{Article}" />.
        /// </value>
        /// <param name="company">
        /// The company ID to search for articles in.
        /// </param>
        /// <param name="name">
        /// The name of the article to search for.
        /// </param>
        /// <returns>
        /// </returns>
        public Article? this[int company, string name]
        {
            get => ArticleList.FirstOrDefault(t => t.Name == name & t.CompanyID == company);
        }
    }

    /// <summary>
    /// Represents the photo objects attached to an article
    /// </summary>
    public class PublicPhoto
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}