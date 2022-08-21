using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints
{
    internal interface IEndpoint
    {
        public string HuduAPIKey { get; set; }
        public string HuduBaseURL { get; set; }
    }
}
