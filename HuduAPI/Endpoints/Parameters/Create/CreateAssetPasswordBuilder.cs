using HuduAPI.Endpoints.Parameters.AbstractBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Builder for the class <see cref="CreateAssetPassword">CreateAssetPassword</see>
    /// </summary>
    public class CreateAssetPasswordBuilder : AssetPasswordBuilder<CreateAssetPassword, CreateAssetPasswordBuilder>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetPasswordBuilder" /> class with
        /// all requred parameters to call the create endpoint api/v1/asset_passwords
        /// </summary>
        /// <param name="companyId">
        /// The Company to associate the password with
        /// </param>
        /// <param name="name">
        /// The name to give to the password
        /// </param>
        /// <param name="password">
        /// The plaintext value of the password
        /// </param>
        public CreateAssetPasswordBuilder(int companyId, string name, string password) : base(companyId, name, password)
        {
        }

        /// <summary>
        /// Build a class of type <see cref="CreateAssetPassword">CreateAssetPassword</see> with all
        /// the defined values
        /// </summary>
        /// <returns>
        /// Returns a <see cref="CreateAssetPassword">CreateAssetPassword</see> class
        /// </returns>
        public override CreateAssetPassword Build()
        {
            return new CreateAssetPassword(_companyId, _name, _password)
            {
                PasswordableType = _passwordableType,
                PasswordableId = _passwordableId,
                InPortal = _inPortal,
                OtpSecret = _otpSecret,
                Url = _url,
                Username = _username,
                Description = _description,
                PasswordType = _passwordType,
                PasswordFolderId = _passwordFolderId
            };
        }
    }
}