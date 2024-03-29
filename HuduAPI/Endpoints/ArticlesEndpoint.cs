﻿using HuduAPI.Endpoints.Parameters;
using HuduAPI.Records;
using System.Runtime.InteropServices;

namespace HuduAPI.Endpoints
{
    /// <summary>
    /// Provides all the methods required to make calls to the articles endpoint of the Hudu API.
    /// </summary>
    /// <remarks>
    /// The articles endpoint is a full CRUD endpoint and provides all methods required to create,
    /// read, update delete and archive.
    /// </remarks>
    public class ArticlesEndpoint :
        IEndpoint, IEndpointGetMethod<Article, ItemById>,
        IEndpointGetMethod<Articles, GetArticles>,
        IEndpointCreateMethod<Article, CreateArticle>,
        IEndpointUpdateMethod<Article, UpdateArticle>,
        IEndpointDeleteMethod<ItemById>,
        IEndpointArchiveMethod<Article, ItemById>
    {
        /// <summary>
        /// Initializes a new instance of the endpoint class ready to communicate with the Hudu API.
        /// </summary>
        /// <param name="huduAPIKey">
        /// The hudu API key.
        /// </param>
        /// <param name="huduBaseURL">
        /// The hudu base URL.
        /// </param>
        public ArticlesEndpoint(string huduAPIKey, string huduBaseURL)
        {
            HuduAPIKey = huduAPIKey;
            HuduBaseURL = huduBaseURL;
        }

        /// <summary>
        /// Gets or sets the hudu API key that will be used for all calls to this Endpoint.
        /// </summary>
        /// <value>
        /// The hudu API key.
        /// </value>
        public string HuduAPIKey { get; set; }

        /// <summary>
        /// Gets or sets the hudu base URL that will be used for all calls to the Endpoint.
        /// </summary>
        /// <value>
        /// The hudu base URL.
        /// </value>
        public string HuduBaseURL { get; set; }

        /// <summary>
        /// Archives or unarchives the Article with the supplied ID
        /// </summary>
        /// <param name="parameters">
        /// The parameters to use when making the call.
        /// </param>
        /// <param name="archive">
        /// Should the item be archived? True will archive the item, fales will unarchive the item
        /// </param>
        /// <returns>
        /// An object of type <typeparamref name="TResult" /> that represents the created object in hudu
        /// </returns>
        public Article Archive(ItemById parameters, bool archive)
        {
            Commands.ArchiveArticle myCommand = new Commands.ArchiveArticle(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters, archive: archive);
            return myCommand.Execute();
        }

        /// <summary>
        /// Performs a Create method call on the Hudu API to create a new article
        /// </summary>
        /// <param name="parameters">
        /// The parameters to use when making the call.
        /// </param>
        /// <returns>
        /// An object of type <see cref="Article" /> that represents the created object in hudu
        /// </returns>
        public Article Create(CreateArticle parameters)
        {
            Commands.CreateArticle myCommand = new Commands.CreateArticle(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }

        /// <summary>
        /// Deletes the Article ID from hudu using the Hudu API endpoint for delete
        /// </summary>
        /// <param name="parameters">
        /// The parameters to use when making the call.
        /// </param>
        public void Delete(ItemById parameters)
        {
            Commands.DeleteArticle myCommand = new Commands.DeleteArticle(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            myCommand.Execute();
        }

        /// <summary>
        /// Performs a get call to the api/v1/articles/:id endpoint on the Hudu API
        /// </summary>
        /// <param name="parameters">
        /// The parameters to use when making the call.
        /// </param>
        /// <returns>
        /// A single article object will be returned using the ID provided
        /// </returns>
        /// <exception cref="HuduAPI.Endpoints.Exceptions.RecordNotFoundException">
        /// If the article is not found than an exception is raised
        /// </exception>
        public Article Get(ItemById parameters)
        {
            Commands.GetArticle myCommand = new Commands.GetArticle(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }

        /// <summary>
        /// Performs a get call to the api/v1/articles/ endpoint on the Hudu API
        /// </summary>
        /// <param name="parameters">
        /// The parameters to use when making the call.
        /// </param>
        /// <returns>
        /// A single Articles object containing a list of articles
        /// </returns>
        public Articles Get([Optional] GetArticles parameters)
        {
            Commands.GetArticles myCommand = new Commands.GetArticles(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }

        /// <summary>
        /// Performs an update on the supplied Article ID using the parameters supplied.
        /// </summary>
        /// <param name="parameters">
        /// The parameters to use when making the call.
        /// </param>
        /// <returns>
        /// An object of type <see cref="Article" /> that represents the created object in hudu
        /// </returns>
        public Article Update(UpdateArticle parameters)
        {
            Commands.UpdateArticle myCommand = new Commands.UpdateArticle(huduBaseURL: HuduBaseURL, huduAPIKey: HuduAPIKey, parameters: parameters);
            return myCommand.Execute();
        }
    }
}