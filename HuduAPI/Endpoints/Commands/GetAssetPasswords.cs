using HuduAPI.Endpoints.Exceptions;
using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class GetAssetPasswords : ICommand<AssetPasswords>
    {
        private readonly string _apiKey;
        private readonly Parameters.GetAssetPasswords _getParams;
        private readonly string _url;

        public GetAssetPasswords(String huduBaseURL, string huduAPIKey, Parameters.GetAssetPasswords parameters)
        {
            _getParams = parameters;
            _url = huduBaseURL + "api/v1/asset_passwords/";
            _apiKey = huduAPIKey;
        }

        public AssetPasswords Execute()
        {
            var result = BaseReceiver<AssetPasswords, Parameters.GetAssetPasswords>.Get(
                url: _url,
                apiKey: _apiKey,
                _getParams
                );

            if (result == null)
            {
                throw new RecordNotFoundException("No Asset Passwords were found that match the parameters");
            }

            return result;
        }
    }
}