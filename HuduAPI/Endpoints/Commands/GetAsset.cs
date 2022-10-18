using HuduAPI.Endpoints.Exceptions;
using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class GetAsset : ICommand<Asset>
    {
        private readonly string _apiKye;
        private readonly Parameters.AssetById _getParams;
        private readonly string _url;

        public GetAsset(String huduBaseURL, string huduAPIKey, Parameters.AssetById parameters)
        {
            _getParams = parameters ?? throw new ArgumentNullException("GetAsset parameters cannot be null"); ;
            _url = huduBaseURL + "api/v1/companies/" + parameters.CompanyId + "/assets/" + parameters.ID;
            _apiKye = huduAPIKey;
        }

        public Asset Execute()
        {
            var result = BaseReceiver<AssetRoot, Parameters.AssetById>.Get(
                url: _url,
                apiKey: _apiKye
                );

            if (result == null)
            {
                throw new RecordNotFoundException("Asset ID: " + _getParams.ID + " was not found");
            }

            return result.Asset;
        }
    }
}