using Microsoft.VisualStudio.TestTools.UnitTesting;
using HuduAPI.Records;
using Microsoft.Extensions.Configuration;
using HuduAPI.Endpoints.Parameters;
using HuduAPI.Endpoints.Exceptions;

namespace HuduAPI.Endpoints.Tests
{
    [TestClass()]
    public class ProcedureEndpointTests
    {
        /// <summary>
        /// The company identifier that will be used to run all tests.
        /// </summary>
        private int _companyID = 7;

        private ProcedureEndpoint _endpoint;

        public ProcedureEndpointTests()
        {
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<ProcedureEndpointTests>();

            _configuration = builder.Build();
            _endpoint = new ProcedureEndpoint(_configuration["HuduAPIKey"], _configuration["HuduBaseURL"]);
        }

        private IConfiguration _configuration { get; set; }

        [TestMethod]
        public void GetAllProcedures()
        {
            Procedures Procedures = _endpoint.Get();

            Assert.IsNotNull(Procedures);
            Assert.AreNotEqual(0, Procedures.ProcedureList.Count());
        }

        [TestMethod]
        public void GetFilteredProcedures()
        {
            GetProcedures paramaters = new GetProceduresBuilder().WithCompanyId(_companyID).Build();
            Procedures results = _endpoint.Get(paramaters);

            Assert.AreNotEqual(0, results.ProcedureList.Count());

            //Check each Procedure is from the required company
            foreach (Procedure f in results.ProcedureList)
            {
                Assert.AreEqual(f.CompanyName, "Integrated Solutions QLD Pty Ltd", "Procedures included from companies other than requested");
            }

            paramaters = new GetProceduresBuilder().WithName("New MSP Customer").Build();

            //Check each Procedure is from the required company
            foreach (Procedure f in results.ProcedureList)
            {
                Assert.AreEqual("New MSP Customer", f.Name, "Procedures included other than \"New MSP Customer\"");
            }
        }

        [TestMethod]
        public void GetInvalidProcedure()
        {
            ItemById myparams = new(id: 4856734);

            Assert.ThrowsException<RecordNotFoundException>(
                     () => _endpoint.Get(myparams)
                );
        }

        [TestMethod]
        public void GetNegativeProcedureID()
        {
            ItemById myparams;

            Assert.ThrowsException<ArgumentOutOfRangeException>(
                     () => myparams = new(id: -3)
                );
        }

        [TestMethod]
        public void GetProcedure()
        {
            int ProcedureID = 24;
            ItemById myparams = new(id: ProcedureID);

            Procedure Procedure = _endpoint.Get(myparams);

            Assert.IsNotNull(Procedure);
            Assert.AreEqual(ProcedureID, Procedure.ID);
            Assert.AreEqual(Procedure.Name, "New MSP Customer");
        }
    }
}