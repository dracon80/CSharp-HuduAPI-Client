namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Provides the paramaters to get a single website from the hudu endpoint api/v1/websites
    /// </summary>
    /// <seealso cref="HuduAPI.Endpoints.Parameters.BaseGet" />
    /// <seealso cref="HuduAPI.Endpoints.Parameters.IParameters" />
    public class GetWebsite : BaseGet, IParameters
    {
        public GetWebsite(int id) : base(id)
        {
        }
    }
}