using Microsoft.VisualStudio.TestTools.UnitTesting;
using HuduAPI.Endpoints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Tests
{
    [TestClass()]
    public class APIInfoEndpointTests
    {
        private IConfiguration _configuration;
        private APIInfoEndpoint _endpoint;

        public APIInfoEndpointTests()
        {
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<CompanyEndpointTests>();

            _configuration = builder.Build();
            _endpoint = new(_configuration["HuduAPIKey"], _configuration["HuduBaseURL"]);
        }

        [TestMethod()]
        public void GetTest()
        {
            APIInfo result = _endpoint.Get();

            Assert.AreEqual("2.1.5.17", result.Version);
        }
    }
}