using HuduAPI.Endpoints.Exceptions;
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
        private readonly Parameters.GetCompanies _getParams;
        private readonly string _url;
        private readonly string _apiKey;

        public GetCompanies(String huduBaseURL, string huduAPIKey, Parameters.GetCompanies parameters)
        {
            _getParams = parameters ?? new Parameters.GetCompanies();
            _url = huduBaseURL + "api/v1/companies";
            _apiKey = huduAPIKey;
        }

        public Companies Execute()
        {
            var result = BaseReceiver<Companies, Parameters.GetCompanies>.Get(
                url: _url,
                apiKey: _apiKey,
                _getParams
                );

            if (result == null)
            {
                throw new RecordNotFoundException("No companies were found that match the parameters");
            }

            return result;
        }
    }
}