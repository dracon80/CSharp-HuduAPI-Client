namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Provides the paramters to get a single procedure from the hudu endpoint api/v1/procedures
    /// </summary>
    /// <seealso cref="HuduAPI.Endpoints.Parameters.BaseGet" />
    /// <seealso cref="HuduAPI.Endpoints.Parameters.IParameters" />
    public class GetProcedure : BaseGet, IParameters
    {
        public GetProcedure(int id) : base(id)
        {
        }
    }
}