using Newtonsoft.Json;

namespace HuduAPI.Records
{
    /// <summary>
    /// This internal class is used to help read the returned json from the HuduAPI endpoint. As the
    /// data contains a named element, there is a parent wrapper object, which this is.
    /// </summary>
    /// <seealso cref="HuduAPI.Records.IRecord" />
    internal class AssetLayoutRoot : IRecord
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetLayoutRoot" /> class.
        /// </summary>
        /// <param name="assetlayout">
        /// The assetlayout.
        /// </param>
        public AssetLayoutRoot(AssetLayout assetlayout)
        {
            AssetLayout = assetlayout;
        }

        [JsonProperty("asset_layout")]
        public AssetLayout AssetLayout { get; set; }
    }

    /// <summary>
    /// Represents a single asset_layout returned from the Hudu API
    /// </summary>
    /// <seealso cref="HuduAPI.Records.IRecord" />
    public class AssetLayout : IRecord
    {
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

        public bool Active { get; set; } = true;

        public string Color { get; set; }

        public DateTime? CreatedAt { get; set; }

        public IList<AssetLayoutField> Fields { get; set; }

        public string Icon { get; set; }

        public string IconColor { get; set; }

        public int ID { get; set; }

        public bool IncludeComments { get; set; } = true;

        public bool IncludeFiles { get; set; } = true;

        public bool IncludePasswords { get; set; } = true;

        public bool IncludePhotos { get; set; } = true;

        public string Name { get; set; }

        public int? SidebarFolderID { get; set; }

        public string Slug { get; set; }

        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets the <see cref="System.Nullable{AssetLayoutField}" /> with the specified label. If
        /// not found than null is returned
        /// </summary>
        /// <param name="label">
        /// The label of the AssetLayout Field that is required.
        /// </param>
        /// <returns>
        /// </returns>
        public AssetLayoutField? this[string label]
        {
            get => Fields.FirstOrDefault(c => c.Label == label);
        }

        /// <summary>
        /// Represents a single Field within an AssetLayout that describes the asset.
        /// </summary>
        public class AssetLayoutField
        {
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

            public bool Expiration { get; set; } = false;
            public string FieldType { get; set; }
            public string? Hint { get; set; }
            public int ID { get; set; }
            public bool IsDestroyed { get; set; } = false;
            public string Label { get; set; }
            public int? LinkableId { get; set; }
            public int? Max { get; set; }
            public int? Min { get; set; }
            public string? Options { get; set; }
            public int Position { get; set; } = 0;
            public bool? Required { get; set; } = false;
            public bool ShowInList { get; set; } = false;
        }
    }

    /// <summary>
    /// Represents a list of asset_layouts returned from the Hudu API
    /// </summary>
    public class AssetLayouts : IRecord
    {
        /// <summary>
        /// Initializes a new empty instance of the <see cref="AssetLayouts" /> class.
        /// </summary>
        public AssetLayouts()
        {
            AssetLayoutList = new List<AssetLayout>();
        }

        /// <summary>
        /// Gets or sets the asset layout list.
        /// </summary>
        /// <value>
        /// The asset layout list.
        /// </value>
        [JsonProperty("asset_layouts")]
        public IList<AssetLayout> AssetLayoutList { get; set; }

        /// <summary>
        /// Gets the <see cref="System.Nullable{AssetLayout}" /> with the supplied name. If there is
        /// not assetlayout with that name then null will be returned.
        /// </summary>
        /// <param name="name">
        /// The name of the assetlayout required.
        /// </param>
        /// <returns>
        /// </returns>
        public AssetLayout? this[string name]
        {
            get => AssetLayoutList.FirstOrDefault(c => c.Name == name);
        }
    }
}