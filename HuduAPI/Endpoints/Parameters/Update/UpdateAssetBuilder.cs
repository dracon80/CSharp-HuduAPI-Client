using HuduAPI.Endpoints.Parameters.AbstractBases;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Builder class to help build a new <see cref="UpdateAsset"/> paramater object.
    /// </summary>
    public class UpdateAssetBuilder : AssetBuilder<UpdateAsset, UpdateAssetBuilder>
    {
        private readonly int _assetId;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssetBuilder"/> class.
        /// </summary>
        /// <param name="asset_id">The asset identifier.</param>
        /// <param name="companyId">The company identifier.</param>
        /// <param name="assetLayoutId">The asset layout identifier.</param>
        /// <param name="name">The name.</param>
        public UpdateAssetBuilder(int asset_id, int companyId, int assetLayoutId, string name) : base(companyId, assetLayoutId, name)
        {
            _assetId = asset_id;
        }

        /// <summary>
        /// Builds a new instance of type <see cref="UpdateAssetBuilder"/>.
        /// </summary>
        /// <returns></returns>
        public override UpdateAsset Build()
        {
            return new UpdateAsset(_assetId, _companyId, _assetLayoutId, _name)
            {
                PrimarySerial = _primarySerial,
                PrimaryMail = _primaryMail,
                PrimaryManufacturer = _primaryManufacturer,
                PrimaryModel = _primaryModel,
                CustomFields = _customFields
            };
        }
    }
}