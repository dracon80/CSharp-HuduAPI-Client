using Newtonsoft.Json;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Provides all the properties that define a new asset_password to be created in hudu using the
    /// endpoint api/v1/asset_passwords
    /// </summary>
    public class CreateAssetPassword : IParameters
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
        public CreateAssetPassword(int companyId, string name, string password)
        {
            CompanyId = companyId;
            Name = name;
            InPortal = false;
            Password = password;
        }

        /// <summary>
        /// Gets or sets the company identifier to associate the password with.
        /// </summary>
        [JsonProperty("company_id")]
        public int CompanyId { get; set; }

        /// <summary>
        /// A short description of the password
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Should the password be shown in the user portal
        /// </summary>
        [JsonProperty("in_portal")]
        public bool InPortal { get; set; }

        /// <summary>
        /// The name of the password
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The OTP secret code to generate the OTP
        /// </summary>
        [JsonProperty("otp_secret")]
        public string? OtpSecret { get; set; }

        /// <summary>
        /// The password in plain text
        /// </summary>
        [JsonProperty("password")]
        public string? Password { get; set; }

        /// <summary>
        /// No idea
        /// </summary>
        [JsonProperty("passwordable_id")]
        public int? PasswordableId { get; set; }

        /// <summary>
        /// No idea
        /// </summary>
        [JsonProperty("passwordable_type")]
        public string? PasswordableType { get; set; }

        /// <summary>
        /// The folder ID the password should be stored in
        /// </summary>
        [JsonProperty("password_folder_id")]
        public int? PasswordFolderId { get; set; }

        /// <summary>
        /// The type of password
        /// </summary>
        [JsonProperty("password_type")]
        public string? PasswordType { get; set; }

        /// <summary>
        /// The URL associated with the password
        /// </summary>
        [JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The username associated with the password
        /// </summary>
        [JsonProperty("username")]
        public string? Username { get; set; }
    }
}