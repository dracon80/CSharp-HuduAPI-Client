using Newtonsoft.Json;
using System.Drawing;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Defines the properties to be used when creating a new AssetLayout in Hudu using the endpoint api/v1/asset_layouts
    /// </summary>
    public class CreateAssetLayout : AbstractBases.AssetLayout, IParameters
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetLayout" /> class with all
        /// required properties to call the hudu endpoint api/v1/asset_layouts.
        /// </summary>
        /// <param name="name">
        /// The name of the new asset_layout.
        /// </param>
        /// <param name="icon">
        /// The Icon class name, example: “fas fa-home”.
        /// </param>
        /// <param name="color">
        /// The Color for background color.
        /// </param>
        /// <param name="iconColor">
        /// Color of the icon foreground.
        /// </param>
        /// <param name="assetLayoutFields">
        /// The asset layout fields.
        /// </param>
        /// <remarks>
        /// All other properties of the class are optional properties that can safely be left blank
        /// and still be able to call the endpoint
        /// </remarks>
        public CreateAssetLayout(string name, string icon, Color color, Color iconColor, List<AssetLayoutField> assetLayoutFields) : base(name, icon, color, iconColor, assetLayoutFields)
        {
        }

        public string PayloadType
        {
            get
            {
                return "asset_layout";
            }
        }
    }
}