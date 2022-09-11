using Microsoft.VisualStudio.TestTools.UnitTesting;
using HuduAPI.Endpoints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using HuduAPI.Records;
using HuduAPI.Endpoints.Parameters;
using HuduAPI.Endpoints.Exceptions;

namespace HuduAPI.Endpoints.Tests
{
    [TestClass()]
    public class AssetLayoutsEndpointTests
    {
        private IConfiguration _configuration { get; set; }
        private AssetLayoutsEndpoint _endpoint;

        public AssetLayoutsEndpointTests()
        {
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<CompanyEndpointTests>();

            _configuration = builder.Build();
            _endpoint = new AssetLayoutsEndpoint(_configuration["HuduAPIKey"], _configuration["HuduBaseURL"]);
        }

        [TestMethod()]
        public void GetAssetLayouts()
        {
            //Get a list of assetlayouts from the endpoint and confirm that its not empy
            Records.AssetLayouts results = _endpoint.Get();
            Assert.AreNotEqual(0, results.AssetLayoutList.Count);
        }

        [TestMethod()]
        public void GetAssetLayoutsFiltered()
        {
            //Get a filtered list of assetlayouts from the endpoint and confirm that its not empty
            GetAssetLayouts parameters = new GetAssetLayoutsBuilder().WithName("People").Build();

            Records.AssetLayouts results = _endpoint.Get(parameters);
            Assert.AreEqual(1, results.AssetLayoutList.Count);
        }

        [TestMethod]
        public void GetAssetLayout()
        {
            Parameters.GetAssetLayout parameters = new(6);
            AssetLayout result = _endpoint.Get(parameters);
            Assert.AreEqual(6, result.ID);
        }

        [TestMethod]
        public void GetInvalidAssetLayout()
        {
            Parameters.GetAssetLayout parameters = new(2348956);

            Assert.ThrowsException<RecordNotFoundException>(
                     () => _endpoint.Get(parameters)
                );
        }

        [TestMethod]
        public void GetNegativeAssetLayoutID()
        {
            GetAssetLayout myparams;

            Assert.ThrowsException<ArgumentOutOfRangeException>(
                     () => myparams = new(id: -3)
                );
        }
    }
}