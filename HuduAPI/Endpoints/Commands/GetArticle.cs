using HuduAPI.Endpoints.Exceptions;
using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints.Commands
{
    /// <summary>
    /// Command Class to implement the methods of calling the Hudu API endpoint
    /// </summary>
    internal class GetArticle : ICommand<Article>
    {
        private readonly Parameters.ItemById _getParams;
        private readonly string _url;
        private readonly string _apiKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetArticle" /> class.
        /// </summary>
        /// <param name="huduBaseURL">
        /// The hudu base URL.
        /// </param>
        /// <param name="huduAPIKey">
        /// The hudu API key.
        /// </param>
        /// <param name="parameters">
        /// The parameters used for the API call.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// GetArticle parameters cannot be null
        /// </exception>
        public GetArticle(String huduBaseURL, string huduAPIKey, Parameters.ItemById parameters)
        {
            _getParams = parameters ?? throw new ArgumentNullException("GetArticle parameters cannot be null");
            _url = huduBaseURL + "api/v1/articles/" + _getParams.ID;
            _apiKey = huduAPIKey;
        }

        /// <summary>
        /// Executes the command to retrive a single Article from the Hudu API.
        /// </summary>
        /// <returns>
        /// Returns an Article object if found
        /// </returns>
        /// <exception cref="HuduAPI.Endpoints.Exceptions.RecordNotFoundException">
        /// If the article was not found than an Exception is raised
        /// </exception>
        public Article Execute()
        {
            var result = BaseReceiver<ArticleRoot, Parameters.ItemById>.Get(
                url: _url,
                apiKey: _apiKey
                );

            if (result == null)
            {
                throw new RecordNotFoundException("Article ID: " + _getParams.ID + " was not found");
            }

            return result.Article;
        }
    }
}