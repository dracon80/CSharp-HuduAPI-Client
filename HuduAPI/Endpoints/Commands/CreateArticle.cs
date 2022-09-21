using HuduAPI.Endpoints.Receivers;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Commands
{
    internal class CreateArticle : ICommand<Article>
    {
        private readonly string _apiKey;
        private readonly Parameters.CreateArticle _params;
        private readonly string _url;

        public CreateArticle(String huduBaseURL, string huduAPIKey, Parameters.CreateArticle parameters)
        {
            _apiKey = huduAPIKey;
            _params = parameters;
            _url = huduBaseURL + "api/v1/articles/";
        }

        public Article Execute()
        {
            var result = BaseReceiver<ArticleRoot, Parameters.CreateArticle>.Create(
                url: _url,
                apiKey: _apiKey,
                parameters: _params
                );

            if (result == null)
            {
                throw new HttpRequestException("There was an error creating the new Article");
            }

            return result.Article;
        }
    }
}