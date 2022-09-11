using HuduAPI.Endpoints.Exceptions;
using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class GetActivityLogs : ICommand<ActivityLogs>
    {
        private readonly string _apiKey;
        private readonly Parameters.GetActivityLogs _getParams;
        private readonly string _url;

        public GetActivityLogs(String huduBaseURL, string huduAPIKey, Parameters.GetActivityLogs getParams)
        {
            //Its ok to have a null set of parameters
            _getParams = getParams;
            _url = huduBaseURL + "api/v1/activity_logs";
            _apiKey = huduAPIKey;
        }

        public ActivityLogs Execute()
        {
            var result = BaseReceiver<ActivityLog, Parameters.GetActivityLogs>.GetList(
                url: _url,
                apiKey: _apiKey,
                _getParams
                );

            if (result == null)
            {
                throw new RecordNotFoundException("No Activity Logs were returned");
            }

            return new ActivityLogs(result);
        }
    }
}