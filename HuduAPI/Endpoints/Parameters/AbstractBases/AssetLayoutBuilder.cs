using System.Drawing;

namespace HuduAPI.Endpoints.Parameters.AbstractBases
{
    /// <summary>
    /// An abstract builder to help build Article parameters for implementing classes.
    /// </summary>
    /// <typeparam name="TResult">
    /// The type of the paramater to build.
    /// </typeparam>
    /// <typeparam name="TBuilder">
    /// The type of the builder that is inherting this base class.
    /// </typeparam>
    public abstract class AssetLayoutBuilder<TResult, TBuilder>
        where TResult : AssetLayout
        where TBuilder : AssetLayoutBuilder<TResult, TBuilder>
    {
        /// <summary>
        /// Gets the builder instance of the implmenting class type.
        /// </summary>
        private readonly TBuilder _builderInstance = null;

        protected Color _color;
        protected List<AssetLayoutField> _fields;
        protected string _icon;
        protected Color _iconColor;
        protected bool _includeComments;
        protected bool _includeFiles;
        protected bool _includePasswords;
        protected bool _includePhotos;
        protected string _name;
        protected string? _passwordTypes;

        /// <summary>
        /// Abstract class with shared methods for building asset_layout parameters
        /// </summary>
        /// <param name="name">
        /// The name of the asset_layout.
        /// </param>
        /// <param name="icon">
        /// The icon to be used in the gui.
        /// </param>
        /// <param name="color">
        /// The color of the icon foreground.
        /// </param>
        /// <param name="iconColor">
        /// Color of the icon background.
        /// </param>
        /// <param name="assetLayoutFields">
        /// A list of asset layout fields that define the layout.
        /// </param>
        internal AssetLayoutBuilder(string name, string icon, Color color, Color iconColor, List<AssetLayoutField> assetLayoutFields)
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

            _builderInstance = (TBuilder)this;
        }

        /// <summary>
        /// Build a class of type <typeparamref name="TResult" /> with all the defined values
        /// </summary>
        /// <returns>
        /// Returns a <typeparamref name="TResult" /> class
        /// </returns>
        public abstract TResult Build();

        /// <summary>
        /// Adds a new AssetLayoutField to the AssetLayoutFields List that is to be associated with
        /// the asset_layout
        /// </summary>
        /// <param name="item">
        /// A single asset_layout field
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithAssetLayoutFieldsItem(AssetLayoutField item)
        {
            _fields.Add(item);
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for the color of the icon background
        /// </summary>
        /// <param name="color">
        /// The color.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithColor(Color color)
        {
            _color = color;
            return _builderInstance;
        }

        /// <summary>
        /// Set a list of AssetLayoutFields to be associated with the asset_layout
        /// </summary>
        /// <param name="fields">
        /// A List of fields.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithFields(List<AssetLayoutField> fields)
        {
            _fields = fields;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for icon to be associated with the asset_layout
        /// </summary>
        /// <param name="icon">
        /// The icon.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithIcon(string icon)
        {
            _icon = icon;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for iconColor
        /// </summary>
        /// <param name="iconColor">
        /// Color of the icon.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithIconColor(Color iconColor)
        {
            _iconColor = iconColor;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for includeComments
        /// </summary>
        /// <param name="includeComments">
        /// if set to <c>true</c> [include comments].
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithIncludeComments(bool includeComments)
        {
            _includeComments = includeComments;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for includeFiles
        /// </summary>
        /// <param name="includeFiles">
        /// if set to <c>true</c> [include files].
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithIncludeFiles(bool includeFiles)
        {
            _includeFiles = includeFiles;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for includePasswords
        /// </summary>
        /// <param name="includePasswords">
        /// if set to <c>true</c> [include passwords].
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithIncludePasswords(bool includePasswords)
        {
            _includePasswords = includePasswords;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for includePhotos
        /// </summary>
        /// <param name="includePhotos">
        /// if set to <c>true</c> [include photos].
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithIncludePhotos(bool includePhotos)
        {
            _includePhotos = includePhotos;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for name
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithName(string name)
        {
            _name = name;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for passwordTypes
        /// </summary>
        /// <param name="passwordTypes">
        /// The password types.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithPasswordTypes(string passwordTypes)
        {
            _passwordTypes = passwordTypes;
            return _builderInstance;
        }
    }
}