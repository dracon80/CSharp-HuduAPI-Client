using HuduAPI.Endpoints.Parameters.AbstractBases;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Builder for the class <see cref="CreateFolder">CreateFolder</see>
    /// </summary>
    public class CreateFolderBuilder : FolderBuilder<CreateFolder, CreateFolderBuilder>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFolderBuilder" /> class with the
        /// required properties to call the hudu endpoint api/v1/folders.
        /// </summary>
        /// <param name="name">
        /// The name of the new company to create.
        /// </param>
        public CreateFolderBuilder(string name) : base(name)
        {
        }

        /// <summary>
        /// Builds a new instance of type <see cref="CreateFolder" />.
        /// </summary>
        /// <returns>
        /// </returns>
        public override CreateFolder Build()
        {
            return new CreateFolder(_name)
            {
                CompanyId = _companyId,
                Description = _description,
                Icon = _icon,
                ParentFolderId = _parentFolderId
            };
        }
    }
}