using HuduAPI.Endpoints.Exceptions;
using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class GetFolders : ICommand<Folders>
    {
        private readonly string _apiKey;
        private readonly Parameters.GetFolders _getParams;
        private readonly string _url;

        public GetFolders(String huduBaseURL, string huduAPIKey, Parameters.GetFolders parameters)
        {
            _getParams = parameters ?? new Parameters.GetFolders();
            _url = huduBaseURL + "api/v1/folders";
            _apiKey = huduAPIKey;
        }

        public Folders Execute()
        {
            var result = BaseReceiver<Folders, Parameters.GetFolders>.Get(
                url: _url,
                apiKey: _apiKey,
                _getParams
                );

            if (result == null)
            {
                throw new RecordNotFoundException("No Folders were found that match the parameters");
            }

            return result;
        }
    }
}