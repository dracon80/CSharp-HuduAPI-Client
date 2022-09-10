namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Builder for the class <see cref="CreateWebsite">CreateWebsite</see>
    /// </summary>
    public class CreateWebsiteBuilder
    {
        private int _companyId;
        private bool _disableDns;
        private bool _disableSsl;
        private bool _disableWhois;
        private string _name;
        private string? _notes;
        private bool _paused;

        /// <summary>
        /// Create a new instance for the <see cref="CreateWebsiteBuilder">CreateWebsiteBuilder</see>
        /// </summary>
        /// <param name="name">
        /// FQND of the website to be monitored (e.g. www.example.com)
        /// </param>
        /// <param name="companyId">
        /// The company identifier to associate the website with.
        /// </param>
        public CreateWebsiteBuilder(string name, int companyId)
        {
            _companyId = companyId;
            _disableDns = false;
            _disableSsl = false;
            _disableWhois = false;
            _name = name;
            _notes = default;
            _paused = false;
        }

        /// <summary>
        /// Build a class of type <see cref="CreateWebsite">CreateWebsite</see> with all the defined values
        /// </summary>
        /// <returns>
        /// Returns a <see cref="CreateWebsite">CreateWebsite</see> class
        /// </returns>
        public CreateWebsite Build()
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

        /// <summary>
        /// Set a value of type <typeparamref name="int" /> for the property <paramref name="companyId">companyId</paramref>
        /// </summary>
        /// <param name="companyId">
        /// A value of type <typeparamref name="int" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateWebsiteBuilder">CreateWebsiteBuilder</see> with the
        /// property <paramref name="companyId">companyId</paramref> defined
        /// </returns>
        public CreateWebsiteBuilder WithCompanyId(int companyId)
        {
            _companyId = companyId;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="bool" /> for the property <paramref name="disableDns">disableDns</paramref>
        /// </summary>
        /// <param name="disableDns">
        /// A value of type <typeparamref name="bool" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateWebsiteBuilder">CreateWebsiteBuilder</see> with the
        /// property <paramref name="disableDns">disableDns</paramref> defined
        /// </returns>
        public CreateWebsiteBuilder WithDisableDns(bool disableDns)
        {
            _disableDns = disableDns;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="bool" /> for the property <paramref name="disableSsl">disableSsl</paramref>
        /// </summary>
        /// <param name="disableSsl">
        /// A value of type <typeparamref name="bool" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateWebsiteBuilder">CreateWebsiteBuilder</see> with the
        /// property <paramref name="disableSsl">disableSsl</paramref> defined
        /// </returns>
        public CreateWebsiteBuilder WithDisableSsl(bool disableSsl)
        {
            _disableSsl = disableSsl;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="bool" /> for the property <paramref name="disableWhois">disableWhois</paramref>
        /// </summary>
        /// <param name="disableWhois">
        /// A value of type <typeparamref name="bool" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateWebsiteBuilder">CreateWebsiteBuilder</see> with the
        /// property <paramref name="disableWhois">disableWhois</paramref> defined
        /// </returns>
        public CreateWebsiteBuilder WithDisableWhois(bool disableWhois)
        {
            _disableWhois = disableWhois;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="name">name</paramref>
        /// </summary>
        /// <param name="name">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateWebsiteBuilder">CreateWebsiteBuilder</see> with the
        /// property <paramref name="name">name</paramref> defined
        /// </returns>
        public CreateWebsiteBuilder WithName(string name)
        {
            _name = name;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="notes">notes</paramref>
        /// </summary>
        /// <param name="notes">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateWebsiteBuilder">CreateWebsiteBuilder</see> with the
        /// property <paramref name="notes">notes</paramref> defined
        /// </returns>
        public CreateWebsiteBuilder WithNotes(string notes)
        {
            _notes = notes;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="bool" /> for the property <paramref name="paused">paused</paramref>
        /// </summary>
        /// <param name="paused">
        /// A value of type <typeparamref name="bool" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateWebsiteBuilder">CreateWebsiteBuilder</see> with the
        /// property <paramref name="paused">paused</paramref> defined
        /// </returns>
        public CreateWebsiteBuilder WithPaused(bool paused)
        {
            _paused = paused;
            return this;
        }
    }
}