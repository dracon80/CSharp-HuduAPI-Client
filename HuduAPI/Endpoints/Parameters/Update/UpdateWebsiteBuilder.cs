using HuduAPI.Endpoints.Parameters.AbstractBases;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// This is a builder class to help build a new UpdateWebsite with all possible proerties to use
    /// the hudu endpoint api/v1/websites.
    /// </summary>
    public class UpdateWebsiteBuilder : WebsiteBuilder<UpdateWebsite, UpdateWebsiteBuilder>
    {
        private int _id;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWebsiteBuilder" /> builder class.
        /// </summary>
        /// <param name="id">
        /// The identifier of the website.
        /// </param>
        /// <param name="name">
        /// The name to set the website too.
        /// </param>
        /// <param name="companyId">
        /// The company identifier to associated the website with.
        /// </param>
        public UpdateWebsiteBuilder(int id, string name, int companyId) : base(name, companyId)
        {
            _id = id;
        }

        /// <summary>
        /// Builds a new instance of type <see cref="UpdateWebsite" /> with all required properties initialised.
        /// </summary>
        /// <returns>
        /// </returns>
        public override Website Build()
        {
            return new UpdateWebsite(_id, _name, _companyId)
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