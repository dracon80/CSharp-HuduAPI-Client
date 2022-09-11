using HuduAPI.Endpoints.Parameters.AbstractBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// This is a builder class to help build a new instance of a <see cref="UpdateFolder" /> object.
    /// </summary>
    public class UpdateFolderBuilder : FolderBuilder<UpdateFolder, UpdateFolderBuilder>
    {
        private readonly int _id;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFolderBuilder" /> class.
        /// </summary>
        /// <param name="id">
        /// The identifier.
        /// </param>
        /// <param name="name">
        /// The name.
        /// </param>
        public UpdateFolderBuilder(int id, string name) : base(name)
        {
            _id = id;
        }

        /// <summary>
        /// Builds a new instance of type <see cref="UpdateFolder" /> with all the required
        /// properties to call the endpoint api/v1/folders.
        /// </summary>
        /// <returns>
        /// An instance of type <see cref="UpdateFolder" />
        /// </returns>
        public override UpdateFolder Build()
        {
            return new UpdateFolder(_id, _name)
            {
                CompanyId = _companyId,
                Description = _description,
                Icon = _icon,
                ParentFolderId = _parentFolderId
            };
        }
    }
}