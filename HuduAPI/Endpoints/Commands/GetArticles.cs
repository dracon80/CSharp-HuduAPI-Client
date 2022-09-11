using HuduAPI.Endpoints.Exceptions;
using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class GetArticles : ICommand<Articles>
    {
        private readonly string _apiKey;
        private readonly Parameters.GetArticles _getParams;
        private readonly string _url;

        public GetArticles(String huduBaseURL, string huduAPIKey, Parameters.GetArticles parameters)
        {
            _getParams = parameters ?? new Parameters.GetArticles();
            _url = huduBaseURL + "api/v1/articles";
            _apiKey = huduAPIKey;
        }

        public Articles Execute()
        {
            var result = BaseReceiver<Articles, Parameters.GetArticles>.Get(
                url: _url,
                apiKey: _apiKey,
                _getParams
                );

            if (result == null)
            {
                throw new RecordNotFoundException("No Articles were found that match the parameters");
            }

            return result;
        }
    }
}