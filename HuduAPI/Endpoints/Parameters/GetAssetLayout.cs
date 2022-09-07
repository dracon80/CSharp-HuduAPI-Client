using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Paramaters to Get a single asset_layout from Hudu
    /// </summary>
    public class GetAssetLayout : BaseGet, IParameters
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetLayout" /> class.
        /// </summary>
        /// <param name="id">
        /// The Article ID.
        /// </param>
        public GetAssetLayout(int id) : base(id)
        {
        }
    }
}