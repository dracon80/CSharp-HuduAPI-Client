using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class UpdateMatcher : ICommand<Matcher>
    {
        private readonly string _apiKey;
        private readonly Parameters.UpdateMatcher _params;
        private readonly string _url;

        public UpdateMatcher(String huduBaseURL, string huduAPIKey, Parameters.UpdateMatcher parameters)
        {
            _apiKey = huduAPIKey;
            _url = huduBaseURL + "api/v1/matchers/" + parameters.Id;
            _params = parameters;
        }

        public Matcher Execute()
        {
            var result = BaseReceiver<Matcher, Parameters.UpdateMatcher>.Update(
                url: _url,
                apiKey: _apiKey,
                parameters: _params
                );

            if (result == null)
            {
                throw new HttpRequestException("There was an error updating the Matcher");
            }

            return result;
        }
    }
}