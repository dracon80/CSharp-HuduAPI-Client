using HuduAPI.Endpoints.Parameters.AbstractBases;
using Newtonsoft.Json;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Provides all the properties needed to create a new folder using the hudu endpoint api/v1/folders
    /// </summary>
    public class CreateFolder : Folder, IParameters
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFolder" /> class with all requried properties.
        /// </summary>
        /// <param name="name">
        /// The name of the folder.
        /// </param>
        public CreateFolder(string name) : base(name)
        {
        }
    }
}