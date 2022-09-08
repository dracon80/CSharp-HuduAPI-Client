using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Get a single AssetPassword from the Hudu API endpoint api/v1/asset_passwords
    /// </summary>
    public class GetAssetPassword : BaseGet, IParameters
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetPassword" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the Asset Password
        /// </param>
        public GetAssetPassword(int id) : base(id)
        {
        }
    }
}