using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HuduAPI.Endpoints.Parameters;
using HuduAPI.Records;

namespace HuduAPI.Endpoints
{
    internal interface IEndpointGetMethod<TResult, TParams>
        where TResult : IRecord?
        where TParams : IParameters
    {
        public TResult Get(TParams parameters);
    }
}
