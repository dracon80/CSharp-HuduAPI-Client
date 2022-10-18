using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class CreateWebsite : ICommand<Website>
    {
        private readonly string _apiKey;
        private readonly Parameters.CreateWebsite _params;
        private readonly string _url;

        public CreateWebsite(String huduBaseURL, string huduAPIKey, Parameters.CreateWebsite parameters)
        {
            _apiKey = huduAPIKey;
            _params = parameters;
            _url = huduBaseURL + "api/v1/websites/";
        }

        public Website Execute()
        {
            var result = BaseReceiver<Website, Parameters.CreateWebsite>.Create(
                url: _url,
                apiKey: _apiKey,
                parameters: _params
                );

            if (result == null)
            {
                throw new HttpRequestException("There was an error creating the new Website");
            }

            return result;
        }
    }
}