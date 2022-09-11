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
    public class AssetPasswordsEndpointTests
    {
        private IConfiguration _configuration { get; set; }
        private AssetPasswordsEndpoint _endpoint;

        public AssetPasswordsEndpointTests()
        {
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<AssetLayoutsEndpointTests>();

            _configuration = builder.Build();
            _endpoint = new AssetPasswordsEndpoint(_configuration["HuduAPIKey"], _configuration["HuduBaseURL"]);
        }

        [TestMethod()]
        public void GetAssetPasswords()
        {
            //Get a list of AssetPasswords from the endpoint and confirm that its not empy
            AssetPasswords results = _endpoint.Get();
            Assert.AreNotEqual(0, results.AssetPasswordList.Count);
        }

        [TestMethod()]
        public void GetAssetPasswordsFiltered()
        {
            //Get a filtered list of AssetPasswords from the endpoint and confirm that its not empty
            GetAssetPasswords parameters = new GetAssetPasswordsBuilder().WithCompanyID(7).WithPageSize(10).Build();

            AssetPasswords results = _endpoint.Get(parameters);
            Assert.AreEqual(10, results.AssetPasswordList.Count);
        }

        [TestMethod]
        public void GetAssetPassword()
        {
            Parameters.ItemById parameters = new(1152);
            AssetPassword result = _endpoint.Get(parameters);
            Assert.AreEqual(1152, result.ID);
        }

        [TestMethod]
        public void GetInvalidAssetPassword()
        {
            Parameters.ItemById parameters = new(2348956);

            Assert.ThrowsException<RecordNotFoundException>(
                     () => _endpoint.Get(parameters)
                );
        }

        [TestMethod]
        public void GetNegativeAssetLayoutID()
        {
            ItemById myparams;

            Assert.ThrowsException<ArgumentOutOfRangeException>(
                     () => myparams = new(id: -3)
                );
        }
    }
}