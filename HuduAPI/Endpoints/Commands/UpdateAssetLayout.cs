using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class UpdateAssetLayout : ICommand<AssetLayout>
    {
        private readonly string _apiKey;
        private readonly Parameters.UpdateAssetLayout _params;
        private readonly string _url;

        public UpdateAssetLayout(String huduBaseURL, string huduAPIKey, Parameters.UpdateAssetLayout parameters)
        {
            _apiKey = huduAPIKey;
            _params = parameters;
            _url = huduBaseURL + "api/v1/asset_layouts";
        }

        public AssetLayout Execute()
        {
            var result = BaseReceiver<AssetLayoutRoot, Parameters.UpdateAssetLayout>.Update(
                url: _url,
                apiKey: _apiKey,
                parameters: _params
                );

            if (result == null)
            {
                throw new HttpRequestException("There was an error updating the AssetLayout");
            }

            return result.AssetLayout;
        }
    }
}