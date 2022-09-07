using HuduAPI.Endpoints.Exceptions;
using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class GetAssetLayout : ICommand<AssetLayout>
    {
        private readonly string _apiKey;
        private readonly Parameters.GetAssetLayout _getParams;
        private readonly string _url;

        public GetAssetLayout(String huduBaseURL, string huduAPIKey, Parameters.GetAssetLayout parameters)
        {
            _getParams = parameters;
            _url = huduBaseURL + "api/v1/asset_layouts/" + parameters.ID;
            _apiKey = huduAPIKey;
        }

        public AssetLayout Execute()
        {
            var result = BaseReceiver<AssetLayoutRoot, Parameters.GetAssetLayout>.Get(
                url: _url,
                apiKey: _apiKey
                );

            if (result == null)
            {
                throw new RecordNotFoundException("AssetLayout ID: " + _getParams.ID + " was not found");
            }

            return result.AssetLayout;
        }
    }
}