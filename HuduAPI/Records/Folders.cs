using Newtonsoft.Json;

namespace HuduAPI.Records
{
    /// <summary>
    /// This internal class is used to help read the returned json from the HuduAPI endpoint. As the
    /// data contains a named element, there is a parent wrapper object, which this is.
    /// </summary>
    internal class FolderRoot
    {
        [JsonProperty("folder")]
        public Folder Folder { get; set; }
    }

    /// <summary>
    /// Represents a single folder object returned from the Hudu API endpoing folders
    /// </summary>
    /// <seealso cref="HuduAPI.Records.IRecord" />
    public class Folder : IRecord
    {
        [JsonProperty("company_id")]
        public int? CompanyID { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("icon")]
        public object Icon { get; set; }

        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parent_folder_id")]
        public object ParentFolderID { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }

    /// <summary>
    /// Represents a list of Folder objects returned from the Hudud Endpont
    /// </summary>
    /// <seealso cref="HuduAPI.Records.IRecord" />
    public class Folders : IRecord
    {
        [JsonProperty("folders")]
        public IList<Folder> FolderList { get; set; }

        /// <summary>
        /// Gets the <see cref="System.Nullable{Folder}" /> with the specified identifier. Will
        /// return null if no folder exists with the supplied ID
        /// </summary>
        /// <value>
        /// The <see cref="System.Nullable{Folder}" />.
        /// </value>
        /// <param name="id">
        /// The identifier.
        /// </param>
        /// <returns>
        /// </returns>
        public Folder? this[int id]
        {
            get => FolderList.FirstOrDefault(t => t.ID == id);
        }
    }
}