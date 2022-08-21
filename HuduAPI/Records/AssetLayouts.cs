using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Records
{
    /// <summary>
    /// Represents a single Field within an AssetLayout that describes the asset.
    /// </summary>
    public class AssetLayoutField
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>
        /// The label.
        /// </value>
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [show in list].
        /// </summary>
        /// <value>
        /// <c>true</c> if [show in list]; otherwise, <c>false</c>.
        /// </value>
        public bool ShowInList { get; set; } = false;

        /// <summary>
        /// Gets or sets the type of the field.
        /// </summary>
        /// <value>
        /// The type of the field.
        /// </value>
        public string FieldType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="AssetLayoutField" /> is required.
        /// </summary>
        /// <value>
        /// <c>true</c> if required; otherwise, <c>false</c>.
        /// </value>
        public bool? Required { get; set; } = false;

        /// <summary>
        /// Gets or sets the hint.
        /// </summary>
        /// <value>
        /// The hint.
        /// </value>
        public string? Hint { get; set; }

        /// <summary>
        /// Determines the minimum of the parameters.
        /// </summary>
        /// <value>
        /// The minimum.
        /// </value>
        public int? Min { get; set; }

        /// <summary>
        /// Determines the maximum of the parameters.
        /// </summary>
        /// <value>
        /// The maximum.
        /// </value>
        public int? Max { get; set; }

        /// <summary>
        /// Gets or sets the linkable identifier.
        /// </summary>
        /// <value>
        /// The linkable identifier.
        /// </value>
        public int? LinkableId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="AssetLayoutField" /> is expiration.
        /// </summary>
        /// <value>
        /// <c>true</c> if expiration; otherwise, <c>false</c>.
        /// </value>
        public bool Expiration { get; set; } = false;

        /// <summary>
        /// Gets or sets the options.
        /// </summary>
        /// <value>
        /// The options.
        /// </value>
        public string? Options { get; set; }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        public int Position { get; set; } = 0;

        /// <summary>
        /// Gets or sets a value indicating whether this instance is destroyed.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is destroyed; otherwise, <c>false</c>.
        /// </value>
        public bool IsDestroyed { get; set; } = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetLayoutField" /> class.
        /// </summary>
        /// <param name="id">
        /// The Assetlayout Field identifier.
        /// </param>
        /// <param name="label">
        /// The label displayed in the GUI.
        /// </param>
        /// <param name="field_type">
        /// Type of the field.
        /// </param>
        public AssetLayoutField(int id, string label, string field_type)
        {
            this.ID = id;
            this.Label = label;
            this.FieldType = field_type;
        }
    }

    /// <summary>
    /// Represents a single asset_layout returned from the Hudu API
    /// </summary>
    /// <seealso cref="HuduAPI.Records.IRecord" />
    public class AssetLayout : IRecord
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the slug.
        /// </summary>
        /// <value>
        /// The slug.
        /// </value>
        public string Slug { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the icon.
        /// </summary>
        /// <value>
        /// The icon.
        /// </value>
        public string Icon { get; set; }

        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        /// <value>
        /// The color.
        /// </value>
        public string Color { get; set; }

        /// <summary>
        /// Gets or sets the color of the icon.
        /// </summary>
        /// <value>
        /// The color of the icon.
        /// </value>
        public string IconColor { get; set; }

        /// <summary>
        /// Gets or sets the sidebar folder identifier.
        /// </summary>
        /// <value>
        /// The sidebar folder identifier.
        /// </value>
        public int? SidebarFolderID { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="AssetLayout" /> is active.
        /// </summary>
        /// <value>
        /// <c>true</c> if active; otherwise, <c>false</c>.
        /// </value>
        public bool Active { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether [include passwords].
        /// </summary>
        /// <value>
        /// <c>true</c> if [include passwords]; otherwise, <c>false</c>.
        /// </value>
        public bool IncludePasswords { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether [include photos].
        /// </summary>
        /// <value>
        /// <c>true</c> if [include photos]; otherwise, <c>false</c>.
        /// </value>
        public bool IncludePhotos { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether [include comments].
        /// </summary>
        /// <value>
        /// <c>true</c> if [include comments]; otherwise, <c>false</c>.
        /// </value>
        public bool IncludeComments { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether [include files].
        /// </summary>
        /// <value>
        /// <c>true</c> if [include files]; otherwise, <c>false</c>.
        /// </value>
        public bool IncludeFiles { get; set; } = true;

        /// <summary>
        /// Gets or sets the created at.
        /// </summary>
        /// <value>
        /// The created at.
        /// </value>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the updated at.
        /// </summary>
        /// <value>
        /// The updated at.
        /// </value>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets the fields.
        /// </summary>
        /// <value>
        /// The fields.
        /// </value>
        public IList<AssetLayoutField> Fields { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetLayout" /> class.
        /// </summary>
        /// <param name="iD">
        /// The AssetLayout ID.
        /// </param>
        /// <param name="slug">
        /// The slug component in the URL.
        /// </param>
        /// <param name="name">
        /// The name of the AssetLayout.
        /// </param>
        /// <param name="icon">
        /// The Icon class name, example: “fas fa-home”.
        /// </param>
        /// <param name="color">
        /// Hex code for background color, example: #000000
        /// </param>
        /// <param name="iconColor">
        /// Hex code for icon foreground color, example: #000000
        /// </param>
        public AssetLayout(int iD, string slug, string name, string icon, string color, string iconColor)
        {
            ID = iD;
            Slug = slug;
            Name = name;
            Icon = icon;
            Color = color;
            IconColor = iconColor;
            Fields = new List<AssetLayoutField>();
        }
    }

    /// <summary>
    /// Represents a list of asset_layouts returned from the Hudu API
    /// </summary>
    public class AssetLayouts : IRecord
    {
        /// <summary>
        /// Gets or sets the asset layout list.
        /// </summary>
        /// <value>
        /// The asset layout list.
        /// </value>
        [JsonProperty("asset_layouts")]
        public IList<AssetLayout> AssetLayoutList { get; set; }

        /// <summary>
        /// Initializes a new empty instance of the <see cref="AssetLayouts" /> class.
        /// </summary>
        public AssetLayouts()
        {
            AssetLayoutList = new List<AssetLayout>();
        }

        /// <summary>
        /// Gets or sets the <see cref="AssetLayout" /> at the specified index.
        /// </summary>
        /// <value>
        /// The <see cref="AssetLayout" />.
        /// </value>
        /// <param name="index">
        /// The index.
        /// </param>
        /// <returns>
        /// </returns>
        public AssetLayout this[int index]
        {
            get => AssetLayoutList[index];
            set => AssetLayoutList[index] = value;
        }
    }
}