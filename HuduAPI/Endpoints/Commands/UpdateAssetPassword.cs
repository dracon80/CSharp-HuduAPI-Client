using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class UpdateAssetPassword : ICommand<AssetPassword>
    {
        private readonly string _apiKey;
        private readonly Parameters.UpdateAssetPassword _params;
        private readonly string _url;

        public UpdateAssetPassword(String huduBaseURL, string huduAPIKey, Parameters.UpdateAssetPassword parameters)
        {
            _apiKey = huduAPIKey;
            _url = huduBaseURL + "api/v1/asset_passwords/" + parameters.Id;
            _params = parameters;
        }

        public AssetPassword Execute()
        {
            var result = BaseReceiver<AssetPasswordRoot, Parameters.UpdateAssetPassword>.Update(
                url: _url,
                apiKey: _apiKey,
                parameters: _params
                );

            if (result == null)
            {
                throw new HttpRequestException("There was an error updating the new AssetPassword");
            }

            return result.AssetPassword;
        }
    }
}