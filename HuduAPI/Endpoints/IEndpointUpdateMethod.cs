using HuduAPI.Endpoints.Parameters;
using HuduAPI.Records;

namespace HuduAPI.Endpoints
{
    /// <summary>
    /// All Endpoints that implement am Update call must implement this internal interface. The
    /// interface at this point in only used to standardise the way Update methods are written and
    /// the interface is not directly used to initiate any objects.
    /// </summary>
    /// <typeparam name="TResult">
    /// The type that will be returned when calling the Update Method. The Type must implement the
    /// <see cref="IRecord" /> interface.
    /// </typeparam>
    /// <typeparam name="TParams">
    /// The type of parameters that must be supplied to the pdate Method. The Type must implement
    /// the <see cref="IParameters" /> interface.
    /// </typeparam>
    internal interface IEndpointUpdateMethod<TResult, TParams>
        where TResult : IRecord
        where TParams : IParameters
    {
        /// <summary>
        /// Implementing classes should provide the function to call an update method on the Hudu Endpoint
        /// </summary>
        /// <param name="parameters">
        /// The parameters to use when making the call.
        /// </param>
        /// <returns>
        /// An object of type <typeparamref name="TResult" /> that represents the updated object in hudu
        /// </returns>
        public TResult Update(TParams parameters);
    }
}