namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Provides the paramaters to get a single Asset from the Hudu endpoint.
    /// </summary>
    public class GetAsset : BaseGet, IParameters
    {
        /// <summary>
        /// The companyID that the asset belongs too.
        /// </summary>
        public int _companyId { get; set; }

        public GetAsset(int id, int companyId) : base(id)
        {
            _companyId = companyId;
        }
    }
}