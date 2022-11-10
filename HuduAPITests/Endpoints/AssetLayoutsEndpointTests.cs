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
        private int _companyId = 7;
        private AssetLayoutsEndpoint _endpoint;
        private int _existingAssetLayout = 1;

        public AssetLayoutsEndpointTests()
        {
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<CompaniesEndpointTests>();

            _configuration = builder.Build();
            _endpoint = new AssetLayoutsEndpoint(_configuration["HuduAPIKey"], _configuration["HuduBaseURL"]);
        }

        private IConfiguration _configuration { get; set; }

        [TestMethod]
        public void CreateUpdateAssetLayout()
        {
            string name = "API Asset";
            string icon = "fas fa-home";
            System.Drawing.Color color = System.Drawing.Color.Green;
            System.Drawing.Color icon_color = System.Drawing.Color.Black;

            List<AssetLayoutField> fields = new List<AssetLayoutField>();

            fields.Add(new AssetLayoutFieldBuilder("Required Asset Field", AssetLayoutFieldType.TEXT)
                .WithRequired(true)
                .WithShowInList(true).Build());

            fields.Add(new AssetLayoutFieldBuilder("Required Emails", AssetLayoutFieldType.EMAIL)
                .WithHint("Put an email address in here").Build());

            CreateAssetLayout myParams = new CreateAssetLayoutBuilder(name: name, icon: icon, color: color, iconColor: icon_color, fields)
                .WithIncludeComments(false)
                .WithIncludeFiles(false).Build();

            AssetLayout result = _endpoint.Create(myParams);

            Assert.IsNotNull(result);
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(icon, result.Icon);
            Assert.AreEqual(false, result.IncludeComments);
            Assert.AreEqual(false, result.IncludeFiles);
            Assert.AreEqual(2, result.Fields.Count);

            //Now try updating the asset layout
            fields.Clear();
            fields.Add(new AssetLayoutFieldBuilder("Required Phone", AssetLayoutFieldType.PHONE)
                .WithHint("Put the phone number in here").Build());

            UpdateAssetLayout updateParams = new UpdateAssetLayoutBuilder(id: result.ID, name: result.Name, icon: icon, color: color, iconColor: icon_color, assetLayoutFields: fields)
                .WithIncludeComments(true)
                .WithIncludeFiles(true)
                .IsActive(true)
                .Build();

            result = _endpoint.Update(updateParams);
            Assert.IsTrue(result.IncludeComments, "IncludeComments failed");
            Assert.IsTrue(result.IncludeFiles, "IncludeFiles failed");
            Assert.AreEqual(3, result.Fields.Count);
            Assert.IsTrue(result.Active, "Active Status failed");
        }

        [TestMethod]
        public void GetAssetLayout()
        {
            Parameters.ItemById parameters = new(6);
            AssetLayout result = _endpoint.Get(parameters);
            Assert.AreEqual(6, result.ID);
            Assert.IsTrue(result.Active);
            Assert.IsTrue(result.IncludeComments);
            Assert.IsTrue(result.IncludePasswords);
            Assert.IsFalse(result.IncludePhotos);
            Assert.IsTrue(result.IncludeFiles);
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
            //Get the hudu assetLayout for access points
            GetAssetLayouts myparams = new GetAssetLayoutsBuilder()
                .WithName("Network Device")
                .Build();

            AssetLayout assetlayout = _endpoint.Get(myparams).AssetLayoutList.First<AssetLayout>();

            Assert.AreEqual("Network Device", assetlayout.Name);
        }

        [TestMethod]
        public void GetInvalidAssetLayout()
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