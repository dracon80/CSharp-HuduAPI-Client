using HuduAPI.Endpoints.Parameters;
using HuduAPI.Records;
using System.Runtime.InteropServices;

namespace HuduAPI.Endpoints
{
    /// <summary>
    /// Provides all the methods required to make calls to the activity_logs endpoint of the Hudu API.
    /// </summary>
    /// <remarks>
    /// The activity_logs endpoint is a read only interface that retrives a list of acticity logs
    /// representing user activity on the Hudu server. Filtering can be applied to help narrow down
    /// the returned ActivityLog Objects.
    /// </remarks>
    public class ActivityLogsEndpoint : IEndpoint, IEndpointGetMethod<ActivityLogs, Parameters.GetActivityLogs>
    {
        /// <summary>
        /// Gets or sets the hudu API key that will be used for all calls to this Endpoint.
        /// </summary>
        /// <value>
        /// The hudu API key.
        /// </value>
        public string HuduAPIKey { get; set; }

        /// <summary>
        /// Gets or sets the hudu base URL that will be used for all calls to the Endpoint.
        /// </summary>
        /// <value>
        /// The hudu base URL.
        /// </value>
        public string HuduBaseURL { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityLogsEndpoint" /> class with the
        /// requried API Key and the base URL of the Hudu Server.
        /// </summary>
        /// <param name="huduAPIKey">
        /// The hudu API key.
        /// </param>
        /// <param name="huduBaseURL">
        /// The hudu base URL.
        /// </param>
        public ActivityLogsEndpoint(string huduAPIKey, string huduBaseURL)
        {
            this.HuduAPIKey = huduAPIKey;
            this.HuduBaseURL = huduBaseURL;

            //Congifure the json serializer if it hasn't already been configured. Its safe to call this multiple times.
            Configuration.ConfigFurlSerializer();
        }

        /// <summary>
        /// Will make a call to the Hudu API activity_logs endpoint.
        /// </summary>
        /// <remarks>
        /// It is acceptable to cal the method with no paramaters, in which case all activity logs
        /// will be returnedd
        /// </remarks>
        /// <param name="parameters">
        /// The parameters to be used for filtering the activity logs that will be returned.
        /// </param>
        /// <returns>
        /// Returns an ActivityLogs object with all the activities that matached the filtering paramaters.
        /// </returns>
        public ActivityLogs Get([Optional] GetActivityLogs parameters)
        {
            Commands.GetActivityLogs command = new(this.HuduBaseURL, this.HuduAPIKey, parameters);

            return command.Execute();
        }
    }
}