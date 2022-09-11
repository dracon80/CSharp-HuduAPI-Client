using Microsoft.VisualStudio.TestTools.UnitTesting;
using HuduAPI.Endpoints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using HuduAPI.Endpoints.Parameters;
using HuduAPI.Records;
using HuduAPI.Endpoints.Exceptions;

namespace HuduAPI.Endpoints.Tests
{
    [TestClass()]
    public class ArticlesEndpointTests
    {
        private IConfiguration _configuration { get; set; }
        private ArticlesEndpoint _endpoint;

        public ArticlesEndpointTests()
        {
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<CompanyEndpointTests>();

            _configuration = builder.Build();
            _endpoint = new ArticlesEndpoint(_configuration["HuduAPIKey"], _configuration["HuduBaseURL"]);
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
            GetArticles parameters = new GetArticlesBuilder().WithCompanyID(7).Build();
            Articles results = _endpoint.Get(parameters);

            Assert.AreNotEqual(0, results.ArticleList.Count);
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
        public void CreateArticle()
        {
            string content = "This is some content";
            string name = "Test Article";

            CreateArticle myParams = new CreateArticleBuilder(name, content)
                .WithEnableSharing(true)
                .WithCompanyId(7)
                .Build();

            Article result = _endpoint.Create(myParams);

            Assert.AreEqual(7, result.CompanyID);
            Assert.IsTrue(result.EnableSharing);
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(content, result.Content);
        }
    }
}