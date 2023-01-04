using Microsoft.VisualStudio.TestTools.UnitTesting;
using HuduAPI.Records;
using Microsoft.Extensions.Configuration;
using HuduAPI.Endpoints.Parameters;
using HuduAPI.Endpoints.Exceptions;
using Flurl.Http;

namespace HuduAPI.Endpoints.Tests
{
    [TestClass()]
    public class MatchersEndpointTests
    {
        private int _cwCompanyID = 258;
        private MatchersEndpoint _endpoint;

        /// <summary>
        /// The company identifier that will be used to run all tests.
        /// </summary>
        private int _huduCompanyID = 41;

        private int _integrationID = 2;

        public MatchersEndpointTests()
        {
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<MatchersEndpointTests>();

            _configuration = builder.Build();
            _endpoint = new MatchersEndpoint(_configuration["HuduAPIKey"], _configuration["HuduBaseURL"]);
        }

        private IConfiguration _configuration { get; set; }

        [TestMethod]
        public void GetAllMatchers()
        {
            GetMatchers parameters = new(_integrationID);
            Matchers Matchers = _endpoint.Get(parameters);

            Assert.IsNotNull(Matchers);
            Assert.AreNotEqual(0, Matchers.MatchersList.Count());
        }

        [TestMethod]
        public void UpdateMatcher()
        {
            GetMatchers parameters = new(_integrationID);
            parameters.PageSize = 1000;

            Matchers matchers = _endpoint.Get(parameters);

            Matcher matcher = matchers.MatchersList.First<Matcher>(x => x.SyncId.Equals(_cwCompanyID));

            Assert.IsNotNull(matcher);

            UpdateMatcher updateparams = new UpdateMatcherBuilder(matcher.Id)
                .WithsyncId(_cwCompanyID.ToString())
                .WithCompanyId(_huduCompanyID)
                .Build();

            Matcher result = _endpoint.Update(updateparams);
        }
    }
}