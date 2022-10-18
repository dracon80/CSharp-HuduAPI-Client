﻿using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class CreateFolder : ICommand<Folder>
    {
        private readonly string _apiKey;
        private readonly Parameters.CreateFolder _params;
        private readonly string _url;

        public CreateFolder(String huduBaseURL, string huduAPIKey, Parameters.CreateFolder parameters)
        {
            _apiKey = huduAPIKey;
            _params = parameters;
            _url = huduBaseURL + "api/v1/folders/";
        }

        public Folder Execute()
        {
            var result = BaseReceiver<FolderRoot, Parameters.CreateFolder>.Create(
                url: _url,
                apiKey: _apiKey,
                parameters: _params
                );

            if (result == null)
            {
                throw new HttpRequestException("There was an error creating the new Folder");
            }

            return result.Folder;
        }
    }
}