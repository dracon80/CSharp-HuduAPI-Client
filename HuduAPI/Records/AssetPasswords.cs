using Newtonsoft.Json;

namespace HuduAPI.Records
{
    /// <summary>
    /// This internal class is used to help read the returned json from the HuduAPI endpoint. As the
    /// data contains a named element, there is a parent wrapper object, which this is.
    /// </summary>
    /// <seealso cref="HuduAPI.Records.IRecord" />
    internal class AssetPasswordRoot : IRecord
    {
        [JsonProperty("asset_password")]
        public AssetPassword AssetPassword { get; set; }
    }

    /// <summary>
    /// Represents an Asset Password returned from the Hudu API.
    /// </summary>
    /// <seealso cref="HuduAPI.Records.IRecord" />
    public class AssetPassword : IRecord
    {
        [JsonProperty("company_id")]
        public int CompanyID { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("otp_secret")]
        public object OtpSecret { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("passwordable_id")]
        public object PasswordableID { get; set; }

        [JsonProperty("passwordable_type")]
        public string PasswordableType { get; set; }

        [JsonProperty("password_folder_id")]
        public object PasswordFolderID { get; set; }

        [JsonProperty("password_folder_name")]
        public object PasswordFolderName { get; set; }

        [JsonProperty("password_type")]
        public object PasswordType { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

    /// <summary>
    /// Represents a list of Asset Passwords returned from the Hudu api endpoint asset_passwords
    /// </summary>
    /// <seealso cref="HuduAPI.Records.IRecord" />
    public class AssetPasswords : IRecord
    {
        [JsonProperty("asset_passwords")]
        public IList<AssetPassword>? AssetPasswordList { get; set; }

        /// <summary>
        /// Gets the <see cref="System.Nullable{AssetPassword}" /> with the specified identifier.
        /// Null is returned if no result is found
        /// </summary>
        /// <value>
        /// The <see cref="System.Nullable{AssetPassword}" />.
        /// </value>
        /// <param name="id">
        /// The identifier.
        /// </param>
        /// <returns>
        /// </returns>
        public AssetPassword? this[int id]
        {
            get => AssetPasswordList.FirstOrDefault(t => t.ID == id);
        }
    }
}