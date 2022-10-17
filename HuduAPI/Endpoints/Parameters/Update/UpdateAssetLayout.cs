using HuduAPI.Endpoints.Parameters.AbstractBases;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Provides all the properties required to call the endpoint api/v1/asset_layouts when updating
    /// an asset_layout
    /// </summary>
    /// <seealso cref="HuduAPI.Endpoints.Parameters.AbstractBases.AssetLayout" />
    public class UpdateAssetLayout : AssetLayout, IParameters
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssetLayout" /> class with the
        /// required properties to update and existing asset_layout.
        /// </summary>
        /// <param name="id">
        /// The identifier of the existing asset_layout.
        /// </param>
        /// <param name="name">
        /// The name of the asset_layout.
        /// </param>
        /// <param name="icon">
        /// The icon to display.
        /// </param>
        /// <param name="color">
        /// The background color.
        /// </param>
        /// <param name="iconColor">
        /// Color of the icon.
        /// </param>
        /// <param name="assetLayoutFields">
        /// The asset layout fields to be added to the existing layout. Do not provive existing field definitions
        /// </param>
        public UpdateAssetLayout(int id, string name, string icon, Color color, Color iconColor, List<AssetLayoutField> assetLayoutFields) : base(name, icon, color, iconColor, assetLayoutFields)
        {
            this.Id = id;
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonIgnore]
        public int Id { get; }

        /// <summary>
        /// Set the Payload wrapper for the json
        /// </summary>
        [JsonIgnore]
        public string PayloadType
        {
            get
            {
                return "asset_layout";
            }
        }


        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="UpdateAssetLayout"/> is active within hudu.
        /// </summary>
        /// <value>
        ///   <c>true</c> if active; otherwise, <c>false</c>.
        /// </value>
        public Boolean Active { get; set; }
    }
}