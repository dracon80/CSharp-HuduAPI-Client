using HuduAPI.Endpoints.Exceptions;
using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class GetWebsites : ICommand<Websites>
    {
        private readonly string _apiKey;
        private readonly Parameters.GetWebsites _getParams;
        private readonly string _url;

        public GetWebsites(String huduBaseURL, string huduAPIKey, Parameters.GetWebsites parameters)
        {
            _getParams = parameters ?? new Parameters.GetWebsites();
            _url = huduBaseURL + "api/v1/websites";
            _apiKey = huduAPIKey;
        }

        public Websites Execute()
        {
            var result = BaseReceiver<Website, Parameters.GetWebsites>.GetList(
                url: _url,
                apiKey: _apiKey,
                _getParams
                );

            if (result == null)
            {
                throw new RecordNotFoundException("No Websites were found that match the parameters");
            }

            Websites websites = new();
            websites.WebsiteList = result;

            return websites;
        }
    }
}