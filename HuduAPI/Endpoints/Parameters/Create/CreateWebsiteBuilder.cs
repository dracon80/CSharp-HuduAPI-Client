using HuduAPI.Endpoints.Parameters.AbstractBases;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Builder for the class <see cref="CreateWebsite">CreateWebsite</see>
    /// </summary>
    public class CreateWebsiteBuilder : WebsiteBuilder<CreateWebsite, CreateWebsiteBuilder>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebsiteBuilder" /> class.
        /// </summary>
        /// <param name="name">
        /// FQND of the website to be monitored (e.g. www.example.com)
        /// </param>
        /// <param name="companyId">
        /// The company identifier to associate the website with.
        /// </param>
        public CreateWebsiteBuilder(string name, int companyId) : base(name, companyId)
        {
        }

        /// <summary>
        /// Build a class of type <see cref="CreateWebsite">CreateWebsite</see> with all the defined values
        /// </summary>
        /// <returns>
        /// Returns a <see cref="CreateWebsite">CreateWebsite</see> class
        /// </returns>
        public override CreateWebsite Build()
        {
            return new CreateWebsite(_name, _companyId)
            {
                DisableDns = _disableDns,
                DisableSsl = _disableSsl,
                DisableWhois = _disableWhois,
                Paused = _paused,
                Notes = _notes
            };
        }
    }
}