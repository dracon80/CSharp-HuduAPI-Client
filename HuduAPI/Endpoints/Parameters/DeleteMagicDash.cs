using Newtonsoft.Json;
using System.Dynamic;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Provides all the properties used to delete an existing magic_dash item using the endpoint api/v1/magic_dash
    /// </summary>
    public class DeleteMagicDash : IParameters
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteMagicDash"/> class with the required
        /// properties to delete an existing magic_dash.
        /// </summary>
        /// <param name="title">The title of the magic_dash.</param>
        /// <param name="company_name">Name of the company to associate the magic_dash with.</param>
        public DeleteMagicDash(string title, string company_name)
        {
            this.Title = title;
            this.CompanyName = company_name;
        }

        /// <summary>
        /// This is the attribute we use to match to an existing company. If there is an existing
        /// Magic Dash Item with matching title and company_name, then it will match into that item.
        /// </summary>
        [JsonProperty("company_name")]
        public string CompanyName { get; }

        [JsonIgnore]
        public string PayloadType
        {
            get
            {
                return "";
            }
        }

        /// <summary>
        /// This is the title. If there is an existing Magic Dash Item with matching title and
        /// company_name, then it will match into that item.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; }
    }
}