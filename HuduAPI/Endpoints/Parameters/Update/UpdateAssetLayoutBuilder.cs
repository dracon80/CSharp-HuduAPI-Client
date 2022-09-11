using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using HuduAPI.Endpoints.Parameters;
using HuduAPI.Endpoints.Parameters.AbstractBases;
using HuduAPI.Records;

namespace HuduAPI.Endpoints.Parameters
{
    public class UpdateAssetLayoutBuilder : AssetLayoutBuilder<UpdateAssetLayout, UpdateAssetLayoutBuilder>
    {
        protected int _id;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssetLayoutBuilder" /> class.
        /// </summary>
        /// <param name="id">
        /// The identifier of the existing asset_layout.
        /// </param>
        /// <param name="name">
        /// The name of the asset_layout.
        /// </param>
        /// <param name="icon">
        /// The icon to be used in the gui.
        /// </param>
        /// <param name="color">
        /// The color of the icon foreground.
        /// </param>
        /// <param name="iconColor">
        /// Color of the icon background.
        /// </param>
        /// <param name="assetLayoutFields">
        /// A list of asset layout fields that define the layout.
        /// </param>
        public UpdateAssetLayoutBuilder(int id, string name, string icon, Color color, Color iconColor, List<AssetLayoutField> assetLayoutFields) : base(name, icon, color, iconColor, assetLayoutFields)
        {
            _id = id;
        }

        /// <summary>
        /// Build a class of type <see cref="AssetLayouts">CreateAssetLayouts</see> with all the
        /// defined values
        /// </summary>
        /// <returns>
        /// Returns a <see cref="AssetLayouts">CreateAssetLayouts</see> class
        /// </returns>
        public override UpdateAssetLayout Build()
        {
            return new UpdateAssetLayout(_id, _name, _icon, _color, _iconColor, _fields)
            {
                IncludePasswords = _includePasswords,
                IncludeComments = _includeComments,
                IncludeFiles = _includeFiles,
                IncludePhotos = _includePhotos,
                PasswordTypes = _passwordTypes
            };
        }
    }
}