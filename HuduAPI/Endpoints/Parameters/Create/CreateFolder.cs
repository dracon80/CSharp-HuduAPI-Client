﻿using Newtonsoft.Json;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Provides all the properties needed to create a new folder using the hudu endpoint api/v1/folders
    /// </summary>
    public class CreateFolder : IParameters
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFolder" /> class used to create a new folder.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        public CreateFolder(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Gets or sets the company identifier to associate this folder with.
        /// </summary>
        [JsonProperty("company_id")]
        public int? CompanyId { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or Sets the Icon class name, example: “fas fa-home”
        /// </summary>
        [JsonProperty("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// Gets or sets the name of the folder.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; }

        /// <summary>
        /// Gets or sets the folder ID to associate this folder with a parent folder.
        /// </summary>
        [JsonProperty("parent_folder_id")]
        public int? ParentFolderId { get; set; }
    }
}