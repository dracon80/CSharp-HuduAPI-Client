using FakeItEasy;
using HuduAPI.Endpoints;
using HuduAPI.Endpoints.Parameters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.Extensions.Configuration;
using HuduAPI.Endpoints.Tests;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Tests
{
    [TestClass]
    public class ActivityLogsEndpointTests
    {
        private IConfiguration _configuration;
        private ActivityLogsEndpoint _endpoint;

        public ActivityLogsEndpointTests()
        {
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<CompaniesEndpointTests>();

            _configuration = builder.Build();
            _endpoint = new(_configuration["HuduAPIKey"], _configuration["HuduBaseURL"]);
        }

        [TestMethod()]
        public void GetAllActivityLogs()
        {
            //Get a list of companies from the endpoint and confirm that its not empy
            ActivityLogs logs = _endpoint.Get();

            Assert.AreNotEqual(0, logs.ActivityList.Count());
        }

        [TestMethod]
        public void GetFilteredActivytList()
        {
            GetActivityLogs filter = new GetActivityLogsBuilder().WithPageSize(20).Build();

            ActivityLogs logs = _endpoint.Get(filter);

            Assert.AreEqual(20, logs.ActivityList.Count());
        }
    }
}