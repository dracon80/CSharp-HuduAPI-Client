﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Runtime.InteropServices;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// A parameter object for the hudu endpoint api/v1/activity_logs. The values provided to the
    /// fields or constructor help narrow down the returned results of the get query. All fields
    /// default to null, which is acceptable by the Hudu API.
    /// </summary>
    /// <seealso cref="HuduAPI.Endpoints.Parameters.IParameters" />
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetActivityLogs : IParameters
    {
        /// <summary>
        /// Gets or sets the action message. Which is used to filter logs by action
        /// </summary>
        /// <value>
        /// The action message to filter by.
        /// </value>
        [JsonProperty("action_message")]
        public string? ActionMessage { get; set; }

        /// <summary>
        /// Gets or sets the current page of results to get.
        /// </summary>
        /// <value>
        /// The page.
        /// </value>
        [JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Gets or sets the number of results to return.
        /// </summary>
        /// <value>
        /// The size of the page.
        /// </value>
        [JsonProperty("page_size")]
        public int? PageSize { get; set; }

        /// <summary>
        /// Gets or sets the resource identifier. Which filters logs by resource id. Must be coupled
        /// with resource_type
        /// </summary>
        /// <value>
        /// The resource identifier.
        /// </value>
        [JsonProperty("resource_id")]
        public int? ResourceID { get; set; }

        /// <summary>
        /// Gets or sets the type of the resource to filter the logs by (Asset, AssetPassword,
        /// Company, Article, etc.). Must be coupled with resource_id
        /// </summary>
        /// <value>
        /// The type of the resource.
        /// </value>
        [JsonProperty("resource_type")]
        public string? ResourceType { get; set; }

        /// <summary>
        /// Gets or sets the start date to filter logs by. Must be in ISO 8601 format.
        /// </summary>
        /// <value>
        /// The start date.
        /// </value>
        [JsonProperty("start_date")]
        public string? StartDate { get; set; }

        /// <summary>
        /// Gets or sets the user email address to filter logs by.
        /// </summary>
        /// <value>
        /// The user email.
        /// </value>
        [JsonProperty("user_email")]
        public string? UserEmail { get; set; }

        /// <summary>
        /// Gets or sets the user identifier to filter logs by.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        [JsonProperty("user_id")]
        public int? UserID { get; set; }

        public string PayloadType
        {
            get
            {
                return "";
            }
        }
    }
}