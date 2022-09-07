namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Builder for the class <see cref="GetAssetLayouts">GetAssetLayouts</see>
    /// </summary>
    public class GetAssetLayoutsBuilder
    {
        private string? _name;
        private int? _page;

        /// <summary>
        /// Create a new instance for the <see cref="GetAssetLayoutsBuilder">GetAssetLayoutsBuilder</see>
        /// </summary>
        public GetAssetLayoutsBuilder()
        {
            Reset();
        }

        /// <summary>
        /// Build a class of type <see cref="GetAssetLayouts">GetAssetLayouts</see> with all the
        /// defined values
        /// </summary>
        /// <returns>
        /// Returns a <see cref="GetAssetLayouts">GetAssetLayouts</see> class
        /// </returns>
        public GetAssetLayouts Build()
        {
            return new GetAssetLayouts(_name, _page);
        }

        /// <summary>
        /// Reset all properties' to the default value
        /// </summary>
        /// <returns>
        /// Returns the <see cref="GetAssetLayoutsBuilder">GetAssetLayoutsBuilder</see> with the
        /// properties reseted
        /// </returns>
        public GetAssetLayoutsBuilder Reset()
        {
            _name = null;
            _page = null;

            return this;
        }

        /// <summary>
        /// Set a value of type <see cref="string">string</see> for the property <paramref name="name">name</paramref>
        /// </summary>
        /// <param name="name">
        /// A value of type <see cref="string">string</see> that will be defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetAssetLayoutsBuilder">GetAssetLayoutsBuilder</see> with the
        /// property <paramref name="name">name</paramref> defined
        /// </returns>
        public GetAssetLayoutsBuilder WithName(string name)
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
        /// Returns the <see cref="GetAssetLayoutsBuilder">GetAssetLayoutsBuilder</see> with the
        /// property <paramref name="page">page</paramref> defined
        /// </returns>
        public GetAssetLayoutsBuilder WithPage(int? page)
        {
            this._page = page;
            return this;
        }
    }
}