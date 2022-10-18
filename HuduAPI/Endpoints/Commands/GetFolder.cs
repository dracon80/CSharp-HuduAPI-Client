using HuduAPI.Endpoints.Exceptions;
using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class GetFolder : ICommand<Folder>
    {
        private readonly string _apiKye;
        private readonly Parameters.ItemById _getParams;
        private readonly string _url;

        public GetFolder(String huduBaseURL, string huduAPIKey, Parameters.ItemById parameters)
        {
            _getParams = parameters ?? throw new ArgumentNullException("GetFolder parameters cannot be null"); ;
            _url = huduBaseURL + "api/v1/folders/" + parameters.ID;
            _apiKye = huduAPIKey;
        }

        public Folder Execute()
        {
            var result = BaseReceiver<FolderRoot, Parameters.ItemById>.Get(
                url: _url,
                apiKey: _apiKye
                );

            if (result == null)
            {
                throw new RecordNotFoundException("Folder ID: " + _getParams.ID + " was not found");
            }

            return result.Folder;
        }
    }
}