using HuduAPI.Endpoints.Parameters.AbstractBases;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Provides all the properties required to create a new website using the hudu endpoint api/v1/websites
    /// </summary>
    public class CreateWebsite : Website, IParameters
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebsite" /> class.
        /// </summary>
        /// <param name="name">
        /// FQND of the website to be monitored (e.g. www.example.com)
        /// </param>
        /// <param name="companyId">
        /// The company identifier to associate the website with.
        /// </param>
        public CreateWebsite(string name, int companyId) : base(name, companyId)
        {
        }
    }
}