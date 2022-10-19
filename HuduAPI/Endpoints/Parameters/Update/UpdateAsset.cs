using HuduAPI.Endpoints.Parameters.AbstractBases;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Provides all the properties to update an existing Asset in hudu.
    /// </summary>
    /// <seealso cref="HuduAPI.Endpoints.Parameters.AbstractBases.Asset"/>
    public class UpdateAsset : Asset, IParameters
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAsset"/> class.
        /// </summary>
        /// <param name="asset_id">The asset identifier.</param>
        /// <param name="companyId">The company identifier.</param>
        /// <param name="assetLayoutId">The asset layout identifier.</param>
        /// <param name="name">The name.</param>
        public UpdateAsset(int asset_id, int companyId, int assetLayoutId, string name) : base(companyId, assetLayoutId, name)
        {
            AssetId = asset_id;
        }

        /// <summary>
        /// Gets the asset identifier.
        /// </summary>
        /// <value>The asset identifier.</value>
        [JsonIgnore]
        public int AssetId { get; private set; }

        [JsonIgnore]
        public string PayloadType
        {
            get
            {
                return "asset";
            }
        }
    }
}