using Microsoft.VisualStudio.TestTools.UnitTesting;
using HuduAPI.Records;
using Microsoft.Extensions.Configuration;
using HuduAPI.Endpoints.Parameters;
using HuduAPI.Endpoints.Exceptions;

namespace HuduAPI.Endpoints.Tests
{
    [TestClass()]
    public class CompanyEndpointTests
    {
        private IConfiguration _configuration { get; set; }
        private CompanyEndpoint _endpoint;

        /// <summary>
        /// The company identifier that will be used to run all tests.
        /// </summary>
        private int _companyID = 7;

        /// <summary>
        /// The company name that is expected when getting a record
        /// </summary>
        private string _companyName = "Integrated Solutions QLD Pty Ltd";

        public CompanyEndpointTests()
        {
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<CompanyEndpointTests>();

            _configuration = builder.Build();
            _endpoint = new CompanyEndpoint(_configuration["HuduAPIKey"], _configuration["HuduBaseURL"]);
        }

        [TestMethod()]
        public void GetAllCompanies()
        {
            //Get a list of companies from the endpoint and confirm that its not empy
            Companies companies = _endpoint.Get();

            Assert.AreNotEqual(0, companies.CompanyList.Count());
        }

        [TestMethod()]
        public void GetFilteredCompanies()
        {
            GetCompanies parameters = new GetCompaniesBuilder().WithState("QLD").Build();

            //Get a list of companies from the endpoint and confirm that its not empy
            Companies companies = _endpoint.Get(parameters);

            Assert.AreNotEqual(0, companies.CompanyList.Count());

            foreach (Company c in companies.CompanyList)
            {
                //Check that all returned records are for state QLD
                Assert.AreEqual("QLD", c.State, "Results include companies with states other than QLD");
            }

            parameters = new GetCompaniesBuilder().WithName("Integrated Solutions QLD Pty Ltd").Build();

            //Get a list of companies from the endpoint and confirm that its not empy
            companies = _endpoint.Get(parameters);

            Assert.AreNotEqual(0, companies.CompanyList.Count());

            foreach (Company c in companies.CompanyList)
            {
                //Check that all returned records are for state QLD
                Assert.AreEqual("Integrated Solutions QLD Pty Ltd", c.Name, "Results include companies with invlid names");
            }
        }

        [TestMethod()]
        public void GetCompany()
        {
            GetCompany myparams = new(id: _companyID);

            Company result = _endpoint.Get(myparams);

            Assert.AreEqual(_companyID, result.ID);
            Assert.AreEqual(_companyName, result.Name);
        }

        [TestMethod]
        public void GetInvalidCompany()
        {
            GetCompany myparams = new(id: 4856734);

            Assert.ThrowsException<RecordNotFoundException>(
                     () => _endpoint.Get(myparams)
                );
        }

        [TestMethod]
        public void GetNegativeCompanyID()
        {
            GetCompany myparams;

            Assert.ThrowsException<ArgumentOutOfRangeException>(
                     () => myparams = new(id: -3)
                );
        }
    }
}