﻿using Flurl.Http;
using HuduAPI.Endpoints.Exceptions;
using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;
using System;

namespace HuduAPI.Endpoints.Commands
{
    internal class DeleteRelation : ICommand
    {
        private readonly string _apiKey;
        private readonly Parameters.ItemById _params;
        private readonly string _url;

        public DeleteRelation(String huduBaseURL, string huduAPIKey, Parameters.ItemById parameters)
        {
            _params = parameters ?? throw new ArgumentNullException("DeleteRelation parameters cannot be null");
            _url = huduBaseURL + "api/v1/relations/" + _params.ID;
            _apiKey = huduAPIKey;
        }

        public void Execute()
        {
            var result = _url.WithHeader("x-api-key", _apiKey).DeleteAsync().Result;

            return;
        }
    }
}