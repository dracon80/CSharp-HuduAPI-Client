using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class CreateRelation : ICommand<Relation>
    {
        private readonly string _apiKey;
        private readonly Parameters.CreateRelation _params;
        private readonly string _url;

        public CreateRelation(String huduBaseURL, string huduAPIKey, Parameters.CreateRelation parameters)
        {
            _apiKey = huduAPIKey;
            _params = parameters;
            _url = huduBaseURL + "api/v1/relations/";
        }

        public Relation Execute()
        {
            var result = BaseReceiver<RelationRoot, Parameters.CreateRelation>.Create(
                url: _url,
                apiKey: _apiKey,
                parameters: _params
                );

            if (result == null)
            {
                throw new HttpRequestException("There was an error creating the new Relation");
            }

            return result.Relation;
        }
    }
}