namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Builder for the class <see cref="GetArticles">GetArticles</see>
    /// </summary>
    public class GetArticlesBuilder
    {
        private int? _companyID;
        private string? _name;
        private int? _page;
        private int? _pageSize;

        /// <summary>
        /// Create a new instance for the <see cref="GetArticlesBuilder">GetArticlesBuilder</see>
        /// </summary>
        public GetArticlesBuilder()
        {
            Reset();
        }

        /// <summary>
        /// Build a class of type <see cref="GetArticles">GetArticles</see> with all the defined values
        /// </summary>
        /// <returns>
        /// Returns a <see cref="GetArticles">GetArticles</see> class
        /// </returns>
        public GetArticles Build()
        {
            return new GetArticles
            {
                Name = _name,
                Page = _page,
                PageSize = _pageSize,
                CompanyID = _companyID
            };
        }

        /// <summary>
        /// Reset all properties' to the default value
        /// </summary>
        /// <returns>
        /// Returns the <see cref="GetArticlesBuilder">GetArticlesBuilder</see> with the properties reseted
        /// </returns>
        public GetArticlesBuilder Reset()
        {
            _companyID = default;
            _name = default;
            _page = default;
            _pageSize = default;

            return this;
        }

        /// <summary>
        /// Set a value of type <see cref="int">int?</see> for the property <paramref name="companyID">companyId</paramref>
        /// </summary>
        /// <param name="companyID">
        /// A value of type <see cref="int">int?</see> that will be defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetArticlesBuilder">GetArticlesBuilder</see> with the property
        /// <paramref name="companyID">companyId</paramref> defined
        /// </returns>
        public GetArticlesBuilder WithCompanyID(int companyID)
        {
            this._companyID = companyID;
            return this;
        }

        /// <summary>
        /// Set a value of type <see cref="string">string</see> for the property <paramref name="name">name</paramref>
        /// </summary>
        /// <param name="name">
        /// A value of type <see cref="string">string</see> that will be defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetArticlesBuilder">GetArticlesBuilder</see> with the property
        /// <paramref name="name">name</paramref> defined
        /// </returns>
        public GetArticlesBuilder WithName(string name)
        {
            this._name = name;
            return this;
        }

        /// <summary>
        /// Set a value of type <see cref="int">int?</see> for the property <paramref name="page">page</paramref>
        /// </summary>
        /// <param name="page">
        /// A value of type <see cref="int">int?</see> that will be defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetArticlesBuilder">GetArticlesBuilder</see> with the property
        /// <paramref name="page">page</paramref> defined
        /// </returns>
        public GetArticlesBuilder WithPage(int page)
        {
            this._page = page;
            return this;
        }

        /// <summary>
        /// Set a value of type <see cref="int">int?</see> for the property <paramref name="pageSize">pageSize</paramref>
        /// </summary>
        /// <param name="pageSize">
        /// A value of type <see cref="int">int?</see> that will be defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetArticlesBuilder">GetArticlesBuilder</see> with the property
        /// <paramref name="pageSize">pageSize</paramref> defined
        /// </returns>
        public GetArticlesBuilder WithPageSize(int pageSize)
        {
            this._pageSize = pageSize;
            return this;
        }
    }
}