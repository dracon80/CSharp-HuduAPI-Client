using HuduAPI.Endpoints.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints
{
    internal interface IEndpointDeleteMethod<TParams>
        where TParams : IParameters
    {
        public void Delete(TParams parameters);
    }
}
