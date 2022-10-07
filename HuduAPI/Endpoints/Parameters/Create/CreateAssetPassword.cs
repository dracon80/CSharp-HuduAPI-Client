using HuduAPI.Endpoints.Parameters.AbstractBases;
using Newtonsoft.Json;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Provides all the properties that define a new asset_password to be created in hudu using the
    /// endpoint api/v1/asset_passwords
    /// </summary>
    public class CreateAssetPassword : AssetPassword, IParameters
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetPassword" /> class.
        /// </summary>
        /// <param name="companyId">
        /// The company identifier to associate the password with.
        /// </param>
        /// <param name="name">
        /// The name of the password.
        /// </param>
        /// <param name="password">
        /// The password value in plain text.
        /// </param>
        public CreateAssetPassword(int companyId, string name, string password) : base(companyId, name, password)
        {
        }

        public string PayloadType
        {
            get
            {
                return "asset_password";
            }
        }
    }
}