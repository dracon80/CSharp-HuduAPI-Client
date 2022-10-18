using HuduAPI.Endpoints.Exceptions;
using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class GetMagicDash : ICommand<MagicDashes>
    {
        private readonly string _apiKey;
        private readonly Parameters.GetMagicDash _getParams;
        private readonly string _url;

        public GetMagicDash(String huduBaseURL, string huduAPIKey, Parameters.GetMagicDash parameters)
        {
            _getParams = parameters ?? new Parameters.GetMagicDash();
            _url = huduBaseURL + "api/v1/magic_dash";
            _apiKey = huduAPIKey;
        }

        public MagicDashes Execute()
        {
            var result = BaseReceiver<MagicDash, Parameters.GetMagicDash>.GetList(
                url: _url,
                apiKey: _apiKey,
                _getParams
                );

            if (result == null)
            {
                throw new RecordNotFoundException("No MagicDash were found that match the parameters");
            }

            MagicDashes magicDashes = new MagicDashes();
            magicDashes.MagicDashList = result;

            return magicDashes;
        }
    }
}