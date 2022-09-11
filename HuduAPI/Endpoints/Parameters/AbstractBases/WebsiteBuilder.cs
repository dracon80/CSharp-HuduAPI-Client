namespace HuduAPI.Endpoints.Parameters.AbstractBases
{
    /// <summary>
    /// Builder for the class <see cref="Website">CreateWebsite</see>
    /// </summary>
    public abstract class WebsiteBuilder<TResult, TBuilder>
        where TResult : Website
        where TBuilder : WebsiteBuilder<TResult, TBuilder>
    {
        /// <summary>
        /// Gets the builder instance of the implmenting class type.
        /// </summary>
        private readonly TBuilder _builderInstance = null;

        protected int _companyId;
        protected bool _disableDns;
        protected bool _disableSsl;
        protected bool _disableWhois;
        protected string _name;
        protected string? _notes;
        protected bool _paused;

        /// <summary>
        /// An Abstract contructor for creating the common properties of websites.
        /// </summary>
        /// <param name="name">
        /// FQND of the website to be monitored (e.g. www.example.com)
        /// </param>
        /// <param name="companyId">
        /// The company identifier to associate the website with.
        /// </param>
        internal WebsiteBuilder(string name, int companyId)
        {
            _companyId = companyId;
            _disableDns = false;
            _disableSsl = false;
            _disableWhois = false;
            _name = name;
            _notes = default;
            _paused = false;

            _builderInstance = (TBuilder)this;
        }

        /// <summary>
        /// Builds a new instance of type <typeparamref name="TResult" /> with all required
        /// properties initialised.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract Website Build();

        /// <summary>
        /// Set a value for companyId
        /// </summary>
        /// <param name="companyId">
        /// The company identifier.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithCompanyId(int companyId)
        {
            _companyId = companyId;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for disableDns
        /// </summary>
        /// <param name="disableDns">
        /// if set to <c>true</c> [disable DNS].
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithDisableDns(bool disableDns)
        {
            _disableDns = disableDns;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for disableSsl
        /// </summary>
        /// <param name="disableSsl">
        /// if set to <c>true</c> [disable SSL].
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithDisableSsl(bool disableSsl)
        {
            _disableSsl = disableSsl;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for disableWhois
        /// </summary>
        /// <param name="disableWhois">
        /// if set to <c>true</c> [disable whois].
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithDisableWhois(bool disableWhois)
        {
            _disableWhois = disableWhois;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for name
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithName(string name)
        {
            _name = name;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for notes
        /// </summary>
        /// <param name="notes">
        /// The notes.
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithNotes(string notes)
        {
            _notes = notes;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for paused
        /// </summary>
        /// <param name="paused">
        /// if set to <c>true</c> [paused].
        /// </param>
        /// <returns>
        /// A generic Builder Object for type <typeparamref name="TBuilder" />
        /// </returns>
        public TBuilder WithPaused(bool paused)
        {
            _paused = paused;
            return _builderInstance;
        }
    }
}