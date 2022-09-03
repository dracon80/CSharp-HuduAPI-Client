using HuduAPI.Endpoints.Exceptions;
using HuduAPI.Endpoints.Parameters;
using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints.Commands
{
    internal class GetActivityLogs : ICommand<ActivityLogs>
    {
        private readonly Parameters.GetActivityLogs _getParams;
        private readonly string _url;
        private readonly string _apiKey;

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