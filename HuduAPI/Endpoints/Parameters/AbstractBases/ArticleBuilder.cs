using HuduAPI.Endpoints.Parameters.AbstractBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints.Parameters.AbstractBases
{
    /// <summary>
    /// An abstract builder to help build Article parameters for implementing classes.
    /// </summary>
    /// <typeparam name="TResult">
    /// The type of the paramater to build.
    /// </typeparam>
    /// <typeparam name="TBuilder">
    /// The type of the builder that is inherting this base class.
    /// </typeparam>
    public abstract class ArticleBuilder<TResult, TBuilder>
        where TResult : Article
        where TBuilder : ArticleBuilder<TResult, TBuilder>
    {
        protected int? _companyId;
        protected string _content;
        protected bool _enableSharing;
        protected int? _folderId;
        protected string _name;

        /// <summary>
        /// Gets the builder instance of the implmenting class type.
        /// </summary>
        private readonly TBuilder _builderInstance = null;

        /// <summary>
        /// Abstract class with shared methods for building article parameters
        /// </summary>
        /// <param name="name">
        /// The name of the article.
        /// </param>
        /// <param name="content">
        /// The content to be displayed in the article.
        /// </param>
        internal ArticleBuilder(string name, string content)
        {
            _companyId = default;
            _content = content;
            _enableSharing = default;
            _folderId = default;
            _name = name;
            _builderInstance = (TBuilder)this;
        }

        /// <summary>
        /// Set a value for companyId
        /// </summary>
        /// <param name="companyId">
        /// The company identifier.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithCompanyId(int companyId)
        {
            _companyId = companyId;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for content
        /// </summary>
        /// <param name="content">
        /// The content.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithContent(string content)
        {
            _content = content;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for enableSharing
        /// </summary>
        /// <param name="enableSharing">
        /// if set to <c>true</c> [enable sharing].
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithEnableSharing(bool enableSharing)
        {
            _enableSharing = enableSharing;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for folderId
        /// </summary>
        /// <param name="folderId">
        /// The folder identifier.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithFolderId(int folderId)
        {
            _folderId = folderId;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for name
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithName(string name)
        {
            _name = name;
            return _builderInstance;
        }

        /// <summary>
        /// Build a class of type <typeparamref name="TResult" /> with all the defined values
        /// </summary>
        /// <returns>
        /// Returns a <typeparamref name="TResult" /> class
        /// </returns>
        public abstract TResult Build();
    }
}