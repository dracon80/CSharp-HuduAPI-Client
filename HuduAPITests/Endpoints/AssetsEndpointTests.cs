using Microsoft.VisualStudio.TestTools.UnitTesting;
using HuduAPI.Records;
using Microsoft.Extensions.Configuration;
using HuduAPI.Endpoints.Parameters;
using HuduAPI.Endpoints.Exceptions;
using System.Formats.Asn1;

namespace HuduAPI.Endpoints.Tests
{
    [TestClass()]
    public class AssetsEndpointTests
    {
        /// <summary>
        /// The company identifier that will be used to run all tests.
        /// </summary>
        private int _companyID = 7;

        private AssetsEndpoint _endpoint;

        public AssetsEndpointTests()
        {
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<AssetsEndpointTests>();

            _configuration = builder.Build();
            _endpoint = new AssetsEndpoint(_configuration["HuduAPIKey"], _configuration["HuduBaseURL"]);
        }

        private IConfiguration _configuration { get; set; }

        [TestMethod]
        public void ArchiveInvalidID()
        {
            int assetID = 1;
            AssetById myparams = new(assetID, _companyID);

            Assert.ThrowsException<RecordNotFoundException>(
                () => _endpoint.Archive(myparams, true)
            );
        }

        [TestMethod]
        public void CreateUpdateDelete_ok()
        {
            int layoutID = 1;
            string name = "New Test Asset";
            string serial = "12345";
            string man = "Test Manufactor";
            string mail = "na@na.com.au";
            string model = "Test Model";

            CreateAsset myparams = new CreateAssetBuilder(_companyID, layoutID, name)
                .WithPrimarySerial(serial)
                .WithPrimaryManufacturer(man)
                .WithPrimaryMail(mail)
                .WithPrimaryModel(model)
                .WithCustomField("Status", "ACTIVE")
                .WithCustomField("Email_Address", "na@na.com")
                .WithCustomField("Department", "IT")
                .Build();

            Asset result = _endpoint.Create(myparams);

            Assert.AreEqual(layoutID, result.AssetLayoutID);
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(serial, result.PrimarySerial);
            Assert.AreEqual(man, result.PrimaryManufacturer);
            Assert.AreEqual(mail, result.PrimaryMail);
            Assert.AreEqual(model, result.PrimaryModel);
            Assert.AreEqual(_companyID, result.CompanyID);
            Assert.AreEqual(3, result.Fields.Count(), "Custom fields count doesn't match");

            //Now try updating it with new details.
            layoutID = 1;
            name = "Updated Test Asset";
            serial = "12342342345";
            man = "Updated Manufactor";
            mail = "nada@na.com.au";
            model = "Updated Model";

            UpdateAsset updateparams = new UpdateAssetBuilder(result.ID, _companyID, layoutID, name)
                .WithPrimarySerial(serial)
                .WithPrimaryManufacturer(man)
                .WithPrimaryMail(mail)
                .WithPrimaryModel(model)
                .WithCustomField("Status", "INACTIVE")
                .WithCustomField("Email Address", mail)
                .WithCustomField("Department", "IT")
                .WithCustomField("Gender", "Male")
                .WithCustomField("Title", "Chaos Management")
                .Build();

            result = _endpoint.Update(updateparams);

            Assert.AreEqual(layoutID, result.AssetLayoutID);
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(serial, result.PrimarySerial);
            Assert.AreEqual(man, result.PrimaryManufacturer);
            Assert.AreEqual(mail, result.PrimaryMail);
            Assert.AreEqual(model, result.PrimaryModel);
            Assert.AreEqual(_companyID, result.CompanyID);
            Assert.AreEqual(5, result.Fields.Count(), "Custom fields count doesn't match");

            AssetById item = new(result.ID, result.CompanyID);

            //Archive and Unarchive.
            result = _endpoint.Archive(item, true);
            result = _endpoint.Archive(item, false);

            _endpoint.Delete(item);
        }

        [TestMethod()]
        public void GetAllAssets()
        {
            //Get a list of Assets from the endpoint and confirm that its not empy
            Assets Assets = _endpoint.Get();

            Assert.AreNotEqual(0, Assets.AssetList.Count());
        }

        [TestMethod()]
        public void GetAsset()
        {
            int assetID = 3434;

            AssetById myparams = new(assetID, _companyID);

            Asset result = _endpoint.Get(myparams);

            Assert.AreEqual(_companyID, result.CompanyID);
            Assert.AreEqual(assetID, result.ID);
            Assert.AreEqual(3, result.AssetLayoutID);
            Assert.AreEqual("Integrated Solutions QLD Pty Ltd", result.CompanyName);
            Assert.AreEqual(8, result.Fields.Count());
        }

        [TestMethod()]
        public void GetFilteredAssets()
        {
            GetAssets parameters = new GetAssetsBuilder()
                .WithCompanyId(_companyID)
                .WithAssetLayoutId(2)
                .Build();

            //Get a list of Assets from the endpoint and confirm that its not empy
            Assets Assets = _endpoint.Get(parameters);

            Assert.AreNotEqual(0, Assets.AssetList.Count());

            foreach (Asset a in Assets.AssetList)
            {
                //Check that all returned records are for state QLD
                Assert.AreEqual(2, a.AssetLayoutID, "Assetlayout should not be present in results");
                Assert.AreEqual(_companyID, a.CompanyID, "Company Assets should not be present in results");
            }
        }

        [TestMethod]
        public void GetInvalidCompany()
        {
            AssetById myparams = new(id: 4856734, companyId: 7);

            Assert.ThrowsException<RecordNotFoundException>(
                     () => _endpoint.Get(myparams)
                );
        }

        [TestMethod]
        public void GetNegativeCompanyID()
        {
            AssetById myparams;

            Assert.ThrowsException<ArgumentOutOfRangeException>(
                     () => myparams = new(id: -3, companyId: 7)
                );
        }
    }
}