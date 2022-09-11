using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HuduAPI.Endpoints.Parameters.AbstractBases
{
    /// <summary>
    /// Builder for the class <see cref="AssetPassword">CreateAssetPassword</see>
    /// </summary>
    public abstract class AssetPasswordBuilder<TResult, TBuilder>
        where TResult : AssetPassword
        where TBuilder : AssetPasswordBuilder<TResult, TBuilder>
    {
        protected int _companyId;
        protected string? _passwordableType;
        protected int? _passwordableId;
        protected string _name;
        protected bool _inPortal;
        protected string _password;
        protected string? _otpSecret;
        protected string? _url;
        protected string? _username;
        protected string? _description;
        protected string? _passwordType;
        protected int? _passwordFolderId;

        /// <summary>
        /// Gets the builder instance of the implmenting class type.
        /// </summary>
        private readonly TBuilder _builderInstance = null;

        /// <summary>
        /// An abstract class with the common builder methods for creating both Update and Create
        /// paramaters to be used with the api/v1/asset_passwords endpoint.
        /// </summary>
        internal AssetPasswordBuilder(int companyId, string name, string password)
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

            _builderInstance = (TBuilder)this;
        }

        /// <summary>
        /// Set a list of password types, separated with new line characters
        /// </summary>
        /// <param name="passwordableType">
        /// Type of the passwordable.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithPasswordableType(string passwordableType)
        {
            _passwordableType = passwordableType;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for passwordableId
        /// </summary>
        /// <param name="passwordableId">
        /// The passwordable identifier.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithPasswordableId(int? passwordableId)
        {
            _passwordableId = passwordableId;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for inPortal
        /// </summary>
        /// <param name="inPortal">
        /// if set to <c>true</c> [in portal].
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithInPortal(bool inPortal)
        {
            _inPortal = inPortal;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for otpSecret
        /// </summary>
        /// <param name="otpSecret">
        /// The otp secret.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithOtpSecret(string otpSecret)
        {
            _otpSecret = otpSecret;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for url
        /// </summary>
        /// <param name="url">
        /// The URL.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithUrl(string url)
        {
            _url = url;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for username
        /// </summary>
        /// <param name="username">
        /// The username.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithUsername(string username)
        {
            _username = username;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for description
        /// </summary>
        /// <param name="description">
        /// The description.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithDescription(string description)
        {
            _description = description;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for passwordType
        /// </summary>
        /// <param name="passwordType">
        /// Type of the password.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithPasswordType(string passwordType)
        {
            _passwordType = passwordType;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for passwordFolderId
        /// </summary>
        /// <param name="passwordFolderId">
        /// The password folder identifier.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithPasswordFolderId(int? passwordFolderId)
        {
            _passwordFolderId = passwordFolderId;
            return _builderInstance;
        }

        /// <summary>
        /// Builds a new instance of <typeparamref name="TResult" />.
        /// </summary>
        /// <returns>
        /// A new instance of <typeparamref name="TResult" />.
        /// </returns>
        public abstract TResult Build();
    }
}