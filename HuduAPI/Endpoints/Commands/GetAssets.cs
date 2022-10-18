using HuduAPI.Endpoints.Exceptions;
using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class GetAssets : ICommand<Assets>
    {
        private readonly string _apiKey;
        private readonly Parameters.GetAssets _getParams;
        private readonly string _url;

        public GetAssets(String huduBaseURL, string huduAPIKey, Parameters.GetAssets parameters)
        {
            _getParams = parameters ?? new Parameters.GetAssets();
            _url = huduBaseURL + "api/v1/assets";
            _apiKey = huduAPIKey;
        }

        public Assets Execute()
        {
            var result = BaseReceiver<Assets, Parameters.GetAssets>.Get(
                url: _url,
                apiKey: _apiKey,
                _getParams
                );

            if (result == null)
            {
                throw new RecordNotFoundException("No Assets were found that match the parameters");
            }

            return result;
        }
    }
}