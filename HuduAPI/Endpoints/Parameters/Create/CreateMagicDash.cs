using Newtonsoft.Json;
using System.Dynamic;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Provides all the properties used to create a new, or update an existing magic_dash item
    /// using the endpoint api/v1/magic_dash
    /// </summary>
    public class CreateMagicDash : IParameters
    {
        private string? _icon;
        private string? _imageUrl;
        private string? _shade;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMagicDash" /> class with the required
        /// properties to create or update an existing magic_dash.
        /// </summary>
        /// <param name="title">
        /// The title of the magic_dash.
        /// </param>
        /// <param name="company_name">
        /// Name of the company to associate the magic_dash with.
        /// </param>
        /// <param name="message">
        /// The message to be displayed on the magic_dash.
        /// </param>
        public CreateMagicDash(string title, string company_name, string message)
        {
            this.Title = title;
            this.CompanyName = company_name;
            this.Message = message;
            _shade = default;
        }

        /// <summary>
        /// This is the attribute we use to match to an existing company. If there is an existing
        /// Magic Dash Item with matching title and company_name, then it will match into that item.
        /// </summary>
        [JsonProperty("company_name")]
        public string CompanyName { get; }

        /// <summary>
        /// Either fill this in, or content_link, or leave both blank. Fill in with HTML (tables,
        /// images, videos, etc.) to display more content in your Magic Dash Item.
        /// </summary>
        [JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// This will be the first content that will be displayed on the Magic Dash Item.
        /// </summary>
        [JsonProperty("content_link")]
        public string? ContentLink { get; set; }

        /// <summary>
        /// Use a (FontAwesome icon for the header of a Magic Dash Item. Must be in the format of
        /// fas fa-circle
        /// </summary>
        /// <remarks>
        /// Either fill this in, or image_url. Setting this property will reset <see cref="ImageUrl"
        /// /> to null.
        /// </remarks>
        [JsonProperty("icon")]
        public string? Icon
        {
            get { return _icon; }
            set
            {
                _icon = value;
                _imageUrl = default;
            }
        }

        /// <summary>
        /// Gets or Sets a URL to an image that is ssed in the header of a Magic Dash Item. Either
        /// fill this in, or <see cref="Icon" />.
        /// </summary>
        /// <remarks>
        /// Either fill this in, or icon. Setting this property will reset <see cref="Icon" /> to null.
        /// </remarks>
        [JsonProperty("image_url")]
        public string? ImageUrl
        {
            get { return _imageUrl; }
            set
            {
                _imageUrl = value;
                _icon = default;
            }
        }

        /// <summary>
        /// This will be the first content that will be displayed on the Magic Dash Item.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; }

        /// <summary>
        /// Use a different color for your Magic Dash Item for different contextual states.
        /// </summary>
        /// <remarks>
        /// Options are to leave it blank, success, or danger (not case sensitive). Setting to any
        /// other string value will result in a blank shade.
        /// </remarks>
        [JsonProperty("shade")]
        public string? Shade
        {
            get { return _shade; }
            set
            {
                //Null is treated as blank
                if (value == null)
                {
                    _shade = default;
                }
                else
                {
                    //Else set the shade to either success or danger.
                    switch (value.ToLower())
                    {
                        case "success":
                            _shade = value.ToLower();
                            break;

                        case "danger":
                            _shade = value.ToLower();
                            break;

                        default:
                            _shade = default;
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// This is the title. If there is an existing Magic Dash Item with matching title and
        /// company_name, then it will match into that item.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; }

        public string PayloadType
        {
            get
            {
                return "asset";
            }
        }
    }
}