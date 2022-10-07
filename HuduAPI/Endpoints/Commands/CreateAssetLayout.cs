using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class CreateAssetLayout : ICommand<AssetLayout>
    {
        private readonly string _apiKey;
        private readonly Parameters.CreateAssetLayout _params;
        private readonly string _url;

        public CreateAssetLayout(String huduBaseURL, string huduAPIKey, Parameters.CreateAssetLayout parameters)
        {
            _apiKey = huduAPIKey;
            _params = parameters;
            _url = huduBaseURL + "api/v1/asset_layouts";
        }

        public AssetLayout Execute()
        {
            var result = BaseReceiver<AssetLayoutRoot, Parameters.CreateAssetLayout>.Create(
                url: _url,
                apiKey: _apiKey,
                parameters: _params
                );

            if (result == null)
            {
                throw new HttpRequestException("There was an error creating the new AssetLayout");
            }

            return result.AssetLayout;
        }
    }
}