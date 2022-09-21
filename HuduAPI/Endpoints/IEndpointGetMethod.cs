using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HuduAPI.Endpoints.Parameters;
using HuduAPI.Records;

namespace HuduAPI.Endpoints
{
    /// <summary>
    /// All Endpoints that implement a Get call must implement this internal interface. The
    /// interface at this point in only used to standardise the way get methods are written and the
    /// interface is no directly used to initiate any objects.
    /// </summary>
    /// <typeparam name="TResult">
    /// The type that will be returned when calling the Get Method. The Type must implement the <see
    /// cref="IRecord" /> interface.
    /// </typeparam>
    /// <typeparam name="TParams">
    /// The type of parameters that must be supplied to the Get Method. The Type must implement the
    /// <see cref="IParameters" /> interface.
    /// </typeparam>
    internal interface IEndpointGetMethod<TResult, TParams>
        where TResult : IRecord
        where TParams : IParameters
    {
        /// <summary>
        /// Implementing classes should provide the function to call a get method on the Hudu Endpoint
        /// </summary>
        /// <param name="parameters">
        /// The parameters to use when making the call.
        /// </param>
        /// <returns>
        /// An object of type <typeparamref name="TResult" /> that represents the object in hudu
        /// </returns>
        public TResult Get(TParams parameters);
    }
}