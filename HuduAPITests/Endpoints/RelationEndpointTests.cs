using Microsoft.VisualStudio.TestTools.UnitTesting;
using HuduAPI.Records;
using Microsoft.Extensions.Configuration;
using HuduAPI.Endpoints.Parameters;
using HuduAPI.Endpoints.Exceptions;

namespace HuduAPI.Endpoints.Tests
{
    [TestClass()]
    public class RelationEndpointTests
    {
        /// <summary>
        /// The company identifier that will be used to run all tests.
        /// </summary>
        private int _companyID = 7;

        private RelationEndpoint _endpoint;

        public RelationEndpointTests()
        {
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<RelationEndpointTests>();

            _configuration = builder.Build();
            _endpoint = new RelationEndpoint(_configuration["HuduAPIKey"], _configuration["HuduBaseURL"]);
        }

        private IConfiguration _configuration { get; set; }

        [TestMethod]
        public void CreateDeleteGlobalRelation()
        {
            int fromableID = 2215;
            int toableID = 2690;
            string desc = "Test Relationship";

            CreateRelation myparams = new CreateRelationBuilder("Asset", toableID, "Asset", fromableID)
                .WithDescription(desc).Build();

            Relation result = _endpoint.Create(myparams);

            Assert.AreEqual(fromableID, result.FromableID); ;
            Assert.AreEqual(toableID, result.ToableID);
            Assert.AreEqual(desc, result.Description);
            Assert.AreEqual("Asset", result.ToableType);
            Assert.AreEqual("Asset", result.FromableType);

            //Clean Up created Relation
            ItemById item = new(result.ID);
            _endpoint.Delete(item);
        }

        [TestMethod]
        public void GetAllRelations()
        {
            Relations Relations = _endpoint.Get();

            Assert.IsNotNull(Relations);
            Assert.AreNotEqual(0, Relations.RelationsList.Count());
        }

        [TestMethod]
        public void GetFilteredRelations()
        {
            GetRelations paramaters = new GetRelationsBuilder().WithPageSize(3).Build();
            Relations results = _endpoint.Get(paramaters);

            Assert.AreEqual(3, results.RelationsList.Count());
        }
    }
}