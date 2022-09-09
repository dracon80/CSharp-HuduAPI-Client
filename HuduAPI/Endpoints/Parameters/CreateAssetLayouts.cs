using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints.Parameters
{
    public class CreateAssetLayouts : IParameters
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("icon_color")]
        public string IconColor { get; set; }

        [JsonProperty("include_passwords")]
        public bool IncludePasswords { get; set; }

        [JsonProperty("include_photos")]
        public bool IncludePhotos { get; set; }

        [JsonProperty("include_comments")]
        public bool IncludeComments { get; set; }

        [JsonProperty("include_files")]
        public bool IncludeFiles { get; set; }

        [JsonProperty("password_types")]
        public string? PasswordTypes { get; set; }

        [JsonProperty("fields")]
        public List<CreateAssetLayoutField> Fields { get; set; }

        public CreateAssetLayouts(string name, string icon, string color, string iconColor, List<CreateAssetLayoutField> assetLayoutFields)
        {
            this.Name = name;
            this.Icon = icon;
            this.Color = color;
            this.IconColor = iconColor;
            this.Fields = assetLayoutFields;
        }
    }
}