using Microsoft.VisualStudio.TestTools.UnitTesting;
using HuduAPI.Records;
using Microsoft.Extensions.Configuration;
using HuduAPI.Endpoints.Parameters;
using HuduAPI.Endpoints.Exceptions;

namespace HuduAPI.Endpoints.Tests
{
    [TestClass()]
    public class WebsitesEndpointTests
    {
        /// <summary>
        /// The company identifier that will be used to run all tests.
        /// </summary>
        private int _companyID = 7;

        private WebsitesEndpoint _endpoint;

        public WebsitesEndpointTests()
        {
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<WebsitesEndpointTests>();

            _configuration = builder.Build();
            _endpoint = new WebsitesEndpoint(_configuration["HuduAPIKey"], _configuration["HuduBaseURL"]);
        }

        private IConfiguration _configuration { get; set; }

        [TestMethod]
        public void CreateUpdateDeleteGlobalWebsite()
        {
            string name = "New Test Website";
            string notes = "New Website Notes";

            CreateWebsite myparams = new CreateWebsiteBuilder(name, _companyID)
                .WithDisableDns(true)
                .WithDisableSsl(false)
                .WithNotes(notes)
                .WithPaused(true)
                .Build();

            Website result = _endpoint.Create(myparams);

            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(notes, result.Notes);
            Assert.IsTrue(result.DisableDns);
            Assert.IsFalse(result.DisableSsl);
            Assert.IsTrue(result.Paused);

            name = "Updated Test Website";
            notes = "Updated Website Notes";
            //Now update the Website with some new information
            UpdateWebsite updateparams = new UpdateWebsiteBuilder(result.ID, name, _companyID)
                .WithDisableDns(false)
                .WithDisableSsl(false)
                .WithNotes(notes)
                .WithPaused(false)
                .Build();

            result = _endpoint.Update(updateparams);

            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(notes, result.Notes);
            Assert.IsFalse(result.DisableDns);
            Assert.IsFalse(result.DisableSsl);
            Assert.IsFalse(result.Paused);

            ItemById item = new(result.ID);

            //Clean Up created Website
            _endpoint.Delete(item);
        }

        [TestMethod]
        public void GetAllWebsites()
        {
            Websites Websites = _endpoint.Get();

            Assert.IsNotNull(Websites);
            Assert.AreNotEqual(0, Websites.WebsiteList.Count());
        }

        [TestMethod]
        public void GetFilteredWebsites()
        {
            GetWebsites paramaters = new GetWebsitesBuilder().WithPageSize(6).Build();
            Websites results = _endpoint.Get(paramaters);

            Assert.AreEqual(6, results.WebsiteList.Count());
        }

        [TestMethod]
        public void GetInvalidWebsite()
        {
            ItemById myparams = new(id: 4856734);

            Assert.ThrowsException<RecordNotFoundException>(
                     () => _endpoint.Get(myparams)
                );
        }

        [TestMethod]
        public void GetNegativeWebsiteID()
        {
            ItemById myparams;

            Assert.ThrowsException<ArgumentOutOfRangeException>(
                     () => myparams = new(id: -3)
                );
        }

        [TestMethod]
        public void GetWebsite()
        {
            int WebsiteID = 38;
            ItemById myparams = new(id: WebsiteID);

            Website Website = _endpoint.Get(myparams);

            Assert.IsNotNull(Website);
            Assert.AreEqual(_companyID, Website.CompanyID);
            Assert.AreEqual(WebsiteID, Website.ID);
            Assert.AreEqual(Website.Name, "https://sharepoint.i-solutions.net.au");
        }
    }
}