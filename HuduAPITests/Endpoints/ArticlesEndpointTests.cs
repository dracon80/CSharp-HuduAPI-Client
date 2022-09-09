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
            GetArticle parameters = new(articleID);
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
            GetArticle myparams;

            Assert.ThrowsException<ArgumentOutOfRangeException>(
                     () => myparams = new(id: -3)
                );
        }
    }
}