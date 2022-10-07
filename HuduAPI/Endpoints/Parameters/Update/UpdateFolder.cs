using HuduAPI.Endpoints.Parameters.AbstractBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Provides all the properties required to update an existing Folder in hudu using the endpoint api/v1/folders
    /// </summary>
    /// <seealso cref="HuduAPI.Endpoints.Parameters.AbstractBases.Folder" />
    public class UpdateFolder : Folder, IParameters
    {
        /// <summary>
        /// Gets the identifier for this folder.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFolder" /> class with all the
        /// required properties to update and existing folder using the endpoint api/v1/folders.
        /// </summary>
        /// <param name="id">
        /// The identifier of the folder.
        /// </param>
        /// <param name="name">
        /// The name that folder will be given.
        /// </param>
        public UpdateFolder(int id, string name) : base(name)
        {
            this.Id = id;
        }

        public string PayloadType
        {
            get
            {
                return "folder";
            }
        }
    }
}