using HuduAPI.Endpoints.Parameters.AbstractBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Provides all properties required to update an existing asset_password using the
    /// api/v1/asset_passwords/ endpoint
    /// </summary>
    /// <seealso cref="HuduAPI.Endpoints.Parameters.AbstractBases.AssetPassword" />
    public class UpdateAssetPassword : AssetPassword, IParameters
    {
        /// <summary>
        /// Gets the identifier for the AssetPassword.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssetPassword" /> class with the
        /// minimum required properties.
        /// </summary>
        /// <param name="id">
        /// The identifier of the asset_password.
        /// </param>
        /// <param name="companyId">
        /// The company identifier to associate the password with.
        /// </param>
        /// <param name="name">
        /// The name for the password.
        /// </param>
        /// <param name="password">
        /// The password in plain text.
        /// </param>
        public UpdateAssetPassword(int id, int companyId, string name, string password) : base(companyId, name, password)
        {
            this.Id = id;
        }
    }
}