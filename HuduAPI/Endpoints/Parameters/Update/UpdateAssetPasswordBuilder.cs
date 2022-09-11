using HuduAPI.Endpoints.Parameters.AbstractBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Builder class for <see cref="UpdateAssetPassword" />. Used to create a complete paramater object.
    /// </summary>
    public class UpdateAssetPasswordBuilder : AssetPasswordBuilder<UpdateAssetPassword, UpdateAssetPasswordBuilder>
    {
        private int _id;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssetPasswordBuilder" /> class.
        /// </summary>
        /// <param name="id">
        /// The identifier.
        /// </param>
        /// <param name="companyId">
        /// The company identifier.
        /// </param>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="password">
        /// The password.
        /// </param>
        public UpdateAssetPasswordBuilder(int id, int companyId, string name, string password) : base(companyId, name, password)
        {
            _id = id;
        }

        /// <summary>
        /// Build a class of type <see cref="CreateAssetPassword">CreateAssetPassword</see> with all
        /// the defined values
        /// </summary>
        /// <returns>
        /// Returns a <see cref="CreateAssetPassword">CreateAssetPassword</see> class
        /// </returns>
        public override UpdateAssetPassword Build()
        {
            return new UpdateAssetPassword(_id, _companyId, _name, _password)
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