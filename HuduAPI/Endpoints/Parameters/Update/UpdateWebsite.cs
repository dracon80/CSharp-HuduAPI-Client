using HuduAPI.Endpoints.Parameters.AbstractBases;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Provides all the properties requried to update a Website using the hudu api endpoint api/v1/websites
    /// </summary>
    /// <seealso cref="HuduAPI.Endpoints.Parameters.AbstractBases.Website" />
    public class UpdateWebsite : Website, IParameters
    {
        /// <summary>
        /// Gets the identifier of the website to update.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWebsite" /> class with the minimum
        /// required properties assigned.
        /// </summary>
        /// <param name="id">
        /// The identifier of the website to update.
        /// </param>
        /// <param name="name">
        /// The name to set the website too.
        /// </param>
        /// <param name="companyId">
        /// The company identifier the website should be associated with.
        /// </param>
        public UpdateWebsite(int id, string name, int companyId) : base(name, companyId)
        {
            this.Id = id;
        }
    }
}