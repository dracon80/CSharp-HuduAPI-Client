using HuduAPI.Endpoints.Exceptions;
using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class GetAssetPassword : ICommand<AssetPassword>
    {
        private readonly string _apiKey;
        private readonly Parameters.ItemById _getParams;
        private readonly string _url;

        public GetAssetPassword(String huduBaseURL, string huduAPIKey, Parameters.ItemById parameters)
        {
            _getParams = parameters;
            _url = huduBaseURL + "api/v1/asset_passwords/" + parameters.ID;
            _apiKey = huduAPIKey;
        }

        public AssetPassword Execute()
        {
            var result = BaseReceiver<AssetPasswordRoot, Parameters.ItemById>.Get(
                url: _url,
                apiKey: _apiKey
                );

            if (result == null)
            {
                throw new RecordNotFoundException("AssetPassword ID: " + _getParams.ID + " was not found");
            }

            return result.AssetPassword;
        }
    }
}