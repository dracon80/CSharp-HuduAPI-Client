using HuduAPI.Endpoints.Parameters.AbstractBases;
using Newtonsoft.Json;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Provides all the properties required to create a new company using the hudu endpoint api/v1/companies
    /// </summary>
    public class CreateCompany : Company, IParameters
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCompany" /> class with all required
        /// properties assigned.
        /// </summary>
        /// <param name="name">
        /// The name of the new company.
        /// </param>
        public CreateCompany(string name) : base(name)
        {
        }
    }
}