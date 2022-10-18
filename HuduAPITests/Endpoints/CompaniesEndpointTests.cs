using Microsoft.VisualStudio.TestTools.UnitTesting;
using HuduAPI.Records;
using Microsoft.Extensions.Configuration;
using HuduAPI.Endpoints.Parameters;
using HuduAPI.Endpoints.Exceptions;

namespace HuduAPI.Endpoints.Tests
{
    [TestClass()]
    public class CompaniesEndpointTests
    {
        /// <summary>
        /// The company identifier that will be used to run all tests.
        /// </summary>
        private int _companyID = 7;

        /// <summary>
        /// The company name that is expected when getting a record
        /// </summary>
        private string _companyName = "Integrated Solutions QLD Pty Ltd";

        private CompaniesEndpoint _endpoint;

        public CompaniesEndpointTests()
        {
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<CompaniesEndpointTests>();

            _configuration = builder.Build();
            _endpoint = new CompaniesEndpoint(_configuration["HuduAPIKey"], _configuration["HuduBaseURL"]);
        }

        private IConfiguration _configuration { get; set; }

        [TestMethod]
        public void CreateUpdateDelete_ok()
        {
            string name = "New Company";
            string city = "Test City";
            string state = "New State";
            string country = "New Country";
            string website = "https://www.na.com/";
            string notes = "Lots of test notes";

            CreateCompany myparam = new CreateCompanyBuilder(name)
                .WithCity(city)
                .WithState(state)
                .WithCountryName(country)
                .WithWebsite(website)
                .WithNotes(notes)
                .Build();

            Company result = _endpoint.Create(myparam);

            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(city, result.City);
            Assert.AreEqual(state, result.State);
            Assert.AreEqual(country, result.CountryName);
            Assert.AreEqual(website, result.Website);
            Assert.AreEqual(notes, result.Notes);

            ItemById item = new ItemById(result.ID);

            //Update the company with new data.
            name = "Updated Company Name";
            string company_type = "MSP Proactive Client";
            string address1 = "Address Line 1";
            string address2 = "Address Line 2";

            UpdateCompany updateparam = new UpdateCompanyBuilder(result.ID, name)
                .WithAddressLine1(address1)
                .WithAddressLine2(address2)
                .WithCompanyType(company_type)
                .Build();

            result = _endpoint.Update(updateparam);

            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(city, result.City);
            Assert.AreEqual(state, result.State);
            Assert.AreEqual(country, result.CountryName);
            Assert.AreEqual(website, result.Website);
            Assert.AreEqual(notes, result.Notes);
            Assert.AreEqual(company_type, result.CompanyType);
            Assert.AreEqual(address1, result.AddressLine1);
            Assert.AreEqual(address2, result.AddressLine2);

            //Now Archive and Unarchive the Company
            result = _endpoint.Archive(item, true);
            Assert.IsTrue(result.Archived);

            result = _endpoint.Archive(item, false);
            Assert.IsFalse(result.Archived);

            //Cleanup and delete the created company
            _endpoint.Delete(item);
        }

        [TestMethod()]
        public void GetAllCompanies()
        {
            //Get a list of companies from the endpoint and confirm that its not empy
            Companies companies = _endpoint.Get();

            Assert.AreNotEqual(0, companies.CompanyList.Count());
        }

        [TestMethod()]
        public void GetCompany()
        {
            ItemById myparams = new(id: _companyID);

            Company result = _endpoint.Get(myparams);

            Assert.AreEqual(_companyID, result.ID);
            Assert.AreEqual(_companyName, result.Name);
            Assert.AreEqual("PARRAMATTA PARK", result.City);
            Assert.AreEqual("MSP Proactive Client", result.CompanyType);
            Assert.AreEqual("www.i-solutions.net.au", result.Website);
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

        [TestMethod]
        public void GetInvalidCompany()
        {
            ItemById myparams = new(id: 4856734);

            Assert.ThrowsException<RecordNotFoundException>(
                     () => _endpoint.Get(myparams)
                );
        }

        [TestMethod]
        public void GetNegativeCompanyID()
        {
            ItemById myparams;

            Assert.ThrowsException<ArgumentOutOfRangeException>(
                     () => myparams = new(id: -3)
                );
        }
    }
}