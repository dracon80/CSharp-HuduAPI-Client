namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Builder for the class <see cref="GetFolders">GetFolders</see>
    /// </summary>
    public class GetFoldersBuilder
    {
        private int? _companyId;
        private string? _name;
        private int? _page;
        private int? _pageSize;

        /// <summary>
        /// Create a new instance for the <see cref="GetFoldersBuilder">GetFoldersBuilder</see>
        /// </summary>
        public GetFoldersBuilder()
        {
            Reset();
        }

        /// <summary>
        /// Build a class of type <see cref="GetFolders">GetFolders</see> with all the defined values
        /// </summary>
        /// <returns>
        /// Returns a <see cref="GetFolders">GetFolders</see> class
        /// </returns>
        public GetFolders Build()
        {
            return new GetFolders
            {
                CompanyId = _companyId,
                Name = _name,
                Page = _page,
                PageSize = _pageSize
            };
        }

        /// <summary>
        /// Reset all properties' to the default value
        /// </summary>
        /// <returns>
        /// Returns the <see cref="GetFoldersBuilder">GetFoldersBuilder</see> with the properties reseted
        /// </returns>
        public GetFoldersBuilder Reset()
        {
            _name = default;
            _companyId = default;
            _page = default;
            _pageSize = default;

            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int?" /> for the property <paramref name="companyId">companyId</paramref>
        /// </summary>
        /// <param name="companyId">
        /// A value of type <typeparamref name="int?" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetFoldersBuilder">GetFoldersBuilder</see> with the property
        /// <paramref name="companyId">companyId</paramref> defined
        /// </returns>
        public GetFoldersBuilder WithCompanyId(int companyId)
        {
            _companyId = companyId;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="name">name</paramref>
        /// </summary>
        /// <param name="name">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetFoldersBuilder">GetFoldersBuilder</see> with the property
        /// <paramref name="name">name</paramref> defined
        /// </returns>
        public GetFoldersBuilder WithName(string name)
        {
            _name = name;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int?" /> for the property <paramref name="page">page</paramref>
        /// </summary>
        /// <param name="page">
        /// A value of type <typeparamref name="int?" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetFoldersBuilder">GetFoldersBuilder</see> with the property
        /// <paramref name="page">page</paramref> defined
        /// </returns>
        public GetFoldersBuilder WithPage(int page)
        {
            _page = page;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int?" /> for the property <paramref name="pageSize">pageSize</paramref>
        /// </summary>
        /// <param name="pageSize">
        /// A value of type <typeparamref name="int?" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetFoldersBuilder">GetFoldersBuilder</see> with the property
        /// <paramref name="pageSize">pageSize</paramref> defined
        /// </returns>
        public GetFoldersBuilder WithPageSize(int pageSize)
        {
            _pageSize = pageSize;
            return this;
        }
    }
}