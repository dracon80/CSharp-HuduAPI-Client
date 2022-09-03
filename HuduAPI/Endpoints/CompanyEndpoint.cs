using HuduAPI.Records;
using System.Runtime.InteropServices;

namespace HuduAPI.Endpoints
{
    public class CompanyEndpoint : IEndpoint,
        IEndpointGetMethod<Company, Parameters.GetCompany>,
        IEndpointGetMethod<Companies, Parameters.GetCompanies>

    {
        public string HuduAPIKey { get; set; }
        public string HuduBaseURL { get; set; }

        public CompanyEndpoint(string huduAPIKey, string huduBaseURL)
        {
            this.HuduAPIKey = huduAPIKey;
            this.HuduBaseURL = huduBaseURL;
            Configuration.ConfigFurlSerializer();
        }

        public Company Get(Parameters.GetCompany parameters)
        {
            Commands.GetCompany myCommand = new Commands.GetCompany(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }

        public Companies Get([Optional] Parameters.GetCompanies parameters)
        {
            Commands.GetCompanies myCommand = new Commands.GetCompanies(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);

            return myCommand.Execute();
        }
    }
}