namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Builder for the class <see cref="GetProcedures">GetProcedures</see>
    /// </summary>
    public class GetProceduresBuilder
    {
        private int? _companyId;
        private string? _name;
        private int? _page;
        private int? _pageSize;

        /// <summary>
        /// Create a new instance for the <see cref="GetProceduresBuilder">GetProceduresBuilder</see>
        /// </summary>
        public GetProceduresBuilder()
        {
            Reset();
        }

        /// <summary>
        /// Build a class of type <see cref="GetProcedures">GetProcedures</see> with all the defined values
        /// </summary>
        /// <returns>
        /// Returns a <see cref="GetProcedures">GetProcedures</see> class
        /// </returns>
        public GetProcedures Build()
        {
            return new GetProcedures
            {
                CompanyId = _companyId,
                Name = _name,
                Page = _page,
                PageSize = _pageSize,
            };
        }

        /// <summary>
        /// Reset all properties' to the default value
        /// </summary>
        /// <returns>
        /// Returns the <see cref="GetProceduresBuilder">GetProceduresBuilder</see> with the
        /// properties reseted
        /// </returns>
        public GetProceduresBuilder Reset()
        {
            _companyId = default;
            _name = default;
            _page = default;
            _pageSize = default;

            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int" /> for the property <paramref name="companyId">companyId</paramref>
        /// </summary>
        /// <param name="companyId">
        /// A value of type <typeparamref name="int?" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetProceduresBuilder">GetProceduresBuilder</see> with the
        /// property <paramref name="companyId">companyId</paramref> defined
        /// </returns>
        public GetProceduresBuilder WithCompanyId(int companyId)
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
        /// Returns the <see cref="GetProceduresBuilder">GetProceduresBuilder</see> with the
        /// property <paramref name="name">name</paramref> defined
        /// </returns>
        public GetProceduresBuilder WithName(string name)
        {
            _name = name;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int" /> for the property <paramref name="page">page</paramref>
        /// </summary>
        /// <param name="page">
        /// A value of type <typeparamref name="int?" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetProceduresBuilder">GetProceduresBuilder</see> with the
        /// property <paramref name="page">page</paramref> defined
        /// </returns>
        public GetProceduresBuilder WithPage(int page)
        {
            _page = page;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int" /> for the property <paramref name="pageSize">pageSize</paramref>
        /// </summary>
        /// <param name="pageSize">
        /// A value of type <typeparamref name="int?" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetProceduresBuilder">GetProceduresBuilder</see> with the
        /// property <paramref name="pageSize">pageSize</paramref> defined
        /// </returns>
        public GetProceduresBuilder WithPageSize(int pageSize)
        {
            _pageSize = pageSize;
            return this;
        }
    }
}