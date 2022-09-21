using HuduAPI.Endpoints.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints
{
    /// <summary>
    /// All Endpoints that implement a Delete call must implement this internal interface. The
    /// interface at this point in only used to standardise the way Delete methods are written and
    /// the interface is not directly used to initiate any objects.
    /// </summary>
    /// <typeparam name="TParams">
    /// The type of parameters that must be supplied to the Delete Method. The Type must implement
    /// the <see cref="IParameters" /> interface.
    /// </typeparam>
    internal interface IEndpointDeleteMethod<TParams>
        where TParams : IParameters
    {
        /// <summary>
        /// Implementing classes should provide the function to call a get method on the Hudu Endpoint
        /// </summary>
        /// <param name="parameters">
        /// The parameters to use when making the call.
        /// </param>
        public void Delete(TParams parameters);
    }
}