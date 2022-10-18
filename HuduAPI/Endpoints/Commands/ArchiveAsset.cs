using HuduAPI.Endpoints.Exceptions;
using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class ArchiveAsset : ICommand<Asset>
    {
        private readonly string _apiKey;
        private readonly Parameters.AssetById _params;
        private readonly string _url;

        public ArchiveAsset(String huduBaseURL, string huduAPIKey, Parameters.AssetById parameters, Boolean archive)
        {
            _params = parameters ?? throw new ArgumentNullException("ArchiveAsset parameters cannot be null");
            if (archive)
            {
                _url = huduBaseURL + "api/v1/companies/" + _params.CompanyId + "/assets/" + _params.ID + "/archive";
            }
            else
            {
                _url = huduBaseURL + "api/v1/companies/" + _params.CompanyId + "/assets/" + _params.ID + "/unarchive";
            }

            _apiKey = huduAPIKey;
        }

        public Asset Execute()
        {
            var result = BaseReceiver<AssetRoot, Parameters.ItemById>.Archive(
                url: _url,
                apiKey: _apiKey
                );

            if (result == null)
            {
                throw new RecordNotFoundException("Asset ID: " + _params.ID + " was not found");
            }

            return result.Asset;
        }
    }
}