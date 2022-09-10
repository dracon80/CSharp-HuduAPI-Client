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
    public class CreateAssetPasswordBuilder
    {
        private int _companyId;
        private string? _passwordableType;
        private int? _passwordableId;
        private string _name;
        private bool _inPortal;
        private string _password;
        private string? _otpSecret;
        private string? _url;
        private string? _username;
        private string? _description;
        private string? _passwordType;
        private int? _passwordFolderId;

        /// <summary>
        /// Create a new instance for the <see cref="CreateAssetPasswordBuilder">CreateAssetPasswordBuilder</see>
        /// </summary>
        public CreateAssetPasswordBuilder(int companyId, string name, string password)
        {
            _companyId = companyId;
            _passwordableType = default;
            _passwordableId = default;
            _name = name;
            _inPortal = default;
            _password = password;
            _otpSecret = default;
            _url = default;
            _username = default;
            _description = default;
            _passwordType = default;
            _passwordFolderId = default;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="passwordableType">passwordableType</paramref>
        /// </summary>
        /// <param name="passwordableType">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateAssetPasswordBuilder">CreateAssetPasswordBuilder</see> with
        /// the property <paramref name="passwordableType">passwordableType</paramref> defined
        /// </returns>
        public CreateAssetPasswordBuilder WithPasswordableType(string passwordableType)
        {
            _passwordableType = passwordableType;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int?" /> for the property <paramref name="passwordableId">passwordableId</paramref>
        /// </summary>
        /// <param name="passwordableId">
        /// A value of type <typeparamref name="int?" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateAssetPasswordBuilder">CreateAssetPasswordBuilder</see> with
        /// the property <paramref name="passwordableId">passwordableId</paramref> defined
        /// </returns>
        public CreateAssetPasswordBuilder WithPasswordableId(int? passwordableId)
        {
            _passwordableId = passwordableId;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="bool" /> for the property <paramref name="inPortal">inPortal</paramref>
        /// </summary>
        /// <param name="inPortal">
        /// A value of type <typeparamref name="bool" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateAssetPasswordBuilder">CreateAssetPasswordBuilder</see> with
        /// the property <paramref name="inPortal">inPortal</paramref> defined
        /// </returns>
        public CreateAssetPasswordBuilder WithInPortal(bool inPortal)
        {
            _inPortal = inPortal;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="otpSecret">otpSecret</paramref>
        /// </summary>
        /// <param name="otpSecret">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateAssetPasswordBuilder">CreateAssetPasswordBuilder</see> with
        /// the property <paramref name="otpSecret">otpSecret</paramref> defined
        /// </returns>
        public CreateAssetPasswordBuilder WithOtpSecret(string otpSecret)
        {
            _otpSecret = otpSecret;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="url">url</paramref>
        /// </summary>
        /// <param name="url">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateAssetPasswordBuilder">CreateAssetPasswordBuilder</see> with
        /// the property <paramref name="url">url</paramref> defined
        /// </returns>
        public CreateAssetPasswordBuilder WithUrl(string url)
        {
            _url = url;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="username">username</paramref>
        /// </summary>
        /// <param name="username">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateAssetPasswordBuilder">CreateAssetPasswordBuilder</see> with
        /// the property <paramref name="username">username</paramref> defined
        /// </returns>
        public CreateAssetPasswordBuilder WithUsername(string username)
        {
            _username = username;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="description">description</paramref>
        /// </summary>
        /// <param name="description">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateAssetPasswordBuilder">CreateAssetPasswordBuilder</see> with
        /// the property <paramref name="description">description</paramref> defined
        /// </returns>
        public CreateAssetPasswordBuilder WithDescription(string description)
        {
            _description = description;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="passwordType">passwordType</paramref>
        /// </summary>
        /// <param name="passwordType">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateAssetPasswordBuilder">CreateAssetPasswordBuilder</see> with
        /// the property <paramref name="passwordType">passwordType</paramref> defined
        /// </returns>
        public CreateAssetPasswordBuilder WithPasswordType(string passwordType)
        {
            _passwordType = passwordType;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int?" /> for the property <paramref name="passwordFolderId">passwordFolderId</paramref>
        /// </summary>
        /// <param name="passwordFolderId">
        /// A value of type <typeparamref name="int?" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateAssetPasswordBuilder">CreateAssetPasswordBuilder</see> with
        /// the property <paramref name="passwordFolderId">passwordFolderId</paramref> defined
        /// </returns>
        public CreateAssetPasswordBuilder WithPasswordFolderId(int? passwordFolderId)
        {
            _passwordFolderId = passwordFolderId;
            return this;
        }

        /// <summary>
        /// Build a class of type <see cref="CreateAssetPassword">CreateAssetPassword</see> with all
        /// the defined values
        /// </summary>
        /// <returns>
        /// Returns a <see cref="CreateAssetPassword">CreateAssetPassword</see> class
        /// </returns>
        public CreateAssetPassword Build()
        {
            return new CreateAssetPassword(_companyId, _name, _password);
        }
    }
}