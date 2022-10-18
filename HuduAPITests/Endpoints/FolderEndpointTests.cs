using Microsoft.VisualStudio.TestTools.UnitTesting;
using HuduAPI.Records;
using Microsoft.Extensions.Configuration;
using HuduAPI.Endpoints.Parameters;
using HuduAPI.Endpoints.Exceptions;

namespace HuduAPI.Endpoints.Tests
{
    [TestClass()]
    public class FolderEndpointTests
    {
        /// <summary>
        /// The company identifier that will be used to run all tests.
        /// </summary>
        private int _companyID = 7;

        private FolderEndpoint _endpoint;

        public FolderEndpointTests()
        {
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<FolderEndpointTests>();

            _configuration = builder.Build();
            _endpoint = new FolderEndpoint(_configuration["HuduAPIKey"], _configuration["HuduBaseURL"]);
        }

        private IConfiguration _configuration { get; set; }

        [TestMethod]
        public void CreateUpdateDeleteGlobalFolder()
        {
            string name = "New Test Folder";
            string icon = "fas-computer";
            string desc = "New Folder Description";
            CreateFolder myparams = new CreateFolderBuilder(name)
                .WithIcon(icon)
                .WithDescription(desc).Build();

            Folder result = _endpoint.Create(myparams);

            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(icon, result.Icon);
            Assert.AreEqual(desc, result.Description);

            name = "Updated Test Folder";
            icon = "fas-server";
            desc = "Updated Folder Description";
            //Now update the folder with some new information
            UpdateFolder updateparams = new UpdateFolderBuilder(result.ID, result.Name)
                .WithName(name)
                .WithCompanyId(_companyID)
                .WithDescription(desc)
                .WithIcon(icon)
                .Build();

            result = _endpoint.Update(updateparams);

            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(icon, result.Icon);
            Assert.AreEqual(desc, result.Description);
            Assert.AreEqual(_companyID, result.CompanyID);

            ItemById item = new(result.ID);

            //Clean Up created folder
            _endpoint.Delete(item);
        }

        [TestMethod]
        public void GetAllFolders()
        {
            Folders folders = _endpoint.Get();

            Assert.IsNotNull(folders);
            Assert.AreNotEqual(0, folders.FolderList.Count());
        }

        [TestMethod]
        public void GetFilteredFolders()
        {
            GetFolders paramaters = new GetFoldersBuilder().WithCompanyId(_companyID).Build();
            Folders results = _endpoint.Get(paramaters);

            Assert.AreNotEqual(0, results.FolderList.Count());

            //Check each folder is from the required company
            foreach (Folder f in results.FolderList)
            {
                Assert.AreEqual(f.CompanyID, _companyID, "Folders included from companies other than requested");
            }

            paramaters = new GetFoldersBuilder().WithName("Test Folder").Build();

            //Check each folder is from the required company
            foreach (Folder f in results.FolderList)
            {
                Assert.AreEqual("Test Folder", f.Name, "Folders included other than \"Test Folder\"");
            }
        }

        [TestMethod]
        public void GetFolder()
        {
            int folderID = 3;
            ItemById myparams = new(id: folderID);

            Folder folder = _endpoint.Get(myparams);

            Assert.IsNotNull(folder);
            Assert.AreEqual(_companyID, folder.CompanyID);
            Assert.AreEqual(folderID, folder.ID);
            Assert.AreEqual(folder.Name, "Test Folder");
        }

        [TestMethod]
        public void GetInvalidFolder()
        {
            ItemById myparams = new(id: 4856734);

            Assert.ThrowsException<RecordNotFoundException>(
                     () => _endpoint.Get(myparams)
                );
        }

        [TestMethod]
        public void GetNegativeFolderID()
        {
            ItemById myparams;

            Assert.ThrowsException<ArgumentOutOfRangeException>(
                     () => myparams = new(id: -3)
                );
        }
    }
}