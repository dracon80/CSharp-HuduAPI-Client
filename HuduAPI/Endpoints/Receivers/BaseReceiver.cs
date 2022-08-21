using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Flurl.Http.Configuration;
using HuduAPI.Endpoints.Parameters;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Receivers
{
    internal static class BaseReceiver<TResult, TParams>
        where TParams : IParameters
        where TResult : IRecord
    {
        public static TResult? Get(string url, string apiKey, [Optional] TParams parameters)
        {
            var flurl = url.WithHeader("x-api-key", apiKey);

            if (parameters != null)
            {
                flurl = flurl.SetQueryParams(parameters.GetPropertyDictionary());
            }

            var result = flurl.GetJsonAsync<TResult>().Result;

            return result;
        }
    }
}