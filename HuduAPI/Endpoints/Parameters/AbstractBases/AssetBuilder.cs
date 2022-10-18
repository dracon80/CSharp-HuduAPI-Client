using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuduAPI.Endpoints.Parameters.AbstractBases
{
    /// <summary>
    /// Builder for the class <see cref="Asset">Asset</see>
    /// </summary>
    public abstract class AssetBuilder<TResult, TBuilder>
        where TResult : Asset
        where TBuilder : AssetBuilder<TResult, TBuilder>
    {
        protected int _assetLayoutId;
        protected int _companyId;
        protected AssetCustomField _customFields;
        protected string _name;
        protected string? _primaryMail;
        protected string? _primaryManufacturer;
        protected string? _primaryModel;
        protected string? _primarySerial;

        /// <summary>
        /// Gets the builder instance of the implmenting class type.
        /// </summary>
        private readonly TBuilder _builderInstance = null;

        /// <summary>
        /// Create a new instance for the <see cref="AssetBuilder">AssetBuilder</see>
        /// </summary>
        internal AssetBuilder(int companyId, int assetLayoutId, string name)
        {
            _companyId = companyId;
            _assetLayoutId = assetLayoutId;
            _name = name;
            _primarySerial = default;
            _primaryMail = default;
            _primaryModel = default;
            _primaryManufacturer = default;
            _customFields = new AssetCustomField();

            _builderInstance = (TBuilder)this;
        }

        public abstract TResult Build();

        /// <summary>
        /// Add a new custom_field item to the asset.
        /// </summary>
        /// <param name="key">The key must match the lable of a field for the destination asset_layout.</param>
        /// <param name="value">The value to assign to the custom field.</param>
        /// <returns>A generic Builder Object for type <typeparamref name="TBuilder"/></returns>
        public TBuilder WithCustomField(string key, string value)
        {
            _customFields.Add(key.ToLower(), value);
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for primaryMail
        /// </summary>
        /// <param name="primaryMail">The primary mail.</param>
        /// <returns>A generic Builder Object for type <typeparamref name="TBuilder"/></returns>
        public TBuilder WithPrimaryMail(string primaryMail)
        {
            _primaryMail = primaryMail;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for primaryManufacturer
        /// </summary>
        /// <param name="primaryManufacturer">The primary manufacturer.</param>
        /// <returns>A generic Builder Object for type <typeparamref name="TBuilder"/></returns>
        public TBuilder WithPrimaryManufacturer(string primaryManufacturer)
        {
            _primaryManufacturer = primaryManufacturer;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for primaryModel
        /// </summary>
        /// <param name="primaryModel">The primary model.</param>
        /// <returns>A generic Builder Object for type <typeparamref name="TBuilder"/></returns>
        public TBuilder WithPrimaryModel(string primaryModel)
        {
            _primaryModel = primaryModel;
            return _builderInstance;
        }

        /// <summary>
        /// Set a value for primarySerial
        /// </summary>
        /// <param name="primarySerial">The primary serial.</param>
        /// <returns>A generic Builder Object for type <typeparamref name="TBuilder"/></returns>
        public TBuilder WithPrimarySerial(string primarySerial)
        {
            _primarySerial = primarySerial;
            return _builderInstance;
        }
    }
}