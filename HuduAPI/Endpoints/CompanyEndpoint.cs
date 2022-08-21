using Flurl.Http;
using HuduAPI.Endpoints.Commands;
using HuduAPI.Endpoints.Parameters;
using HuduAPI.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints
{
    public class CompanyEndpoint : IEndpoint,
        IEndpointGetMethod<Company, GetCompanyParameters>,
        IEndpointGetMethod<Companies, GetCompaniesParameters>

    {
        public string HuduAPIKey { get; set; }
        public string HuduBaseURL { get; set; }

        public CompanyEndpoint(string huduAPIKey, string huduBaseURL)
        {
            this.HuduAPIKey = huduAPIKey;
            this.HuduBaseURL = huduBaseURL;
            Configuration.ConfigFurlSerializer();
        }

        public Company Get(GetCompanyParameters parameters)
        {
            EndpointParameters<GetCompanyParameters> endpointParameter = new EndpointParameters<GetCompanyParameters>(huduAPIKey: this.HuduAPIKey,
                huduBaseURL: this.HuduBaseURL, parameters);

            GetCompany myCommand = new GetCompany(endpointParameter);

            return myCommand.Execute();
        }

        public Companies Get([Optional] GetCompaniesParameters parameters)
        {
            EndpointParameters<GetCompaniesParameters> endpointParameter = new EndpointParameters<GetCompaniesParameters>(huduAPIKey: this.HuduAPIKey,
                huduBaseURL: this.HuduBaseURL, parameters);

            GetCompanies myCommand = new GetCompanies(endpointParameter);

            return myCommand.Execute();
        }
    }
}