using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class CreateAsset : ICommand<Asset>
    {
        private readonly string _apiKey;
        private readonly Parameters.CreateAsset _params;
        private readonly string _url;

        public CreateAsset(String huduBaseURL, string huduAPIKey, Parameters.CreateAsset parameters)
        {
            _apiKey = huduAPIKey;
            _params = parameters;
            _url = huduBaseURL + "api/v1/companies/" + parameters.CompanyId + "/assets";
        }

        public Asset Execute()
        {
            var result = BaseReceiver<AssetRoot, Parameters.CreateAsset>.Create(
                url: _url,
                apiKey: _apiKey,
                parameters: _params
                );

            if (result == null)
            {
                throw new HttpRequestException("There was an error creating the new Asset");
            }

            return result.Asset;
        }
    }
}