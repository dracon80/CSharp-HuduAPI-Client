namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Builder for the class <see cref="GetAssets">GetAssets</see>
    /// </summary>
    public class GetAssetsBuilder
    {
        private Boolean _archived = false;
        private int? _assetLayoutId;
        private int? _companyId;
        private int? _id;
        private string? _name;
        private int? _page;
        private int? _pageSize;
        private string? _primarySerial;

        /// <summary>
        /// Create a new instance for the <see cref="GetAssetsBuilder">GetAssetsBuilder</see>
        /// </summary>
        public GetAssetsBuilder()
        {
            Reset();
        }

        /// <summary>
        /// Build a class of type <see cref="GetAssets">GetAssets</see> with all the defined values
        /// </summary>
        /// <returns>
        /// Returns a <see cref="GetAssets">GetAssets</see> class
        /// </returns>
        public GetAssets Build()
        {
            return new GetAssets(_companyId, _id, _name, _primarySerial, _assetLayoutId, _page, _archived, _pageSize);
        }

        /// <summary>
        /// Reset all properties' to the default value
        /// </summary>
        /// <returns>
        /// Returns the <see cref="GetAssetsBuilder">GetAssetsBuilder</see> with the properties reseted
        /// </returns>
        public GetAssetsBuilder Reset()
        {
            _archived = false;
            _assetLayoutId = default;
            _companyId = default;
            _id = default;
            _name = default;
            _page = default;
            _pageSize = default;
            _primarySerial = default;
            _companyId = default;
            _id = default;
            _assetLayoutId = default;
            _page = default;
            _pageSize = default;

            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="bool" /> for the property <paramref name="archived">archived</paramref>
        /// </summary>
        /// <param name="archived">
        /// A value of type <typeparamref name="bool" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetAssetsBuilder">GetAssetsBuilder</see> with the property
        /// <paramref name="archived">archived</paramref> defined
        /// </returns>
        public GetAssetsBuilder WithArchived(bool archived)
        {
            _archived = archived;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int?" /> for the property <paramref name="assetLayoutId">assetLayoutId</paramref>
        /// </summary>
        /// <param name="assetLayoutId">
        /// A value of type <typeparamref name="int?" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetAssetsBuilder">GetAssetsBuilder</see> with the property
        /// <paramref name="assetLayoutId">assetLayoutId</paramref> defined
        /// </returns>
        public GetAssetsBuilder WithAssetLayoutId(int assetLayoutId)
        {
            _assetLayoutId = assetLayoutId;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int?" /> for the property <paramref name="companyId">companyId</paramref>
        /// </summary>
        /// <param name="companyId">
        /// A value of type <typeparamref name="int?" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetAssetsBuilder">GetAssetsBuilder</see> with the property
        /// <paramref name="companyId">companyId</paramref> defined
        /// </returns>
        public GetAssetsBuilder WithCompanyId(int companyId)
        {
            _companyId = companyId;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int?" /> for the property <paramref name="id">id</paramref>
        /// </summary>
        /// <param name="id">
        /// A value of type <typeparamref name="int?" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetAssetsBuilder">GetAssetsBuilder</see> with the property
        /// <paramref name="id">id</paramref> defined
        /// </returns>
        public GetAssetsBuilder WithId(int id)
        {
            _id = id;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="name">name</paramref>
        /// </summary>
        /// <param name="name">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetAssetsBuilder">GetAssetsBuilder</see> with the property
        /// <paramref name="name">name</paramref> defined
        /// </returns>
        public GetAssetsBuilder WithName(string name)
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
        /// Returns the <see cref="GetAssetsBuilder">GetAssetsBuilder</see> with the property
        /// <paramref name="page">page</paramref> defined
        /// </returns>
        public GetAssetsBuilder WithPage(int page)
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
        /// Returns the <see cref="GetAssetsBuilder">GetAssetsBuilder</see> with the property
        /// <paramref name="pageSize">pageSize</paramref> defined
        /// </returns>
        public GetAssetsBuilder WithPageSize(int pageSize)
        {
            _pageSize = pageSize;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="primarySerial">primarySerial</paramref>
        /// </summary>
        /// <param name="primarySerial">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetAssetsBuilder">GetAssetsBuilder</see> with the property
        /// <paramref name="primarySerial">primarySerial</paramref> defined
        /// </returns>
        public GetAssetsBuilder WithPrimarySerial(string primarySerial)
        {
            _primarySerial = primarySerial;
            return this;
        }
    }
}