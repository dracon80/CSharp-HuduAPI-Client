using HuduAPI.Endpoints.Exceptions;
using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class GetProcedures : ICommand<Procedures>
    {
        private readonly string _apiKey;
        private readonly Parameters.GetProcedures _getParams;
        private readonly string _url;

        public GetProcedures(String huduBaseURL, string huduAPIKey, Parameters.GetProcedures parameters)
        {
            _getParams = parameters ?? new Parameters.GetProcedures();
            _url = huduBaseURL + "api/v1/procedures";
            _apiKey = huduAPIKey;
        }

        public Procedures Execute()
        {
            var result = BaseReceiver<Procedures, Parameters.GetProcedures>.Get(
                url: _url,
                apiKey: _apiKey,
                _getParams
                );

            if (result == null)
            {
                throw new RecordNotFoundException("No Procedures were found that match the parameters");
            }

            return result;
        }
    }
}