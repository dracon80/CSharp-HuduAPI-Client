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
    /// Provides all the properties that can be used to create a new asset using the hudu endpoint api/v1/companies/:company_id/assets
    /// </summary>
    /// <seealso cref="HuduAPI.Endpoints.Parameters.AbstractBases.Asset"/>
    public class CreateAsset : Asset, IParameters
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAsset"/> class.
        /// </summary>
        /// <param name="companyId">The company identifier.</param>
        /// <param name="assetLayoutId">The asset layout identifier.</param>
        /// <param name="name">The name.</param>
        public CreateAsset(int companyId, int assetLayoutId, string name) : base(companyId, assetLayoutId, name)
        {
        }

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