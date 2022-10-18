using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class UpdateAsset : ICommand<Asset>
    {
        private readonly string _apiKey;
        private readonly Parameters.UpdateAsset _params;
        private readonly string _url;

        public UpdateAsset(String huduBaseURL, string huduAPIKey, Parameters.UpdateAsset parameters)
        {
            _apiKey = huduAPIKey;
            _url = huduBaseURL + "api/v1/companies/" + parameters.CompanyId + "/assets/" + parameters.AssetId;
            _params = parameters;
        }

        public Asset Execute()
        {
            var result = BaseReceiver<AssetRoot, Parameters.UpdateAsset>.Update(
                url: _url,
                apiKey: _apiKey,
                parameters: _params
                );

            if (result == null)
            {
                throw new HttpRequestException("There was an error updating the Asset");
            }

            return result.Asset;
        }
    }
}