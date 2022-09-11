namespace HuduAPI.Endpoints.Parameters.AbstractBases
{
    /// <summary>
    /// Builder for the class <see cref="Folder">CreateFolder</see>
    /// </summary>
    public abstract class FolderBuilder<TResult, TBuilder>
        where TResult : Folder
        where TBuilder : FolderBuilder<TResult, TBuilder>
    {
        protected int? _companyId;
        protected string? _description;
        protected string? _icon;
        protected string _name;
        protected int? _parentFolderId;

        /// <summary>
        /// Gets the builder instance of the implmenting class type.
        /// </summary>
        private readonly TBuilder _builderInstance = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderBuilder{TResult, TBuilder}" /> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        internal FolderBuilder(string name)
        {
            _companyId = default;
            _description = default;
            _icon = default;
            _name = name;
            _parentFolderId = default;

            _builderInstance = (TBuilder)this;
        }

        /// <summary>
        /// Builds a new instance of type <typeparamref name="TResult" />.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract TResult Build();

        /// <summary>
        /// Set a value for companyId
        /// </summary>
        /// <param name="companyId">
        /// The company identifier.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithCompanyId(int companyId)
        {
            _companyId = companyId;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for description
        /// </summary>
        /// <param name="description">
        /// The description.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithDescription(string description)
        {
            _description = description;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for icon
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
        /// Set a value for parentFolderId
        /// </summary>
        /// <param name="parentFolderId">
        /// The parent folder identifier.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithParentFolderId(int parentFolderId)
        {
            _parentFolderId = parentFolderId;
            return _builderInstance;
        }
    }
}