using HuduAPI.Endpoints.Parameters;
using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints.Commands
{
    internal class GetCompanies : ICommand<Companies>
    {
        private readonly EndpointParameters<GetCompaniesParameters> _getParams;
        private readonly string _url;

        public GetCompanies([Optional] EndpointParameters<GetCompaniesParameters> getParameters)
        {
            _getParams = getParameters;
            _url = _getParams.HuduBaseURL + "api/v1/companies";
        }

        public Companies Execute()
        {
            return BaseReceiver<Companies, GetCompaniesParameters>.Get(
                url: _url,
                apiKey: _getParams.HuduAPIKey,
                _getParams.Parameters
                );
        }
    }
}