using Microsoft.VisualStudio.TestTools.UnitTesting;
using HuduAPI.Records;
using Microsoft.Extensions.Configuration;
using HuduAPI.Endpoints.Parameters;
using HuduAPI.Endpoints.Exceptions;

namespace HuduAPI.Endpoints.Tests
{
    [TestClass()]
    public class MagicDashEndpointTests
    {
        /// <summary>
        /// The company identifier that will be used to run all tests.
        /// </summary>
        private int _companyID = 7;

        private MagicDashEndpoint _endpoint;

        public MagicDashEndpointTests()
        {
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<MagicDashEndpointTests>();

            _configuration = builder.Build();
            _endpoint = new MagicDashEndpoint(_configuration["HuduAPIKey"], _configuration["HuduBaseURL"]);
        }

        private IConfiguration _configuration { get; set; }

        [TestMethod]
        public void CreateUpdateDeleteGlobalMagicDash()
        {
            string title = "New Test MagicDash";
            string companyName = "Integrated Solutions QLD Pty Ltd";
            string message = "New MagicDash Description";
            string icon = "fas fa-circle";
            string shade = "danger";
            string content = "https://google.com.au/";

            CreateMagicDash myparams = new CreateMagicDashBuilder(title, companyName, message)
                .WithIcon(icon)
                .WithShade(shade)
                .WithContentLink(content)
                .Build();

            MagicDash result = _endpoint.Create(myparams);

            Assert.AreEqual(title, result.Title);
            Assert.AreEqual(companyName, result.CompanyName);
            Assert.AreEqual(message, result.Message);
            Assert.AreEqual(icon, result.Icon);
            Assert.AreEqual(shade, result.Shade);
            Assert.AreEqual(content, result.ContentLink);

            //Now update the MagicDash with some new information
            title = "New Test MagicDash";
            companyName = "Integrated Solutions QLD Pty Ltd";
            message = "Updated MagicDash Message";
            icon = "fas fa-circle";
            shade = "success";
            content = "https://google.com.au/";

            myparams = new CreateMagicDashBuilder(title, companyName, message)
                .WithIcon(icon)
                .WithShade(shade)
                .WithContentLink(content)
                .Build();

            result = _endpoint.Create(myparams);

            Assert.AreEqual(title, result.Title);
            Assert.AreEqual(companyName, result.CompanyName);
            Assert.AreEqual(message, result.Message);
            Assert.AreEqual(icon, result.Icon);
            Assert.AreEqual(shade, result.Shade);
            Assert.AreEqual(content, result.ContentLink);

            ItemById item = new(result.ID);

            //Clean Up created MagicDash
            _endpoint.Delete(item);
        }

        [TestMethod]
        public void GetAllMagicDashs()
        {
            MagicDashes result = _endpoint.Get();
            Assert.IsNotNull(result);
            Assert.AreNotEqual(0, result.MagicDashList.Count);
        }

        [TestMethod]
        public void GetFilteredMagicDashs()
        {
            GetMagicDash myparams = new GetMagicDashBuilder()
                .WithCompanyId(_companyID)
                .Build();

            MagicDashes result = _endpoint.Get(myparams);

            foreach (var m in result.MagicDashList)
            {
                Assert.AreEqual(_companyID, m.CompanyID, "Filtered list contains records from another company");
            }
        }

        [TestMethod]
        public void GetInvalidMagicDash()
        {
            GetMagicDash myparams = new GetMagicDashBuilder()
                .WithCompanyId(24532)
                .Build();

            MagicDashes result = _endpoint.Get(myparams);

            //There should be no results
            Assert.AreEqual(0, result.MagicDashList.Count);
        }
    }
}