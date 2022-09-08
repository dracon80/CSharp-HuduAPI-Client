namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Builder for the class <see cref="GetAssetPassword">GetAssetPassword</see>
    /// </summary>
    public class GetAssetPasswordBuilder
    {
        private int _id;

        /// <summary>
        /// Create a new instance for the <see cref="GetAssetPasswordBuilder">GetAssetPasswordBuilder</see>
        /// </summary>
        public GetAssetPasswordBuilder()
        {
            Reset();
        }

        /// <summary>
        /// Build a class of type <see cref="GetAssetPassword">GetAssetPassword</see> with all the
        /// defined values
        /// </summary>
        /// <returns>
        /// Returns a <see cref="GetAssetPassword">GetAssetPassword</see> class
        /// </returns>
        public GetAssetPassword Build()
        {
            return new GetAssetPassword(_id);
        }

        /// <summary>
        /// Reset all properties' to the default value
        /// </summary>
        /// <returns>
        /// Returns the <see cref="GetAssetPasswordBuilder">GetAssetPasswordBuilder</see> with the
        /// properties reseted
        /// </returns>
        public GetAssetPasswordBuilder Reset()
        {
            _id = default;

            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int" /> for the property <paramref name="id">id</paramref>
        /// </summary>
        /// <param name="id">
        /// A value of type <typeparamref name="int" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetAssetPasswordBuilder">GetAssetPasswordBuilder</see> with the
        /// property <paramref name="id">id</paramref> defined
        /// </returns>
        public GetAssetPasswordBuilder WithId(int id)
        {
            _id = id;
            return this;
        }
    }
}