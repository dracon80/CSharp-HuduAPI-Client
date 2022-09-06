using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Builder for the class <see cref="GetArticle">GetArticle</see>
    /// </summary>
    public class GetArticleBuilder
    {
        private int id;

        /// <summary>
        /// Create a new instance for the <see cref="GetArticleBuilder">GetArticleBuilder</see>
        /// </summary>
        public GetArticleBuilder()
        {
            Reset();
        }

        /// <summary>
        /// Reset all properties' to the default value
        /// </summary>
        /// <returns>
        /// Returns the <see cref="GetArticleBuilder">GetArticleBuilder</see> with the properties reseted
        /// </returns>
        public GetArticleBuilder Reset()
        {
            id = default;

            return this;
        }

        /// <summary>
        /// Set a value of type <see cref="int">int</see> for the property <paramref name="id">id</paramref>
        /// </summary>
        /// <param name="id">
        /// A value of type <typeparamref name="int" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetArticleBuilder">GetArticleBuilder</see> with the property
        /// <paramref name="id">id</paramref> defined
        /// </returns>
        public GetArticleBuilder WithID(int id)
        {
            this.id = id;
            return this;
        }

        /// <summary>
        /// Build a class of type <see cref="GetArticle">GetArticle</see> with all the defined values
        /// </summary>
        /// <returns>
        /// Returns a <see cref="GetArticle">GetArticle</see> class
        /// </returns>
        public GetArticle Build()
        {
            return new GetArticle(id);
        }
    }
}