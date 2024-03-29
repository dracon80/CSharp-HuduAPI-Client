﻿using Newtonsoft.Json;

namespace HuduAPI.Records
{
    /// <summary>
    /// Represents a returned ActivityLog from the Hudu API endpoint activity_logs
    /// </summary>
    /// <seealso cref="HuduAPI.Records.IRecord" />
    public class ActivityLog : IRecord
    {
        [JsonProperty("action")]
        public string? Action { get; set; }

        [JsonProperty("app_type")]
        public string? AppType { get; set; }

        [JsonProperty("company_name")]
        public string? CompanyName { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("details")]
        public object? Details { get; set; }

        [JsonProperty("formatted_datetime")]
        public string? FormattedDatetime { get; set; }

        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("ip_address")]
        public string? IPAddress { get; set; }

        [JsonProperty("record_company_url")]
        public string? RecordCompanyUrl { get; set; }

        [JsonProperty("record_id")]
        public int? RecordID { get; set; }

        [JsonProperty("record_name")]
        public string? RecordName { get; set; }

        [JsonProperty("record_type")]
        public string? RecordType { get; set; }

        [JsonProperty("record_url")]
        public string? RecordUrl { get; set; }

        [JsonProperty("record_user_url")]
        public string? RecordUserUrl { get; set; }

        [JsonProperty("token")]
        public string? Token { get; set; }

        [JsonProperty("user_email")]
        public string? UserEmail { get; set; }

        [JsonProperty("user_id")]
        public int UserID { get; set; }

        [JsonProperty("user_name")]
        public string? UserName { get; set; }
    }

    /// <summary>
    /// Represents a list of ActivityLog entries
    /// </summary>
    /// <seealso cref="HuduAPI.Records.IRecord" />
    public class ActivityLogs : IRecord
    {
        public ActivityLogs(List<ActivityLog> activityList)
        {
            ActivityList = activityList;
        }

        public ActivityLogs()
        {
            this.ActivityList = new List<ActivityLog>();
        }

        public List<ActivityLog> ActivityList { get; set; }

        /// <summary>
        /// Gets the <see cref="System.Nullable{ActivityLog}" /> with the specified identifier.
        /// </summary>
        /// <value>
        /// The <see cref="System.Nullable{ActivityLog}" />.
        /// </value>
        /// <param name="id">
        /// The identifier.
        /// </param>
        /// <returns>
        /// </returns>
        public ActivityLog? this[int id]
        {
            get => ActivityList.FirstOrDefault(t => t.ID == id);
        }
    }
}