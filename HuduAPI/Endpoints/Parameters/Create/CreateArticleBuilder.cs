namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Builder for the class <see cref="CreateArticle">CreateArticle</see>
    /// </summary>
    public class CreateArticleBuilder : CUArticleBuilder<CreateArticle, CreateArticleBuilder>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateArticleBuilder" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the article.
        /// </param>
        /// <param name="content">
        /// The content to be displayed in the article.
        /// </param>
        public CreateArticleBuilder(string name, string content) : base(name, content)
        {
        }

        /// <summary>
        /// Build a class of type <see cref="CreateArticle">CreateArticle</see> with all the defined values
        /// </summary>
        /// <returns>
        /// Returns a <see cref="CreateArticle">CreateArticle</see> class
        /// </returns>
        public override CreateArticle Build()
        {
            return new CreateArticle(_name, _content)
            {
                CompanyId = _companyId,
                EnableSharing = _enableSharing,
                FolderId = _folderId
            };
        }
    }
}