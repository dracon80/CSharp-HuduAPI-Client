using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class UpdateFolder : ICommand<Folder>
    {
        private readonly string _apiKey;
        private readonly Parameters.UpdateFolder _params;
        private readonly string _url;

        public UpdateFolder(String huduBaseURL, string huduAPIKey, Parameters.UpdateFolder parameters)
        {
            _apiKey = huduAPIKey;
            _url = huduBaseURL + "api/v1/folders/" + parameters.Id;
            _params = parameters;
        }

        public Folder Execute()
        {
            var result = BaseReceiver<FolderRoot, Parameters.UpdateFolder>.Update(
                url: _url,
                apiKey: _apiKey,
                parameters: _params
                );

            if (result == null)
            {
                throw new HttpRequestException("There was an error updating the Folder");
            }

            return result.Folder;
        }
    }
}