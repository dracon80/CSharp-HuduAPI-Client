using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Builder for the class <see cref="CreateArticle">CreateArticle</see>
    /// </summary>
    public class CreateArticleBuilder
    {
        private int? _companyId;
        private string _content;
        private bool _enableSharing;
        private int? _folderId;
        private string _name;

        /// <summary>
        /// Create a new instance for the <see cref="CreateArticleBuilder">CreateArticleBuilder</see>
        /// </summary>
        /// <param name="name">
        /// The name of the article.
        /// </param>
        /// <param name="content">
        /// The content to be displayed in the article.
        /// </param>
        public CreateArticleBuilder(string name, string content)
        {
            Reset(name, content);
        }

        /// <summary>
        /// Reset all properties' to the default value
        /// </summary>
        /// <param name="name">
        /// The name of the article.
        /// </param>
        /// <param name="content">
        /// The content to be displayed in the article.
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateArticleBuilder">CreateArticleBuilder</see> with the
        /// properties reseted
        /// </returns>
        public CreateArticleBuilder Reset(string name, string content)
        {
            _companyId = default;
            _content = content;
            _enableSharing = default;
            _folderId = default;
            _name = name;

            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int" /> for the property <paramref name="companyId">companyId</paramref>
        /// </summary>
        /// <param name="companyId">
        /// A value of type <typeparamref name="int" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateArticleBuilder">CreateArticleBuilder</see> with the
        /// property <paramref name="companyId">companyId</paramref> defined
        /// </returns>
        public CreateArticleBuilder WithCompanyId(int companyId)
        {
            _companyId = companyId;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="content">content</paramref>
        /// </summary>
        /// <param name="content">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateArticleBuilder">CreateArticleBuilder</see> with the
        /// property <paramref name="content">content</paramref> defined
        /// </returns>
        public CreateArticleBuilder WithContent(string content)
        {
            _content = content;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="bool" /> for the property <paramref name="enableSharing">enableSharing</paramref>
        /// </summary>
        /// <param name="enableSharing">
        /// A value of type <typeparamref name="bool" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateArticleBuilder">CreateArticleBuilder</see> with the
        /// property <paramref name="enableSharing">enableSharing</paramref> defined
        /// </returns>
        public CreateArticleBuilder WithEnableSharing(bool enableSharing)
        {
            _enableSharing = enableSharing;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int" /> for the property <paramref name="folderId">folderId</paramref>
        /// </summary>
        /// <param name="folderId">
        /// A value of type <typeparamref name="int" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateArticleBuilder">CreateArticleBuilder</see> with the
        /// property <paramref name="folderId">folderId</paramref> defined
        /// </returns>
        public CreateArticleBuilder WithFolderId(int folderId)
        {
            _folderId = folderId;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="name">name</paramref>
        /// </summary>
        /// <param name="name">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateArticleBuilder">CreateArticleBuilder</see> with the
        /// property <paramref name="name">name</paramref> defined
        /// </returns>
        public CreateArticleBuilder WithName(string name)
        {
            _name = name;
            return this;
        }

        /// <summary>
        /// Build a class of type <see cref="CreateArticle">CreateArticle</see> with all the defined values
        /// </summary>
        /// <returns>
        /// Returns a <see cref="CreateArticle">CreateArticle</see> class
        /// </returns>
        public CreateArticle Build()
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