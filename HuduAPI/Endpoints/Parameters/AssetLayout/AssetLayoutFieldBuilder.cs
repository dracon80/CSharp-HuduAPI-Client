namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Builder for the class <see cref="AssetLayoutField">AssetLayoutField</see>
    /// </summary>
    public class AssetLayoutFieldBuilder
    {
        private bool _expiration;
        private AssetLayoutFieldType _fieldType;
        private string? _hint;
        private string _label;
        private int? _linkableId;
        private int? _max;
        private int? _min;
        private string? _options;
        private int _position = 0;
        private bool _required;
        private bool _showInList;

        /// <summary>
        /// Create a new instance for the <see cref="AssetLayoutFieldBuilder">AssetLayoutFieldBuilder</see>
        /// </summary>
        public AssetLayoutFieldBuilder(string label, AssetLayoutFieldType fieldType)
        {
            Reset(label, fieldType);
        }

        /// <summary>
        /// Build a class of type <see cref="AssetLayoutField">AssetLayoutField</see> with all the
        /// defined values
        /// </summary>
        /// <returns>
        /// Returns a <see cref="AssetLayoutField">AssetLayoutField</see> class
        /// </returns>
        public AssetLayoutField Build()
        {
            return new AssetLayoutField(_label, _fieldType)
            {
                Expiration = _expiration,
                Hint = _hint,
                LinkableId = _linkableId,
                Max = _max,
                Min = _min,
                Options = _options,
                Position = _position,
                Required = _required,
                ShowInList = _showInList
            };
        }

        /// <summary>
        /// Reset all properties' to the default value
        /// </summary>
        /// <returns>
        /// Returns the <see cref="AssetLayoutFieldBuilder">AssetLayoutFieldBuilder</see> with the
        /// properties reseted
        /// </returns>
        public AssetLayoutFieldBuilder Reset(string label, AssetLayoutFieldType fieldType)
        {
            _label = label;
            _min = default;
            _max = default;
            _showInList = false;
            _required = false;
            _fieldType = default;
            _hint = default;
            _options = default;
            _position = default;
            _expiration = false;
            _linkableId = default;
            _fieldType = fieldType;

            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="bool" /> for the property <paramref name="expiration">expiration</paramref>
        /// </summary>
        /// <param name="expiration">
        /// A value of type <typeparamref name="bool" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="AssetLayoutFieldBuilder">AssetLayoutFieldBuilder</see> with the
        /// property <paramref name="expiration">expiration</paramref> defined
        /// </returns>
        public AssetLayoutFieldBuilder WithExpiration(bool expiration)
        {
            _expiration = expiration;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="AssetLayoutFieldType" /> for the property
        /// <paramref name="fieldtype">fieldtype</paramref>
        /// </summary>
        /// <param name="fieldtype">
        /// A value of type <typeparamref name="AssetLayoutFieldType" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="AssetLayoutFieldBuilder">AssetLayoutFieldBuilder</see> with the
        /// property <paramref name="fieldtype">fieldtype</paramref> defined
        /// </returns>
        public AssetLayoutFieldBuilder WithFieldtype(AssetLayoutFieldType fieldtype)
        {
            _fieldType = fieldtype;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="AssetLayoutFieldType" /> for the property
        /// <paramref name="fieldType">fieldType</paramref>
        /// </summary>
        /// <param name="fieldType">
        /// A value of type <typeparamref name="AssetLayoutFieldType" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="AssetLayoutFieldBuilder">AssetLayoutFieldBuilder</see> with the
        /// property <paramref name="fieldType">fieldType</paramref> defined
        /// </returns>
        public AssetLayoutFieldBuilder WithFieldType(AssetLayoutFieldType fieldType)
        {
            _fieldType = fieldType;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="hint">hint</paramref>
        /// </summary>
        /// <param name="hint">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="AssetLayoutFieldBuilder">AssetLayoutFieldBuilder</see> with the
        /// property <paramref name="hint">hint</paramref> defined
        /// </returns>
        public AssetLayoutFieldBuilder WithHint(string hint)
        {
            _hint = hint;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="label">label</paramref>
        /// </summary>
        /// <param name="label">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="AssetLayoutFieldBuilder">AssetLayoutFieldBuilder</see> with the
        /// property <paramref name="label">label</paramref> defined
        /// </returns>
        public AssetLayoutFieldBuilder WithLabel(string label)
        {
            _label = label;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int?" /> for the property <paramref name="linkableId">linkableId</paramref>
        /// </summary>
        /// <param name="linkableId">
        /// A value of type <typeparamref name="int?" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="AssetLayoutFieldBuilder">AssetLayoutFieldBuilder</see> with the
        /// property <paramref name="linkableId">linkableId</paramref> defined
        /// </returns>
        public AssetLayoutFieldBuilder WithLinkableId(int? linkableId)
        {
            _linkableId = linkableId;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int?" /> for the property <paramref name="max">max</paramref>
        /// </summary>
        /// <param name="max">
        /// A value of type <typeparamref name="int?" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="AssetLayoutFieldBuilder">AssetLayoutFieldBuilder</see> with the
        /// property <paramref name="max">max</paramref> defined
        /// </returns>
        public AssetLayoutFieldBuilder WithMax(int? max)
        {
            _max = max;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int?" /> for the property <paramref name="min">min</paramref>
        /// </summary>
        /// <param name="min">
        /// A value of type <typeparamref name="int?" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="AssetLayoutFieldBuilder">AssetLayoutFieldBuilder</see> with the
        /// property <paramref name="min">min</paramref> defined
        /// </returns>
        public AssetLayoutFieldBuilder WithMin(int? min)
        {
            _min = min;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="options">options</paramref>
        /// </summary>
        /// <param name="options">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="AssetLayoutFieldBuilder">AssetLayoutFieldBuilder</see> with the
        /// property <paramref name="options">options</paramref> defined
        /// </returns>
        public AssetLayoutFieldBuilder WithOptions(string options)
        {
            _options = options;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int?" /> for the property <paramref name="position">position</paramref>
        /// </summary>
        /// <param name="position">
        /// A value of type <typeparamref name="int?" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="AssetLayoutFieldBuilder">AssetLayoutFieldBuilder</see> with the
        /// property <paramref name="position">position</paramref> defined
        /// </returns>
        public AssetLayoutFieldBuilder WithPosition(int position)
        {
            _position = position;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="bool" /> for the property <paramref name="required">required</paramref>
        /// </summary>
        /// <param name="required">
        /// A value of type <typeparamref name="bool" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="AssetLayoutFieldBuilder">AssetLayoutFieldBuilder</see> with the
        /// property <paramref name="required">required</paramref> defined
        /// </returns>
        public AssetLayoutFieldBuilder WithRequired(bool required)
        {
            _required = required;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="bool" /> for the property <paramref name="showInList">showInList</paramref>
        /// </summary>
        /// <param name="showInList">
        /// A value of type <typeparamref name="bool" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="AssetLayoutFieldBuilder">AssetLayoutFieldBuilder</see> with the
        /// property <paramref name="showInList">showInList</paramref> defined
        /// </returns>
        public AssetLayoutFieldBuilder WithShowInList(bool showInList)
        {
            _showInList = showInList;
            return this;
        }
    }
}