using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class UpdateWebsite : ICommand<Website>
    {
        private readonly string _apiKey;
        private readonly Parameters.UpdateWebsite _params;
        private readonly string _url;

        public UpdateWebsite(String huduBaseURL, string huduAPIKey, Parameters.UpdateWebsite parameters)
        {
            _apiKey = huduAPIKey;
            _url = huduBaseURL + "api/v1/websites/" + parameters.Id;
            _params = parameters;
        }

        public Website Execute()
        {
            var result = BaseReceiver<Website, Parameters.UpdateWebsite>.Update(
                url: _url,
                apiKey: _apiKey,
                parameters: _params
                );

            if (result == null)
            {
                throw new HttpRequestException("There was an error updating the Website");
            }

            return result;
        }
    }
}