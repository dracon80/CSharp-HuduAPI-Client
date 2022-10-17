using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class CreateAssetPassword : ICommand<AssetPassword>
    {
        private readonly string _apiKey;
        private readonly Parameters.CreateAssetPassword _params;
        private readonly string _url;

        public CreateAssetPassword(String huduBaseURL, string huduAPIKey, Parameters.CreateAssetPassword parameters)
        {
            _apiKey = huduAPIKey;
            _params = parameters;
            _url = huduBaseURL + "api/v1/asset_passwords/";
        }

        public AssetPassword Execute()
        {
            var result = BaseReceiver<AssetPasswordRoot, Parameters.CreateAssetPassword>.Create(
                url: _url,
                apiKey: _apiKey,
                parameters: _params
                );

            if (result == null)
            {
                throw new HttpRequestException("There was an error creating the new Asset Password");
            }

            return result.AssetPassword;
        }
    }
}