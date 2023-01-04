using HuduAPI.Endpoints.Exceptions;
using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class GetMatchers : ICommand<Matchers>
    {
        private readonly string _apiKey;
        private readonly Parameters.GetMatchers _getParams;
        private readonly string _url;

        public GetMatchers(String huduBaseURL, string huduAPIKey, Parameters.GetMatchers parameters)
        {
            _getParams = parameters;
            _url = huduBaseURL + "api/v1/matchers";
            _apiKey = huduAPIKey;
        }

        public Matchers Execute()
        {
            var result = BaseReceiver<Matchers, Parameters.GetMatchers>.Get(
                url: _url,
                apiKey: _apiKey,
                _getParams
                );

            if (result == null)
            {
                throw new RecordNotFoundException("No Matchers were found that match the parameters");
            }

            return result;
        }
    }
}