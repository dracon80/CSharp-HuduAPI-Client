using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints.Parameters
{
    public class EndpointParameters<ParamType>
        where ParamType : IParameters
    {
        public EndpointParameters(string huduAPIKey, string huduBaseURL, ParamType parameters)
        {
            HuduAPIKey = huduAPIKey;
            HuduBaseURL = huduBaseURL;
            Parameters = parameters;
        }

        public string HuduAPIKey { get; set; }
        public string HuduBaseURL { get; set; }
        public ParamType Parameters { get; set; }
    }
}
