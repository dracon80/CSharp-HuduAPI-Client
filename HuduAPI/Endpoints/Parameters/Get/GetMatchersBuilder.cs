using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Builder for the class <see cref="GetMatchers">GetMatchers</see>
    /// </summary>
    public class GetMatchersBuilder
    {
        private int _companyId;
        private string _identifier;
        private int _integrationId;
        private bool _matched;
        private int _page;
        private int _pageSize;
        private string _syncId;

        /// <summary>
        /// Create a new instance for the <see cref="GetMatchersBuilder">GetMatchersBuilder</see>
        /// </summary>
        public GetMatchersBuilder(int integration_id)
        {
            this._integrationId = integration_id;
        }

        /// <summary>
        /// Build a class of type <see cref="GetMatchers">GetMatchers</see> with all the defined values
        /// </summary>
        /// <returns>Returns a <see cref="GetMatchers">GetMatchers</see> class</returns>
        public GetMatchers Build()
        {
            return new GetMatchers(this._integrationId)
            {
                IntegrationId = this._integrationId,
                Identifier = this._identifier,
                CompanyId = this._companyId,
                Matched = this._matched,
                Page = this._page,
                PageSize = this._pageSize,
                SyncId = this._syncId
            };
        }

        /// <summary>
        /// Filter on the integrators company id
        /// </summary>
        /// <param name="companyId">The company identifier.</param>
        /// <returns>A generic Builder Object for type <typeparamref name="TBuilder"/></returns>
        public GetMatchersBuilder WithCompanyId(int companyId)
        {
            _companyId = companyId;
            return this;
        }

        /// <summary>
        /// Filter by Identifier in the integration (if sync_id is not set). This is used if the id
        /// that the integration uses is a string.
        /// </summary>
        /// <param name="identifier">The identifier.</param>
        /// <returns>A generic Builder Object for type <typeparamref name="TBuilder"/></returns>
        public GetMatchersBuilder Withidentifier(string identifier)
        {
            _identifier = identifier;
            return this;
        }

        /// <summary>
        /// Filter on whether the company has already been matched
        /// </summary>
        /// <param name="matched">if set to <c>true</c> [matched].</param>
        /// <returns>A generic Builder Object for type <typeparamref name="TBuilder"/></returns>
        public GetMatchersBuilder WithMatched(bool matched)
        {
            _matched = matched;
            return this;
        }

        /// <summary>
        /// get current page of results
        /// </summary>
        /// <param name="page">The page.</param>
        /// <returns>A generic Builder Object for type <typeparamref name="TBuilder"/></returns>
        public GetMatchersBuilder WithPage(int page)
        {
            _page = page;
            return this;
        }

        /// <summary>
        /// Number of results to return
        /// </summary>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>A generic Builder Object for type <typeparamref name="TBuilder"/></returns>
        public GetMatchersBuilder WithPageSize(int pageSize)
        {
            _pageSize = pageSize;
            return this;
        }

        /// <summary>
        /// Filter by ID of the record in the integration. This is used if the id that the
        /// integration uses is an integer.
        /// </summary>
        /// <param name="syncId">The synchronize identifier.</param>
        /// <returns>A generic Builder Object for type <typeparamref name="TBuilder"/></returns>
        public GetMatchersBuilder WithsyncId(string syncId)
        {
            _syncId = syncId;
            return this;
        }
    }
}