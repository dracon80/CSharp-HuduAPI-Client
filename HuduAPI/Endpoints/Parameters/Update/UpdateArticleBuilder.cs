using HuduAPI.Endpoints.Parameters.AbstractBases;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Builder for the class <see cref="UpdateArticle">UpdateArticle</see>
    /// </summary>
    public class UpdateArticleBuilder : ArticleBuilder<UpdateArticle, UpdateArticleBuilder>
    {
        private int _id;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateArticleBuilder" /> class.
        /// </summary>
        /// <param name="id">
        /// The identifier.
        /// </param>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="content">
        /// The content.
        /// </param>
        public UpdateArticleBuilder(int id, string name, string content) : base(name, content)
        {
            _id = id;
        }

        /// <summary>
        /// Build a class of type <see cref="UpdateArticle" /> with all the defined values
        /// </summary>
        /// <returns>
        /// Returns a <see cref="UpdateArticle" /> class
        /// </returns>
        public override UpdateArticle Build()
        {
            return new UpdateArticle(_id, _name, _content)
            {
                CompanyId = _companyId,
                EnableSharing = _enableSharing,
                FolderId = _folderId
            };
        }

        /// <summary>
        /// Reset all properties' to the default value
        /// </summary>
        /// <returns>
        /// Returns the <see cref="UpdateArticleBuilder">UpdateArticleBuilder</see> with the
        /// properties reseted
        /// </returns>
        public UpdateArticleBuilder Reset()
        {
            _id = default;
            _name = default;
            _content = default;

            return this;
        }

        /// <summary>
        /// Set a value for id
        /// </summary>
        /// <param name="id">
        /// The identifier.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <see cref="UpdateArticle" />
        /// </returns>
        public UpdateArticleBuilder WithId(int id)
        {
            _id = id;
            return this;
        }
    }
}