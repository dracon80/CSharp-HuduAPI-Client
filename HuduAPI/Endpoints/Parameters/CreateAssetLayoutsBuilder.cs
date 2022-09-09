namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Builder for the class <see cref="CreateAssetLayouts">CreateAssetLayouts</see>
    /// </summary>
    public class CreateAssetLayoutsBuilder
    {
        private string _color;
        private List<CreateAssetLayoutField> _fields;
        private string _icon;
        private string _iconColor;
        private bool _includeComments;
        private bool _includeFiles;
        private bool _includePasswords;
        private bool _includePhotos;
        private string _name;
        private string? _passwordTypes;

        /// <summary>
        /// Create a new instance for the <see cref="CreateAssetLayoutsBuilder">CreateAssetLayoutsBuilder</see>
        /// </summary>
        public CreateAssetLayoutsBuilder(string name, string icon, string color, string iconColor, List<CreateAssetLayoutField> assetLayoutFields)
        {
            _name = name;
            _icon = icon;
            _color = color;
            _iconColor = iconColor;
            _includePasswords = true;
            _includePhotos = true;
            _includeComments = true;
            _includeFiles = true;
            _passwordTypes = default;
            _fields = assetLayoutFields;
        }

        /// <summary>
        /// Build a class of type <see cref="CreateAssetLayouts">CreateAssetLayouts</see> with all
        /// the defined values
        /// </summary>
        /// <returns>
        /// Returns a <see cref="CreateAssetLayouts">CreateAssetLayouts</see> class
        /// </returns>
        public CreateAssetLayouts Build()
        {
            return new CreateAssetLayouts(_name, _icon, _color, _iconColor, _fields)
            {
                IncludePasswords = _includePasswords,
                IncludeComments = _includeComments,
                IncludeFiles = _includeFiles,
                IncludePhotos = _includePhotos,
                PasswordTypes = _passwordTypes
            };
        }

        /// <summary>
        /// An item of type <typeparamref name="CreateAssetLayoutField" /> will be added to the
        /// collection <c>AssetLayoutFields</c>
        /// </summary>
        /// <param name="item">
        /// A value of type <typeparamref name="CreateAssetLayoutField" /> will the added to the collection
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateAssetLayoutsBuilder">CreateAssetLayoutsBuilder</see> with
        /// the collection <c>AssetLayoutFields</c> with one more item
        /// </returns>
        public CreateAssetLayoutsBuilder WithAssetLayoutFieldsItem(CreateAssetLayoutField item)
        {
            _fields.Add(item);
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="color">color</paramref>
        /// </summary>
        /// <param name="color">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateAssetLayoutsBuilder">CreateAssetLayoutsBuilder</see> with
        /// the property <paramref name="color">color</paramref> defined
        /// </returns>
        public CreateAssetLayoutsBuilder WithColor(string color)
        {
            _color = color;
            return this;
        }

        /// <summary> Set a value of type <typeparamref name="List<CreateAssetLayoutField>"/> for
        /// the property <paramref name="fields">fields</paramref> </summary> <param name="fields">A
        /// value of type <typeparamref name="List<CreateAssetLayoutField>"/> will the defined for
        /// the property</param> <returns>Returns the <see
        /// cref="CreateAssetLayoutsBuilder">CreateAssetLayoutsBuilder</see> with the property
        /// <paramref name="fields">fields</paramref> defined</returns>
        public CreateAssetLayoutsBuilder WithFields(List<CreateAssetLayoutField> fields)
        {
            _fields = fields;
            return this;
        }

        /// <summary>
        /// An item of type <typeparamref name="CreateAssetLayoutField" /> will be added to the
        /// collection <c>Fields</c>
        /// </summary>
        /// <param name="item">
        /// A value of type <typeparamref name="CreateAssetLayoutField" /> will the added to the collection
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateAssetLayoutsBuilder">CreateAssetLayoutsBuilder</see> with
        /// the collection <c>Fields</c> with one more item
        /// </returns>
        public CreateAssetLayoutsBuilder WithFieldsItem(CreateAssetLayoutField item)
        {
            _fields.Add(item);
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="icon">icon</paramref>
        /// </summary>
        /// <param name="icon">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateAssetLayoutsBuilder">CreateAssetLayoutsBuilder</see> with
        /// the property <paramref name="icon">icon</paramref> defined
        /// </returns>
        public CreateAssetLayoutsBuilder WithIcon(string icon)
        {
            _icon = icon;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="iconColor">iconColor</paramref>
        /// </summary>
        /// <param name="iconColor">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateAssetLayoutsBuilder">CreateAssetLayoutsBuilder</see> with
        /// the property <paramref name="iconColor">iconColor</paramref> defined
        /// </returns>
        public CreateAssetLayoutsBuilder WithIconColor(string iconColor)
        {
            _iconColor = iconColor;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="bool" /> for the property <paramref name="includeComments">includeComments</paramref>
        /// </summary>
        /// <param name="includeComments">
        /// A value of type <typeparamref name="bool" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateAssetLayoutsBuilder">CreateAssetLayoutsBuilder</see> with
        /// the property <paramref name="includeComments">includeComments</paramref> defined
        /// </returns>
        public CreateAssetLayoutsBuilder WithIncludeComments(bool includeComments)
        {
            _includeComments = includeComments;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="bool" /> for the property <paramref name="includeFiles">includeFiles</paramref>
        /// </summary>
        /// <param name="includeFiles">
        /// A value of type <typeparamref name="bool" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateAssetLayoutsBuilder">CreateAssetLayoutsBuilder</see> with
        /// the property <paramref name="includeFiles">includeFiles</paramref> defined
        /// </returns>
        public CreateAssetLayoutsBuilder WithIncludeFiles(bool includeFiles)
        {
            _includeFiles = includeFiles;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="bool" /> for the property <paramref name="includePasswords">includePasswords</paramref>
        /// </summary>
        /// <param name="includePasswords">
        /// A value of type <typeparamref name="bool" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateAssetLayoutsBuilder">CreateAssetLayoutsBuilder</see> with
        /// the property <paramref name="includePasswords">includePasswords</paramref> defined
        /// </returns>
        public CreateAssetLayoutsBuilder WithIncludePasswords(bool includePasswords)
        {
            _includePasswords = includePasswords;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="bool" /> for the property <paramref name="includePhotos">includePhotos</paramref>
        /// </summary>
        /// <param name="includePhotos">
        /// A value of type <typeparamref name="bool" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateAssetLayoutsBuilder">CreateAssetLayoutsBuilder</see> with
        /// the property <paramref name="includePhotos">includePhotos</paramref> defined
        /// </returns>
        public CreateAssetLayoutsBuilder WithIncludePhotos(bool includePhotos)
        {
            _includePhotos = includePhotos;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="name">name</paramref>
        /// </summary>
        /// <param name="name">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateAssetLayoutsBuilder">CreateAssetLayoutsBuilder</see> with
        /// the property <paramref name="name">name</paramref> defined
        /// </returns>
        public CreateAssetLayoutsBuilder WithName(string name)
        {
            _name = name;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="passwordTypes">passwordTypes</paramref>
        /// </summary>
        /// <param name="passwordTypes">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateAssetLayoutsBuilder">CreateAssetLayoutsBuilder</see> with
        /// the property <paramref name="passwordTypes">passwordTypes</paramref> defined
        /// </returns>
        public CreateAssetLayoutsBuilder WithPasswordTypes(string passwordTypes)
        {
            _passwordTypes = passwordTypes;
            return this;
        }
    }
}