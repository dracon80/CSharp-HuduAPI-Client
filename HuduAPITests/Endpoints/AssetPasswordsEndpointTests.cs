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
        private int _companyId = 7;
        private int _existing = 1152;

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
            Parameters.ItemById parameters = new(_existing);
            AssetPassword result = _endpoint.Get(parameters);
            Assert.AreEqual(_existing, result.ID);
            Assert.AreEqual("ncompassReportUser", result.Name);
            Assert.AreEqual("djf$dk&!f9anvFsdj@sSdfj", result.Password);

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

        [TestMethod]
        public void CreateUpdateDelete_OK()
        {
            string name = "New Asset Password";
            string pass = "1234";
            string desc = "This is a test password";
            string user = "TestUser";
            string url = "https://mybigtest.com/";
            string otp = "432567";
            
            CreateAssetPassword myparam = new CreateAssetPasswordBuilder(_companyId, name, pass)
                .WithDescription(desc)
                .WithInPortal(true)
                .WithUsername(user)
                .WithUrl(url).Build();

            AssetPassword result = _endpoint.Create(myparam);

            Assert.IsNotNull(result);
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(pass, result.Password);
            Assert.AreEqual(desc, result.Description);
            Assert.AreEqual(user, result.Username);

            name = "Updated New Asset Password";

            //Now try updating it with new values.
            UpdateAssetPassword update = new UpdateAssetPasswordBuilder(result.ID, _companyId, name, pass)
                .WithOtpSecret(otp)
                .WithInPortal(false).Build();

            result = _endpoint.Update(update);

            Assert.IsNotNull(result);
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(pass, result.Password);
            Assert.AreEqual(desc, result.Description);
            Assert.AreEqual(user, result.Username);
            Assert.AreEqual(otp, result.OtpSecret);

            //Now Test Out Archiving
            ItemById item = new(result.ID);
            result = _endpoint.Archive(item, true);
            //No way of confirming this other than manually through the UI
            result = _endpoint.Archive(item, false);
            

            //Clean up the test and delete the record
            _endpoint.Delete(item);
        }
    }
}