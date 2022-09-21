namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Provides the paramaters to target a single Asset from the Hudu endpoint. This is needed
    /// because the Call tot he asset endpoint required additional information such as the company ID.
    /// </summary>
    public class AssetById : ItemById, IParameters
    {
        /// <summary>
        /// The companyID that the asset belongs too.
        /// </summary>
        private int _companyId { get; set; }

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

        /// <summary>
        /// Gets the company identifier.
        /// </summary>
        /// <value>
        /// The company identifier.
        /// </value>
        public int CompanyId
        {
            get { return _companyId; }
        }
    }
}