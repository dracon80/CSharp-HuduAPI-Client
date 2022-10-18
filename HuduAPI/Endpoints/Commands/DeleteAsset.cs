using Flurl.Http;
using HuduAPI.Endpoints.Exceptions;
using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;
using System;

namespace HuduAPI.Endpoints.Commands
{
    internal class DeleteAsset : ICommand
    {
        private readonly string _apiKey;
        private readonly Parameters.AssetById _params;
        private readonly string _url;

        public DeleteAsset(String huduBaseURL, string huduAPIKey, Parameters.AssetById parameters)
        {
            _params = parameters ?? throw new ArgumentNullException("DeleteAsset parameters cannot be null");
            _url = huduBaseURL + "api/v1/companies/" + _params.CompanyId + "/assets/" + _params.ID;
            _apiKey = huduAPIKey;
        }

        public void Execute()
        {
            var result = _url.WithHeader("x-api-key", _apiKey).DeleteAsync().Result;

            return;
        }
    }
}