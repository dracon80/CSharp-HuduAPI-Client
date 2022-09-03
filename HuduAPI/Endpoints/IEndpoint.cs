using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints
{
    /// <summary>
    /// A simple internal interface to define the 2 required fields for all endpoints to be able to
    /// make calls to the Hudu API. A Abstract class was not used I did not want to clutter the
    /// public name space when an internal interface will do the job
    /// </summary>
    internal interface IEndpoint
    {
        /// <summary>
        /// Gets or sets the hudu API key that will be used for all calls to this Endpoint.
        /// </summary>
        /// <value>
        /// The hudu API key.
        /// </value>
        public string HuduAPIKey { get; set; }

        /// <summary>
        /// Gets or sets the hudu base URL that will be used for all calls to the Endpoint.
        /// </summary>
        /// <value>
        /// The hudu base URL.
        /// </value>
        public string HuduBaseURL { get; set; }
    }
}