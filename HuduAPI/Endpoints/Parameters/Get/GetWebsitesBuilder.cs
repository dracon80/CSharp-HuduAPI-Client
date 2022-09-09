namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Builder for the class <see cref="GetWebsites">GetWebsites</see>
    /// </summary>
    public class GetWebsitesBuilder
    {
        private string? _name;
        private int? _page;
        private int? _pageSize;

        /// <summary>
        /// Create a new instance for the <see cref="GetWebsitesBuilder">GetWebsitesBuilder</see>
        /// </summary>
        public GetWebsitesBuilder()
        {
            Reset();
        }

        /// <summary>
        /// Build a class of type <see cref="GetWebsites">GetWebsites</see> with all the defined values
        /// </summary>
        /// <returns>
        /// Returns a <see cref="GetWebsites">GetWebsites</see> class
        /// </returns>
        public GetWebsites Build()
        {
            return new GetWebsites
            {
                Name = _name,
                Page = _page,
                PageSize = _pageSize
            };
        }

        /// <summary>
        /// Reset all properties' to the default value
        /// </summary>
        /// <returns>
        /// Returns the <see cref="GetWebsitesBuilder">GetWebsitesBuilder</see> with the properties reseted
        /// </returns>
        public GetWebsitesBuilder Reset()
        {
            _name = default;
            _page = default;
            _pageSize = default;

            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="name">name</paramref>
        /// </summary>
        /// <param name="name">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetWebsitesBuilder">GetWebsitesBuilder</see> with the property
        /// <paramref name="name">name</paramref> defined
        /// </returns>
        public GetWebsitesBuilder WithName(string name)
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
        /// Returns the <see cref="GetWebsitesBuilder">GetWebsitesBuilder</see> with the property
        /// <paramref name="page">page</paramref> defined
        /// </returns>
        public GetWebsitesBuilder WithPage(int page)
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
        /// Returns the <see cref="GetWebsitesBuilder">GetWebsitesBuilder</see> with the property
        /// <paramref name="pageSize">pageSize</paramref> defined
        /// </returns>
        public GetWebsitesBuilder WithPageSize(int pageSize)
        {
            _pageSize = pageSize;
            return this;
        }
    }
}