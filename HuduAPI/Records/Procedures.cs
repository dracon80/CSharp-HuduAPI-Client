using Newtonsoft.Json;

namespace HuduAPI.Records
{
    /// <summary>
    /// Represents a single procedure object returned from the API endpoint procedures
    /// </summary>
    /// <seealso cref="HuduAPI.Records.IRecord" />
    public class Procedure : IRecord
    {
        [JsonProperty("asset")]
        public object Asset { get; set; }

        [JsonProperty("company_name")]
        public object CompanyName { get; set; }

        [JsonProperty("completed")]
        public int Completed { get; set; }

        [JsonProperty("completion_percentage")]
        public string CompletionPercentage { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("object_type")]
        public string ObjectType { get; set; }

        [JsonProperty("parent_procedure")]
        public object ParentProcedure { get; set; }

        [JsonProperty("procedure_tasks_attributes")]
        public IList<ProcedureTasksAttribute> ProcedureTasksAttributes { get; set; }

        [JsonProperty("share_url")]
        public string ShareUrl { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    /// <summary>
    /// This internal class is used to help read the returned json from the HuduAPI endpoint. As the
    /// data contains a named element, there is a parent wrapper object, which this is.
    /// </summary>
    /// <seealso cref="HuduAPI.Records.IRecord" />
    internal class ProcedureRoot : IRecord
    {
        [JsonProperty("procedure")]
        public Procedure Procedure { get; set; }
    }

    /// <summary>
    /// Represents a list of procedure objects returned from the Hudu API endpoing procedures.
    /// </summary>
    /// <seealso cref="HuduAPI.Records.IRecord" />
    public class Procedures : IRecord
    {
        [JsonProperty("procedures")]
        public IList<Procedure> ProcedureList { get; set; }

        /// <summary>
        /// Gets the <see cref="System.Nullable{Procedure}" /> with the specified identifier. Will
        /// return null if no procedure exists for the id supplied
        /// </summary>
        /// <param name="id">
        /// The identifier of the procedure.
        /// </param>
        /// <returns>
        /// A <see cref="Procedure" /> object if found, or null if not.
        /// </returns>
        public Procedure? this[int id]
        {
            get => ProcedureList.FirstOrDefault(t => t.ID == id);
        }
    }

    /// <summary>
    /// Represents Attributes about a Procedure object returned from the Hudu API endpoint procedures
    /// </summary>
    public class ProcedureTasksAttribute
    {
        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("completed_date")]
        public object CompletedDate { get; set; }

        [JsonProperty("completion_notes")]
        public object CompletionNotes { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("user_name")]
        public object UserName { get; set; }
    }
}