using Flurl;
using Flurl.Http;
using Flurl.Util;
using HuduAPI.Endpoints.Parameters;
using HuduAPI.Records;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace HuduAPI.Endpoints.Receivers
{
    /// <summary>
    /// The BaseReciever is a generic class to make calls to the endpoints when a standard call is
    /// possible. This provides code reuse through composition rather then inheritance.
    /// </summary>
    /// <typeparam name="TResult">
    /// The expected type of the returned result when calling the endpoint. Results are restricted
    /// to objects that implement the IRecord Interface
    /// </typeparam>
    /// <typeparam name="TParams">
    /// The expected type of the parameter that will supplied to the end point.
    /// </typeparam>
    internal static class BaseReceiver<TResult, TParams>
        where TParams : IParameters
        where TResult : IRecord
    {
        /// <summary>
        /// Makes a call to the Create Method for the supplied URL and returns a result containing
        /// the created object.
        /// </summary>
        /// <param name="url">
        /// The URL of the API Endpoint to call.
        /// </param>
        /// <param name="apiKey">
        /// The API key to use when making the call.
        /// </param>
        /// <param name="parameters">
        /// The parameters that need to be provided to the end point.
        /// </param>
        /// <returns>
        /// If the call is succesfull then a <typeparamref name="TResult" /> Result Type
        /// </returns>
        /// will be returned that contains the values that be been set on the new item created in Hudu.
        public static TResult Create(string url, string apiKey, TParams parameters)
        {
            var result = url.WithHeader("x-api-key", apiKey).PostJsonAsync(parameters.GetPropertyDictionary()).ReceiveJson<TResult>();
            var param = JsonConvert.SerializeObject(parameters.GetPropertyDictionary());

            return result.Result;
        }

        /// <summary>
        /// Calls the API endpoint using the parameters provided to narrow down the results. This
        /// method is used to query endpoints that return a single root object.
        /// </summary>
        /// <param name="url">
        /// The URL of the endpoint to be called.
        /// </param>
        /// <param name="apiKey">
        /// The API key to authenticate with the endpoint.
        /// </param>
        /// <param name="parameters">
        /// The parameters to be used with the endpoint.
        /// </param>
        /// <returns>
        /// Returns the result of the query to the API endpoint
        /// </returns>
        public static TResult? Get(string url, string apiKey, [Optional] TParams parameters)
        {
            var flurl = url.WithHeader("x-api-key", apiKey);

            //If there are parameters to be supplied then append them to the flurl object
            if (parameters != null)
            {
                flurl = flurl.SetQueryParams(parameters.GetPropertyDictionary());
            }

            var result = flurl.GetJsonAsync<TResult>().Result;

            return result;
        }

        /// <summary>
        /// Calls the API endpoint using the parameters provided to narrow down the results. This
        /// method is used to query endpoints that return an array of objects.
        /// </summary>
        /// <param name="url">
        /// The URL of the endpoint to be called.
        /// </param>
        /// <param name="apiKey">
        /// The API key to authenticate with the endpoint.
        /// </param>
        /// <param name="parameters">
        /// The parameters to be used with the endpoint.
        /// </param>
        /// <returns>
        /// Returns a List of Type TResult with all the returned results from the call to the endpoint
        /// </returns>
        public static List<TResult>? GetList(string url, string apiKey, [Optional] TParams parameters)
        {
            var flurl = url.WithHeader("x-api-key", apiKey);

            if (parameters != null)
            {
                flurl = flurl.SetQueryParams(parameters.GetPropertyDictionary());
            }

            var result = flurl.GetJsonAsync<List<TResult>>().Result;

            return result;
        }

        /// <summary>
        /// Makes a call to the Update Method for the supplied URL and returns a result containing
        /// the updated object values.
        /// </summary>
        /// <param name="url">
        /// The URL of the API Endpoint to call.
        /// </param>
        /// <param name="apiKey">
        /// The API key to use when making the call.
        /// </param>
        /// <param name="parameters">
        /// The parameters that need to be provided to the end point.
        /// </param>
        /// <returns>
        /// If the call is succesfull then a <typeparamref name="TResult" /> Result Type will be
        /// returned that contains the values that be been set on the new item created in Hudu.
        /// </returns>
        public static TResult Update(string url, string apiKey, TParams parameters)
        {
            var result = url.WithHeader("x-api-key", apiKey).PutJsonAsync(parameters.GetPropertyDictionary()).ReceiveJson<TResult>().Result;
            return result;
        }

        /// <summary>
        /// Makes a call to the Archive/Unarchive Method for the supplied URL and returns a result
        /// containing the updated object values.
        /// </summary>
        /// <param name="url">
        /// The URL of the API Endpoint to call.
        /// </param>
        /// <param name="apiKey">
        /// The API key to use when making the call.
        /// </param>
        /// <returns>
        /// If the call is succesfull then a <typeparamref name="TResult" /> Result Type will be
        /// returned that contains the values that be been set on the new item created in Hudu.
        /// </returns>
        public static TResult Archive(string url, string apiKey)
        {
            var result = url.WithHeader("x-api-key", apiKey).PutAsync().ReceiveJson<TResult>().Result;
            return result;
        }
    }
}