using HuduAPI.Endpoints.Exceptions;
using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class GetWebsite : ICommand<Website>
    {
        private readonly string _apiKye;
        private readonly Parameters.ItemById _getParams;
        private readonly string _url;

        public GetWebsite(String huduBaseURL, string huduAPIKey, Parameters.ItemById parameters)
        {
            _getParams = parameters ?? throw new ArgumentNullException("GetWebsite parameters cannot be null"); ;
            _url = huduBaseURL + "api/v1/websites/" + parameters.ID;
            _apiKye = huduAPIKey;
        }

        public Website Execute()
        {
            var result = BaseReceiver<Website, Parameters.ItemById>.Get(
                url: _url,
                apiKey: _apiKye
                );

            if (result == null)
            {
                throw new RecordNotFoundException("Website ID: " + _getParams.ID + " was not found");
            }

            return result;
        }
    }
}