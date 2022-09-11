using HuduAPI.Endpoints.Parameters.AbstractBases;
using HuduAPI.Records;
using System.Drawing;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// This builder allows for easy creation of a new <see cref="CreateAssetLayout" /> instance
    /// used when calling api/v1/asset_layouts to create a new asset_layout.
    /// </summary>
    public class CreateAssetLayoutBuilder : AssetLayoutBuilder<CreateAssetLayout, CreateAssetLayoutBuilder>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetLayoutBuilder" /> class with all
        /// required properties set to call the hudu endpoint api/v1/asset_layouts.
        /// </summary>
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
        public CreateAssetLayoutBuilder(string name, string icon, Color color, Color iconColor, List<AssetLayoutField> assetLayoutFields) : base(name, icon, color, iconColor, assetLayoutFields)
        {
        }

        /// <summary>
        /// Build a class of type <see cref="AssetLayouts">CreateAssetLayouts</see> with all the
        /// defined values
        /// </summary>
        /// <returns>
        /// Returns a <see cref="AssetLayouts">CreateAssetLayouts</see> class
        /// </returns>
        public override CreateAssetLayout Build()
        {
            return new CreateAssetLayout(_name, _icon, _color, _iconColor, _fields)
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