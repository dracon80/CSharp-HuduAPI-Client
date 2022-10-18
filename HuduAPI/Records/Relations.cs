using Newtonsoft.Json;

namespace HuduAPI.Records
{
    /// <summary>
    /// Represents a single Relation object returned from the Hudu API
    /// </summary>
    public class Relation : IRecord
    {
        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("fromable_id")]
        public int FromableID { get; set; }

        [JsonProperty("fromable_type")]
        public string FromableType { get; set; }

        [JsonProperty("fromable_url")]
        public string FromableUrl { get; set; }

        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("is_inverse")]
        public bool IsInverse { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("toable_id")]
        public int ToableID { get; set; }

        [JsonProperty("toable_type")]
        public string ToableType { get; set; }

        [JsonProperty("toable_url")]
        public string ToableUrl { get; set; }
    }

    /// <summary>
    /// Represents a list of Relation objects that are returned from the Hudu API
    /// </summary>
    /// <seealso cref="HuduAPI.Records.IRecord"/>
    public class Relations : IRecord
    {
        [JsonProperty("relations")]
        public IList<Relation> RelationsList { get; set; }

        /// <summary>
        /// Gets the <see cref="System.Nullable{Relation}"/> with the specified identifier. Returned
        /// null if no relation is found with the supplied ID
        /// </summary>
        /// <param name="id">The id of the relation to retrieve.</param>
        /// <returns>The <see cref="Relation"/> object request by ID.</returns>
        public Relation? this[int id]
        {
            get => RelationsList.FirstOrDefault(t => t.ID == id);
        }
    }

    /// <summary>
    /// Root Element holder for the returned Json
    /// </summary>
    /// <seealso cref="HuduAPI.Records.IRecord"/>
    internal class RelationRoot : IRecord
    {
        /// <summary>
        /// Gets or sets the relation.
        /// </summary>
        /// <value>The relation.</value>
        [JsonProperty("relation")]
        public Relation Relation { get; set; }
    }
}