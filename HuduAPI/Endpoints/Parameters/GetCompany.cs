using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Paramaters to Get a single Company from Hudu
    /// </summary>
    /// <seealso cref="HuduAPI.Endpoints.Parameters.IParameters" />
    public class GetCompany : IParameters
    {
        private int _id;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCompany" /> class.
        /// </summary>
        /// <param name="id">
        /// The Company ID to use when calling the endpoint get method.
        /// </param>
        public GetCompany(int id)
        {
            this.ID = id;
        }

        /// <summary>
        /// Gets or sets the Company ID of the company to get.
        /// </summary>
        /// <value>
        /// The Company ID.
        /// </value>
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value > 0)
                {
                    _id = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("CompanyID must be greater than 0");
                }
            }
        }
    }
}