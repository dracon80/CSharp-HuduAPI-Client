namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Provides the paramaters to target a single Asset from the Hudu endpoint.
    /// </summary>
    public class AssetById : ItemById, IParameters
    {
        /// <summary>
        /// The companyID that the asset belongs too.
        /// </summary>
        public int _companyId { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetById" /> class.
        /// </summary>
        /// <param name="id">
        /// The identifier.
        /// </param>
        /// <param name="companyId">
        /// The company identifier.
        /// </param>
        public AssetById(int id, int companyId) : base(id)
        {
            _companyId = companyId;
        }
    }
}