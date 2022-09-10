namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Builder for the class <see cref="CreateRelation">CreateRelation</see>
    /// </summary>
    public class CreateRelationBuilder
    {
        private string? _description;
        private int _fromableId;
        private string _fromableType;
        private bool _isInverse;
        private int _toableId;
        private string _toableType;

        /// <summary>
        /// Create a new instance for the <see cref="CreateRelationBuilder">CreateRelationBuilder</see>
        /// </summary>
        /// <param name="toableType">
        /// The type of the TO relation.
        /// </param>
        /// <param name="toableId">
        /// The ID of the TO relation.
        /// </param>
        /// <param name="fromableType">
        /// The type of the FROM relation.
        /// </param>
        /// <param name="fromableId">
        /// The ID of the FROM relation.
        /// </param>
        public CreateRelationBuilder(string toableType, int toableId, string fromableType, int fromableId)
        {
            _description = default;
            _fromableId = fromableId;
            _fromableType = fromableType;
            _isInverse = false;
            _toableId = toableId;
            _toableType = toableType;
        }

        /// <summary>
        /// Build a class of type <see cref="CreateRelation">CreateRelation</see> with all the
        /// defined values
        /// </summary>
        /// <returns>
        /// Returns a <see cref="CreateRelation">CreateRelation</see> class
        /// </returns>
        public CreateRelation Build()
        {
            return new CreateRelation(_toableType, _toableId, _fromableType, _fromableId)
            {
                IsInverse = _isInverse,
                Description = _description
            };
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="description">description</paramref>
        /// </summary>
        /// <param name="description">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateRelationBuilder">CreateRelationBuilder</see> with the
        /// property <paramref name="description">description</paramref> defined
        /// </returns>
        public CreateRelationBuilder WithDescription(string description)
        {
            _description = description;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="bool" /> for the property <paramref name="isInverse">isInverse</paramref>
        /// </summary>
        /// <param name="isInverse">
        /// A value of type <typeparamref name="bool" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateRelationBuilder">CreateRelationBuilder</see> with the
        /// property <paramref name="isInverse">isInverse</paramref> defined
        /// </returns>
        public CreateRelationBuilder WithIsInverse(bool isInverse)
        {
            _isInverse = isInverse;
            return this;
        }
    }
}