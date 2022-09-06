namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Paramaters to Get a single Article from Hudu
    /// </summary>
    /// <seealso cref="HuduAPI.Endpoints.Parameters.IParameters" />
    public class GetArticle : BaseGet, IParameters
    {
        public GetArticle(int id) : base(id)
        {
        }
    }
}