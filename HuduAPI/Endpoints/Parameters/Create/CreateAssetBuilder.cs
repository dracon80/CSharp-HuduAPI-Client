using HuduAPI.Endpoints.Parameters.AbstractBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Builder class to help build a new <see cref="CreateAsset" /> paramater object.
    /// </summary>
    public class CreateAssetBuilder : AssetBuilder<CreateAsset, CreateAssetBuilder>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetBuilder" /> class.
        /// </summary>
        /// <param name="asset_id">
        /// The asset identifier.
        /// </param>
        /// <param name="companyId">
        /// The company identifier.
        /// </param>
        /// <param name="assetLayoutId">
        /// The asset layout identifier.
        /// </param>
        /// <param name="name">
        /// The name.
        /// </param>
        public CreateAssetBuilder(int companyId, int assetLayoutId, string name) : base(companyId, assetLayoutId, name)
        {
        }

        /// <summary>
        /// Builds a new instance of type <see cref="CreateAssetBuilder" />.
        /// </summary>
        public override CreateAsset Build()
        {
            return new CreateAsset(_companyId, _assetLayoutId, _name)
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