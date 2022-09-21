using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class UpdateArticle : ICommand<Article>
    {
        private readonly string _apiKey;
        private readonly Parameters.UpdateArticle _params;
        private readonly string _url;

        public UpdateArticle(String huduBaseURL, string huduAPIKey, Parameters.UpdateArticle parameters)
        {
            _apiKey = huduAPIKey;
            _url = huduBaseURL + "api/v1/articles/" + parameters.Id;
            _params = parameters;
        }

        public Article Execute()
        {
            var result = BaseReceiver<ArticleRoot, Parameters.UpdateArticle>.Update(
                url: _url,
                apiKey: _apiKey,
                parameters: _params
                );

            if (result == null)
            {
                throw new HttpRequestException("There was an error updating the new Article");
            }

            return result.Article;
        }
    }
}