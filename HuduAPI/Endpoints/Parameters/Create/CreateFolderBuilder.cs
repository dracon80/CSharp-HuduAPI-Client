namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Builder for the class <see cref="CreateFolder">CreateFolder</see>
    /// </summary>
    public class CreateFolderBuilder
    {
        private int? _companyId;
        private string? _description;
        private string? _icon;
        private string _name;
        private int? _parentFolderId;

        /// <summary>
        /// Create a new instance for the <see cref="CreateFolderBuilder">CreateFolderBuilder</see>
        /// </summary>
        public CreateFolderBuilder(string name)
        {
            _companyId = default;
            _description = default;
            _icon = default;
            _name = name;
            _parentFolderId = default;
        }

        /// <summary>
        /// Build a class of type <see cref="CreateFolder">CreateFolder</see> with all the defined values
        /// </summary>
        /// <returns>
        /// Returns a <see cref="CreateFolder">CreateFolder</see> class
        /// </returns>
        public CreateFolder Build()
        {
            return new CreateFolder(_name)
            {
                CompanyId = _companyId,
                Description = _description,
                Icon = _icon,
                ParentFolderId = _parentFolderId
            };
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int?" /> for the property <paramref name="companyId">companyId</paramref>
        /// </summary>
        /// <param name="companyId">
        /// A value of type <typeparamref name="int?" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateFolderBuilder">CreateFolderBuilder</see> with the property
        /// <paramref name="companyId">companyId</paramref> defined
        /// </returns>
        public CreateFolderBuilder WithCompanyId(int companyId)
        {
            _companyId = companyId;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="description">description</paramref>
        /// </summary>
        /// <param name="description">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateFolderBuilder">CreateFolderBuilder</see> with the property
        /// <paramref name="description">description</paramref> defined
        /// </returns>
        public CreateFolderBuilder WithDescription(string description)
        {
            _description = description;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="icon">icon</paramref>
        /// </summary>
        /// <param name="icon">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateFolderBuilder">CreateFolderBuilder</see> with the property
        /// <paramref name="icon">icon</paramref> defined
        /// </returns>
        public CreateFolderBuilder WithIcon(string icon)
        {
            _icon = icon;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="name">name</paramref>
        /// </summary>
        /// <param name="name">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateFolderBuilder">CreateFolderBuilder</see> with the property
        /// <paramref name="name">name</paramref> defined
        /// </returns>
        public CreateFolderBuilder WithName(string name)
        {
            _name = name;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int?" /> for the property <paramref name="parentFolderId">parentFolderId</paramref>
        /// </summary>
        /// <param name="parentFolderId">
        /// A value of type <typeparamref name="int?" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateFolderBuilder">CreateFolderBuilder</see> with the property
        /// <paramref name="parentFolderId">parentFolderId</paramref> defined
        /// </returns>
        public CreateFolderBuilder WithParentFolderId(int parentFolderId)
        {
            _parentFolderId = parentFolderId;
            return this;
        }
    }
}