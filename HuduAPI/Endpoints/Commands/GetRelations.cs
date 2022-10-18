using HuduAPI.Endpoints.Exceptions;
using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class GetRelations : ICommand<Relations>
    {
        private readonly string _apiKey;
        private readonly Parameters.GetRelations _getParams;
        private readonly string _url;

        public GetRelations(String huduBaseURL, string huduAPIKey, Parameters.GetRelations parameters)
        {
            _getParams = parameters ?? new Parameters.GetRelations();
            _url = huduBaseURL + "api/v1/relations";
            _apiKey = huduAPIKey;
        }

        public Relations Execute()
        {
            var result = BaseReceiver<Relations, Parameters.GetRelations>.Get(
                url: _url,
                apiKey: _apiKey,
                _getParams
                );

            if (result == null)
            {
                throw new RecordNotFoundException("No Relations were found that match the parameters");
            }

            return result;
        }
    }
}