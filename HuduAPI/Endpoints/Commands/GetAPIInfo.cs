using HuduAPI.Endpoints.Exceptions;
using HuduAPI.Endpoints.Parameters;
using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class GetAPIInfo : ICommand<APIInfo>
    {
        private readonly string _apiKey;
        private readonly string _url;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAPIInfo" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL.
        /// </param>
        /// <param name="apiKey">
        /// The API key.
        /// </param>
        public GetAPIInfo(string url, string apiKey)
        {
            _url = url + "api/v1/api_info";
            _apiKey = apiKey;
        }

        public APIInfo Execute()
        {
            var result = BaseReceiver<APIInfo, IParameters>.Get(
                url: _url,
                apiKey: _apiKey
                );

            if (result == null)
            {
                throw new RecordNotFoundException("No API Info was returned");
            }

            return result;
        }
    }
}