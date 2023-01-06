using Flurl.Http;
using HuduAPI.Endpoints.Exceptions;
using HuduAPI.Endpoints.Parameters;
using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;
using Newtonsoft.Json;
using System;

namespace HuduAPI.Endpoints.Commands
{
    internal class DeleteMagicDash : ICommand
    {
        private readonly string _apiKey;
        private readonly Parameters.ItemById _params;
        private readonly string _url;

        public DeleteMagicDash(String huduBaseURL, string huduAPIKey, Parameters.ItemById parameters)
        {
            _params = parameters ?? throw new ArgumentNullException("DeleteMagicDash parameters cannot be null");
            _url = huduBaseURL + "api/v1/magic_dash/" + _params.ID;
            _apiKey = huduAPIKey;
        }

        public void Execute()
        {
            var result = _url.WithHeader("x-api-key", _apiKey).DeleteAsync().Result;

            return;
        }
    }

    internal class DeleteMagicDashNoID : ICommand
    {
        private readonly string _apiKey;
        private readonly Parameters.DeleteMagicDash _params;
        private readonly string _url;

        public DeleteMagicDashNoID(String huduBaseURL, string huduAPIKey, Parameters.DeleteMagicDash parameters)
        {
            _params = parameters ?? throw new ArgumentNullException("DeleteMagicDash parameters cannot be null");
            _url = huduBaseURL + "api/v1/magic_dash/";
            _apiKey = huduAPIKey;
        }

        public void Execute()
        {
            var json = JsonConvert.SerializeObject(_params.GetPropertyDictionary());

            try
            {
                var result = _url.WithHeader("x-api-key", _apiKey).SendJsonAsync(HttpMethod.Delete, _params.GetPropertyDictionary()).Result;

                return;
            }
            catch (Exception ex)
            {
                if (ex.InnerException is FlurlHttpException)
                {
                    FlurlHttpException inner = (FlurlHttpException)ex.InnerException;
                    string response = inner.GetResponseStringAsync().Result;

                    throw new FlurlHttpException(inner.Call, response, inner);
                }
                else
                {
                    throw;
                }
            }
        }
    }
}