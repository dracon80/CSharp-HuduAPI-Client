using HuduAPI.Endpoints.Exceptions;
using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class ArchiveCompany : ICommand<Company>
    {
        private readonly string _apiKey;
        private readonly Parameters.ItemById _params;
        private readonly string _url;

        public ArchiveCompany(String huduBaseURL, string huduAPIKey, Parameters.ItemById parameters, Boolean archive)
        {
            _params = parameters ?? throw new ArgumentNullException("ArchiveCompany parameters cannot be null");
            if (archive)
            {
                _url = huduBaseURL + "api/v1/companies/" + _params.ID + "/archive";
            }
            else
            {
                _url = huduBaseURL + "api/v1/companies/" + _params.ID + "/unarchive";
            }

            _apiKey = huduAPIKey;
        }

        public Company Execute()
        {
            var result = BaseReceiver<CompanyRoot, Parameters.ItemById>.Archive(
                url: _url,
                apiKey: _apiKey
                );

            if (result == null)
            {
                throw new RecordNotFoundException("Company ID: " + _params.ID + " was not found");
            }

            return result.Company;
        }
    }
}