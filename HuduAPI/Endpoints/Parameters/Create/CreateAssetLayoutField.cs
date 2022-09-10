﻿using Newtonsoft.Json;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Defines the attributes of a new Asset Layout Field to be used when creating a new <see
    /// cref="CreateAssetLayouts" />. All requried properties are included in the constructor of the
    /// class. All other properties are optional when making a call to the endpoint api/v1/asset_layouts
    /// </summary>
    public class CreateAssetLayoutField
    {
        private readonly string _fieldType;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetLayoutField" /> class with the
        /// requried fields populated ready for posting.
        /// </summary>
        /// <remark>
        /// All other properties of the class not included in the constructor are optional
        /// properties that can be left blank
        /// </remark>
        /// <param name="label">
        /// Label (used as name) of input.
        /// </param>
        /// <param name="fieldtype">
        /// The type of Field to be created.
        /// </param>
        public CreateAssetLayoutField(string label, CreateAssetLayoutFieldType fieldtype)
        {
            this.Label = label;
            _fieldType = fieldtype.ToString();
        }

        /// <summary>
        /// Whether to Add to Expiration List in hudu
        /// </summary>
        [JsonProperty("expiration")]
        public bool Expiration { get; set; }

        /// <summary>
        /// The type of Field to be created
        /// </summary>
        [JsonProperty("field_type")]
        public string FieldType
        {
            get { return _fieldType; }
        }

        /// <summary>
        /// Hint shown below input box
        /// </summary>
        [JsonProperty("hint")]
        public string? Hint { get; set; }

        /// <summary>
        /// Label (used as name) of input
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; }

        /// <summary>
        /// ID of Asset Layout to pull values from
        /// </summary>
        [JsonProperty("linkable_id")]
        public int? LinkableId { get; set; }

        /// <summary>
        /// Maximum Integer value that can be set on an Number field
        /// </summary>
        [JsonProperty("max")]
        public int? Max { get; set; }

        /// <summary>
        /// Minimum Integer value that can be set on an Number field
        /// </summary>
        [JsonProperty("min")]
        public int? Min { get; set; }

        /// <summary>
        /// List of options for dropdown, separated with new line characters
        /// </summary>
        [JsonProperty("options")]
        public string? Options { get; set; }

        /// <summary>
        /// Leave blank to have auto-filled
        /// </summary>
        [JsonProperty("position")]
        public int? Position { get; set; }

        /// <summary>
        /// Whether to make this value required on form fills
        /// </summary>
        [JsonProperty("required")]
        public bool Required { get; set; }

        /// <summary>
        /// Whether to show this value in list view or not
        /// </summary>
        [JsonProperty("show_in_list")]
        public bool ShowInList { get; set; }
    }
}