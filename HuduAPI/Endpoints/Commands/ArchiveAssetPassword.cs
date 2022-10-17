using Flurl.Http;
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
    internal class ArchiveAssetPassword : ICommand<AssetPassword>
    {
        private readonly string _apiKey;
        private readonly Parameters.ItemById _params;
        private readonly string _url;

        public ArchiveAssetPassword(String huduBaseURL, string huduAPIKey, Parameters.ItemById parameters, Boolean archive)
        {
            _params = parameters ?? throw new ArgumentNullException("ArchiveAssetPassword parameters cannot be null");
            if (archive)
            {
                _url = huduBaseURL + "api/v1/asset_passwords/" + _params.ID + "/archive";
            }
            else
            {
                _url = huduBaseURL + "api/v1/asset_passwords/" + _params.ID + "/unarchive";
            }

            _apiKey = huduAPIKey;
        }

        public AssetPassword Execute()
        {
            var result = BaseReceiver<AssetPasswordRoot, Parameters.ItemById>.Archive(
                url: _url,
                apiKey: _apiKey
                );

            if (result == null)
            {
                throw new RecordNotFoundException("AssetPassword ID: " + _params.ID + " was not found");
            }

            return result.AssetPassword;
        }
    }
}