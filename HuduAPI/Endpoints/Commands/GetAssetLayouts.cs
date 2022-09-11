using HuduAPI.Endpoints.Exceptions;
using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    /// <summary>
    /// Command to get a list of assetlayouts
    /// </summary>
    internal class GetAssetLayouts : ICommand<AssetLayouts>
    {
        private readonly string _apiKey;
        private readonly Parameters.GetAssetLayouts _getParams;
        private readonly string _url;

        public GetAssetLayouts(String huduBaseURL, string huduAPIKey, Parameters.GetAssetLayouts parameters)
        {
            _getParams = parameters;
            _url = huduBaseURL + "api/v1/asset_layouts";
            _apiKey = huduAPIKey;
        }

        public AssetLayouts Execute()
        {
            var result = BaseReceiver<AssetLayouts, Parameters.GetAssetLayouts>.Get(
                url: _url,
                apiKey: _apiKey,
                _getParams
                );

            if (result == null)
            {
                throw new RecordNotFoundException("No AssetLayouts were found that match the parameters");
            }

            return result;
        }
    }
}