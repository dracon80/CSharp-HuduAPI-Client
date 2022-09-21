using HuduAPI.Endpoints.Exceptions;
using HuduAPI.Endpoints.Parameters;
using HuduAPI.Records;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HuduAPI.Endpoints.Tests
{
    [TestClass()]
    public class ArticlesEndpointTests
    {
        private int _companyFolderId = 3;
        private int _companyId = 7;
        private ArticlesEndpoint _endpoint;

        public ArticlesEndpointTests()
        {
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<CompanyEndpointTests>();

            _configuration = builder.Build();
            _endpoint = new ArticlesEndpoint(_configuration["HuduAPIKey"], _configuration["HuduBaseURL"]);
        }

        private IConfiguration _configuration { get; set; }

        private Article ArchiveArticle(int id, Boolean archive)
        {
            ItemById parameters = new(id);
            Article result = _endpoint.Archive(parameters, archive);

            return result;
        }

        private void DeleteArticle(int id)
        {
            ItemById parameters = new(id);
            _endpoint.Delete(parameters);
        }

        private Article GetArticle(int articleID)
        {
            ItemById parameters = new(articleID);
            return _endpoint.Get(parameters);
        }

        [TestMethod()]
        public void GetArticle()
        {
            int articleID = 205;
            Article result = this.GetArticle(articleID);
            Assert.AreEqual(articleID, result.ID);
        }

        [TestMethod()]
        public void GetArticles()
        {
            //Get a list of articles from the endpoint and confirm that its not empy
            Articles results = _endpoint.Get();
            Assert.AreNotEqual(0, results.ArticleList.Count);
        }

        [TestMethod]
        public void GetArticlesFiltered()
        {
            //Get a filtered list of articles from a company
            GetArticles parameters = new GetArticlesBuilder().WithCompanyID(_companyId).Build();
            Articles results = _endpoint.Get(parameters);

            Assert.AreNotEqual(0, results.ArticleList.Count);
        }

        [TestMethod]
        public void GetInvalidArticleID()
        {
            //Using an invalid ID should result in an exception
            int articleID = 345567;
            Assert.ThrowsException<RecordNotFoundException>(
                     () => this.GetArticle(articleID)
                );
        }

        [TestMethod]
        public void GetNegativeArticleID()
        {
            ItemById myparams;

            Assert.ThrowsException<ArgumentOutOfRangeException>(
                     () => myparams = new(id: -3)
                );
        }

        [TestMethod]
        public void MoveArticle()
        {
            //Create an Article and the move it to a new folder within the company

            //------------CREATE Article---------------------------------------
            string content = "This is some content";
            string name = "Test Article - " + DateTime.Now.ToShortDateString();

            CreateArticle myParams = new CreateArticleBuilder(name, content)
                .WithEnableSharing(true)
                .WithCompanyId(_companyId)
                .Build();

            Article result = _endpoint.Create(myParams);

            Assert.AreEqual(_companyId, result.CompanyID);
            Assert.IsTrue(result.EnableSharing);
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(content, result.Content);

            //----------UPDATE Article-----------------------------------------
            content = "This is some updated content";
            name = "Updated Test Article - " + DateTime.Now.ToShortDateString();

            UpdateArticle myUpdateParams = new UpdateArticleBuilder(result.ID, name, content)
                .WithEnableSharing(false)
                .WithFolderId(_companyFolderId)
                .Build();

            result = _endpoint.Update(myUpdateParams);

            Assert.AreEqual(_companyId, result.CompanyID);
            Assert.AreEqual(_companyFolderId, result.FolderID);
            Assert.IsFalse(result.EnableSharing);
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(content, result.Content);

            //----------Archive / UnArchive------------------------------------
            result = this.ArchiveArticle(result.ID, true);
            Assert.IsTrue(result.Archived);

            result = this.ArchiveArticle(result.ID, false);
            Assert.IsFalse(result.Archived);

            //-----------Delete Article----------------------------------------
            this.DeleteArticle(result.ID);
        }

        [TestMethod]
        public void SuccessfullArticleCompany()
        {
            //Create an article for the company, update it, archive and unarchive, then finally delete the article from the system

            //------------CREATE Article---------------------------------------
            string content = "This is some content";
            string name = "Test Article - " + DateTime.Now.ToShortDateString();

            CreateArticle myParams = new CreateArticleBuilder(name, content)
                .WithEnableSharing(true)
                .WithCompanyId(_companyId)
                .Build();

            Article result = _endpoint.Create(myParams);

            Assert.AreEqual(_companyId, result.CompanyID);
            Assert.IsTrue(result.EnableSharing);
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(content, result.Content);

            //----------UPDATE Article-----------------------------------------
            content = "This is some updated content";
            name = "Updated Test Article - " + DateTime.Now.ToShortDateString();

            UpdateArticle myUpdateParams = new UpdateArticleBuilder(result.ID, name, content)
                .WithEnableSharing(false)
                .Build();

            result = _endpoint.Update(myUpdateParams);

            Assert.AreEqual(_companyId, result.CompanyID);
            Assert.IsFalse(result.EnableSharing);
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(content, result.Content);

            //----------Archive / UnArchive------------------------------------
            result = this.ArchiveArticle(result.ID, true);
            Assert.IsTrue(result.Archived);

            result = this.ArchiveArticle(result.ID, false);
            Assert.IsFalse(result.Archived);

            //-----------Delete Article----------------------------------------
            this.DeleteArticle(result.ID);
        }

        [TestMethod]
        public void SuccessfullArticleRoot()
        {
            //------------CREATE Article---------------------------------------
            string content = "This is some content";
            string name = "Test Article - " + DateTime.Now.ToShortDateString();

            CreateArticle myParams = new CreateArticleBuilder(name, content)
                .WithEnableSharing(true)
                .Build();

            Article result = _endpoint.Create(myParams);

            Assert.IsTrue(result.EnableSharing);
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(content, result.Content);

            //----------UPDATE Article-----------------------------------------
            content = "This is some updated content";
            name = "Updated Test Article - " + DateTime.Now.ToShortDateString();

            UpdateArticle myUpdateParams = new UpdateArticleBuilder(result.ID, name, content)
                .WithEnableSharing(false)
                .Build();

            result = _endpoint.Update(myUpdateParams);

            Assert.IsFalse(result.EnableSharing);
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(content, result.Content);

            //----------Archive / UnArchive------------------------------------
            result = this.ArchiveArticle(result.ID, true);
            Assert.IsTrue(result.Archived);

            result = this.ArchiveArticle(result.ID, false);
            Assert.IsFalse(result.Archived);

            //-----------Delete Article----------------------------------------
            this.DeleteArticle(result.ID);
        }
    }
}