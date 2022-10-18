using HuduAPI.Endpoints.Exceptions;
using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class GetProcedure : ICommand<Procedure>
    {
        private readonly string _apiKye;
        private readonly Parameters.ItemById _getParams;
        private readonly string _url;

        public GetProcedure(String huduBaseURL, string huduAPIKey, Parameters.ItemById parameters)
        {
            _getParams = parameters ?? throw new ArgumentNullException("GetProcedure parameters cannot be null"); ;
            _url = huduBaseURL + "api/v1/procedures/" + parameters.ID;
            _apiKye = huduAPIKey;
        }

        public Procedure Execute()
        {
            var result = BaseReceiver<ProcedureRoot, Parameters.ItemById>.Get(
                url: _url,
                apiKey: _apiKye
                );

            if (result == null)
            {
                throw new RecordNotFoundException("Procedure ID: " + _getParams.ID + " was not found");
            }

            return result.Procedure;
        }
    }
}