using HuduAPI.Endpoints.Exceptions;
using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class GetCompanies : ICommand<Companies>
    {
        private readonly string _apiKey;
        private readonly Parameters.GetCompanies _getParams;
        private readonly string _url;

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