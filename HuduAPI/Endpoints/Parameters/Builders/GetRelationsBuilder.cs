using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Builder for the class <see cref="GetRelations">GetRelations</see>
    /// </summary>
    public class GetRelationsBuilder
    {
        private int? _page;
        private int? _pageSize;

        /// <summary>
        /// Create a new instance for the <see cref="GetRelationsBuilder">GetRelationsBuilder</see>
        /// </summary>
        public GetRelationsBuilder()
        {
            Reset();
        }

        /// <summary>
        /// Reset all properties' to the default value
        /// </summary>
        /// <returns>
        /// Returns the <see cref="GetRelationsBuilder">GetRelationsBuilder</see> with the
        /// properties reseted
        /// </returns>
        public GetRelationsBuilder Reset()
        {
            _page = default;
            _pageSize = default;

            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int" /> for the property <paramref name="page">page</paramref>
        /// </summary>
        /// <param name="page">
        /// A value of type <typeparamref name="int?" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetRelationsBuilder">GetRelationsBuilder</see> with the property
        /// <paramref name="page">page</paramref> defined
        /// </returns>
        public GetRelationsBuilder WithPage(int page)
        {
            _page = page;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int" /> for the property <paramref name="pageSize">pageSize</paramref>
        /// </summary>
        /// <param name="pageSize">
        /// A value of type <typeparamref name="int?" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetRelationsBuilder">GetRelationsBuilder</see> with the property
        /// <paramref name="pageSize">pageSize</paramref> defined
        /// </returns>
        public GetRelationsBuilder WithPageSize(int pageSize)
        {
            _pageSize = pageSize;
            return this;
        }

        /// <summary>
        /// Build a class of type <see cref="GetRelations">GetRelations</see> with all the defined values
        /// </summary>
        /// <returns>
        /// Returns a <see cref="GetRelations">GetRelations</see> class
        /// </returns>
        public GetRelations Build()
        {
            return new GetRelations
            {
                Page = _page,
                PageSize = _pageSize,
            };
        }
    }
}