using Newtonsoft.Json;
using System.Drawing;

namespace HuduAPI.Endpoints.Parameters.AbstractBases
{
    /// <summary>
    /// Defines the properties to be used when creating a new AssetLayout in Hudu using the endpoint api/v1/asset_layouts
    /// </summary>
    public abstract class AssetLayout
    {
        protected readonly Color _color;
        protected readonly Color _iconColor;

        /// <summary>
        /// An Abstract class that contains all the common properties for both the Create and Update
        /// methods on the hudu endpoing api/v1/asset_layouts.
        /// </summary>
        /// <remarks>
        /// All other properties of the class are optional properties that can safely be left blank
        /// and still be able to call the endpoint
        /// </remarks>
        /// <param name="name">
        /// The name of the new asset_layout.
        /// </param>
        /// <param name="icon">
        /// The Icon class name, example: “fas fa-home”.
        /// </param>
        /// <param name="color">
        /// The Color for background color.
        /// </param>
        /// <param name="iconColor">
        /// Color of the icon foreground.
        /// </param>
        /// <param name="assetLayoutFields">
        /// The asset layout fields.
        /// </param>
        public AssetLayout(string name, string icon, Color color, Color iconColor, List<AssetLayoutField> assetLayoutFields)
        {
            this.Name = name;
            this.Icon = icon;
            this._color = color;
            this._iconColor = iconColor;
            this.Fields = assetLayoutFields;
        }

        /// <summary>
        /// The background color of the Icon
        /// </summary>
        [JsonProperty("color")]
        public string Color
        {
            get
            {
                //Converting to Argb first stops ToHtml() from returning a known colors name instead of HEX.
                return ColorTranslator.ToHtml(System.Drawing.Color.FromArgb(_color.ToArgb()));
            }
        }

        /// <summary>
        /// A list of fields defined for this asset_layout
        /// </summary>
        [JsonProperty("fields")]
        public List<AssetLayoutField> Fields { get; }

        /// <summary>
        /// Icon class name, example: “fas fa-home”
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; }

        /// <summary>
        /// The foreground color of the Icon
        /// </summary>
        [JsonProperty("icon_color")]
        public string IconColor
        {
            get
            {
                //Converting to Argb first stops ToHtml() from returning a known colors name instead of HEX.
                return ColorTranslator.ToHtml(System.Drawing.Color.FromArgb(_iconColor.ToArgb()));
            }
        }

        /// <summary>
        /// Allow comments to be attached to this asset_layout
        /// </summary>
        [JsonProperty("include_comments")]
        public bool IncludeComments { get; set; }

        /// <summary>
        /// Allow files to be attached to this asset_layout
        /// </summary>
        [JsonProperty("include_files")]
        public bool IncludeFiles { get; set; }

        /// <summary>
        /// Allow passwords to be attached to this asset_layout
        /// </summary>
        [JsonProperty("include_passwords")]
        public bool IncludePasswords { get; set; }

        /// <summary>
        /// Allow photos to be attached to this asset_layout
        /// </summary>
        [JsonProperty("include_photos")]
        public bool IncludePhotos { get; set; }

        /// <summary>
        /// The name of the asset_layout to be created
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; }

        /// <summary>
        /// List of password types, separated with new line characters
        /// </summary>
        [JsonProperty("password_types")]
        public string? PasswordTypes { get; set; }
    }
}