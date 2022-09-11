using HuduAPI.Endpoints.Parameters.AbstractBases;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Provides the paramaters used to create a new article when calling the endpoint api/v1/articles
    /// </summary>
    public class CreateArticle : Article, IParameters
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateArticle" /> class with the two
        /// required fields for the endpoint API.
        /// </summary>
        /// <param name="name">
        /// The name of the article.
        /// </param>
        /// <param name="content">
        /// The content to be displayed in the article.
        /// </param>
        public CreateArticle(string name, string content) : base(name, content)
        {
        }
    }
}