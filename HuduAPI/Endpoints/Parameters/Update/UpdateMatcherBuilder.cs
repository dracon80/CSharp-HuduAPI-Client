namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Builder for the class <see cref="UpdateMatcher">UpdateMatcher</see>
    /// </summary>
    public class UpdateMatcherBuilder
    {
        private int _companyId;
        private string _identifier;
        private int _matcher_id;
        private int _potentialCompanyId;
        private string _syncId;

        /// <summary>
        /// Create a new instance for the <see cref="UpdateMatcherBuilder">UpdateMatcherBuilder</see>
        /// </summary>
        public UpdateMatcherBuilder(int matcherId)
        {
            Reset();
            _matcher_id = matcherId;
        }

        /// <summary>
        /// Build a class of type <see cref="UpdateMatcher">UpdateMatcher</see> with all the defined values
        /// </summary>
        /// <returns>Returns a <see cref="UpdateMatcher">UpdateMatcher</see> class</returns>
        public UpdateMatcher Build()
        {
            return new UpdateMatcher(_matcher_id)
            {
                CompanyId = _companyId,
                Identifier = _identifier,
                PotentialCompanyId = _potentialCompanyId,
                SyncId = _syncId,
            };
        }

        /// <summary>
        /// Reset all properties' to the default value
        /// </summary>
        /// <returns>
        /// Returns the <see cref="UpdateMatcherBuilder">UpdateMatcherBuilder</see> with the
        /// properties reseted
        /// </returns>
        public UpdateMatcherBuilder Reset()
        {
            _companyId = default;
            _identifier = default;
            _potentialCompanyId = default;
            _syncId = default;

            return this;
        }

        /// <summary>
        /// Gets or sets the hudu company id to make a match for.
        /// </summary>
        /// <param name="companyId">The company identifier.</param>
        /// <returns>A generic Builder Object for type <typeparamref name="TBuilder"/></returns>
        public UpdateMatcherBuilder WithCompanyId(int companyId)
        {
            _companyId = companyId;
            return this;
        }

        /// <summary>
        /// Gets the identifier for this matcher.
        /// </summary>
        /// <param name="identifier">The identifier.</param>
        /// <returns>A generic Builder Object for type <typeparamref name="TBuilder"/></returns>
        public UpdateMatcherBuilder Withidentifier(string identifier)
        {
            _identifier = identifier;
            return this;
        }

        /// <summary>
        /// The suggested hudu company that hudu thinks would match
        /// </summary>
        /// <param name="potentialCompanyId">The potential company identifier.</param>
        /// <returns>A generic Builder Object for type <typeparamref name="TBuilder"/></returns>
        public UpdateMatcherBuilder WithPotentialCompanyId(int potentialCompanyId)
        {
            _potentialCompanyId = potentialCompanyId;
            return this;
        }

        /// <summary>
        /// This seems to be the company Identifier in the source data. e.g. Connectwise company ID.
        /// </summary>
        /// <param name="syncId">The synchronize identifier.</param>
        /// <returns>A generic Builder Object for type <typeparamref name="TBuilder"/></returns>
        public UpdateMatcherBuilder WithsyncId(string syncId)
        {
            _syncId = syncId;
            return this;
        }
    }
}