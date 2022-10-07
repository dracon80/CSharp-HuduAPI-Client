using HuduAPI.Endpoints.Parameters.AbstractBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Provides all the properties required to call the hudu endpoint api/v1/companies and update
    /// an existing company.
    /// </summary>
    /// <seealso cref="HuduAPI.Endpoints.Parameters.AbstractBases.Company" />
    public class UpdateCompany : Company, IParameters
    {
        /// <summary>
        /// Gets the identifier of the company.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCompany" /> class with the required
        /// properties assigned.
        /// </summary>
        /// <param name="id">
        /// The identifier of the company to update.
        /// </param>
        /// <param name="name">
        /// The name the company will be updated with.
        /// </param>
        public UpdateCompany(int id, string name) : base(name)
        {
            this.Id = id;
        }

        public string PayloadType
        {
            get
            {
                return "company";
            }
        }
    }
}