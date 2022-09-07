namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Builder for the class <see cref="GetAssetLayout">GetAssetLayout</see>
    /// </summary>
    public class GetAssetLayoutBuilder
    {
        private int _id;

        /// <summary>
        /// Create a new instance for the <see cref="GetAssetLayoutBuilder">GetAssetLayoutBuilder</see>
        /// </summary>
        public GetAssetLayoutBuilder()
        {
            Reset();
        }

        /// <summary>
        /// Build a class of type <see cref="GetAssetLayout">GetAssetLayout</see> with all the
        /// defined values
        /// </summary>
        /// <returns>
        /// Returns a <see cref="GetAssetLayout">GetAssetLayout</see> class
        /// </returns>
        public GetAssetLayout Build()
        {
            return new GetAssetLayout(_id);
        }

        /// <summary>
        /// Reset all properties' to the default value
        /// </summary>
        /// <returns>
        /// Returns the <see cref="GetAssetLayoutBuilder">GetAssetLayoutBuilder</see> with the
        /// properties reseted
        /// </returns>
        public GetAssetLayoutBuilder Reset()
        {
            _id = default;

            return this;
        }

        /// <summary>
        /// Set a value of type <see cref="int">int</see> for the property <paramref name="id">id</paramref>
        /// </summary>
        /// <param name="id">
        /// A value of type <see cref="int">int</see> that will be defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetAssetLayoutBuilder">GetAssetLayoutBuilder</see> with the
        /// property <paramref name="id">id</paramref> defined
        /// </returns>
        public GetAssetLayoutBuilder WithID(int id)
        {
            this._id = id;
            return this;
        }
    }
}