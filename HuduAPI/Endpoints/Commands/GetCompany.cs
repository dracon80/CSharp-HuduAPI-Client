using HuduAPI.Endpoints.Exceptions;
using HuduAPI.Endpoints.Parameters;
using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints.Commands
{
    internal class GetCompany : ICommand<Company>
    {
        private readonly EndpointParameters<GetCompanyParameters> _getParams;
        private readonly string _url;

        public GetCompany(EndpointParameters<GetCompanyParameters> getParameters)
        {
            _getParams = getParameters;
            _url = getParameters.HuduBaseURL + "api/v1/companies/" + getParameters.Parameters.ID;
        }

        public Company Execute()
        {
            //Because the API returns a complex object with a Companies element wrapped arounnd the
            //Company we need to retreive a companies object and then extract the first item.
            var result = BaseReceiver<CompanyRoot, GetCompanyParameters>.Get(
                url: _url,
                apiKey: _getParams.HuduAPIKey
                );

            if (result == null)
            {
                throw new RecordNotFoundException("Company ID: " + _getParams.Parameters.ID + " was not found");
            }

            return result.Company;
        }
    }
}