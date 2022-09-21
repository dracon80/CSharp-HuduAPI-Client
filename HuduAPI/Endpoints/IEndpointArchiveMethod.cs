using HuduAPI.Endpoints.Parameters;
using HuduAPI.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints
{
    /// <summary>
    /// All Endpoints that implement a Archive calls must implement this internal interface. The
    /// interface at this point in only used to standardise the way Archive methods are written and
    /// the interface is not directly used to initiate any objects.
    /// </summary>
    /// <typeparam name="TResult">
    /// The type that will be returned when calling the Archive Method. The Type must implement the
    /// <see cref="IRecord" /> interface.
    /// </typeparam>
    /// <typeparam name="TParams">
    /// The type of parameters that must be supplied to the Create Method. The Type must implement
    /// the <see cref="IParameters" /> interface.
    /// </typeparam>
    internal interface IEndpointArchiveMethod<TResult, TParams>
        where TResult : IRecord
        where TParams : IParameters
    {
        /// <summary>
        /// Implementing classes should provide the function to call a get method on the Hudu Endpoint
        /// </summary>
        /// <param name="parameters">
        /// The parameters to use when making the call.
        /// </param>
        /// <param name="archive">
        /// Should the item be archived? True will archive the item, fales will unarchive the item
        /// </param>
        /// <returns>
        /// An object of type <typeparamref name="TResult" /> that represents the created object in hudu
        /// </returns>
        public TResult Archive(TParams parameters, Boolean archive);
    }
}