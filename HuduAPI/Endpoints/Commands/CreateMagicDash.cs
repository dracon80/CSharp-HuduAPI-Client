using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class CreateMagicDash : ICommand<MagicDash>
    {
        private readonly string _apiKey;
        private readonly Parameters.CreateMagicDash _params;
        private readonly string _url;

        public CreateMagicDash(String huduBaseURL, string huduAPIKey, Parameters.CreateMagicDash parameters)
        {
            _apiKey = huduAPIKey;
            _params = parameters;
            _url = huduBaseURL + "api/v1/magic_dash/";
        }

        public MagicDash Execute()
        {
            var result = BaseReceiver<MagicDash, Parameters.CreateMagicDash>.Create(
                url: _url,
                apiKey: _apiKey,
                parameters: _params
                );

            if (result == null)
            {
                throw new HttpRequestException("There was an error creating or updating the MagicDash");
            }

            return result;
        }
    }
}