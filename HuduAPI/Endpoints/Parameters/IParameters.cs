using Newtonsoft.Json.Serialization;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// All endpoint parameters must implement this interface to allow extension methods related to paramters.
    /// </summary>
    public interface IParameters
    {
    }

    /// <summary>
    /// Contains extension methods that can be run against any object that implements the IParameter interface
    /// </summary>
    internal static class IParameterExtensions
    {
        /// <summary>
        /// By default Hudu uses snake_case for all paramater names, so this is a json resolver that
        /// uses snake_case.
        /// </summary>
        private static readonly DefaultContractResolver _defaultResolver = new()
        {
            NamingStrategy = new SnakeCaseNamingStrategy()
        };

        /// <summary> Builds and returns a dictionary of paramater names and thier values.
        /// </summary> <remarks> Hudu uses snake_case naming for all paramaters, this method
        /// provides the ability to format a parameters properties to meet these needs. </remarks>
        /// <param name="parameters"> The parameters. </param> <param name="resolver"> The resolver.
        /// </param> <returns> Return a dictionary object containing snake_case formated property
        /// names, along with thier values. </returns> <exception
        /// cref="System.ArgumentNullException"> If parameters is provided with a null value then a
        /// <see cref="System.ArgumentNullException""/> will be raised. </exception>
        public static IDictionary<string, object> GetPropertyDictionary(this IParameters parameters, IContractResolver? resolver = null)
        {
            if (parameters == null)
                throw new ArgumentNullException();

            //Use the supplied resolver if not null
            resolver = resolver ?? _defaultResolver;

            var contract = resolver.ResolveContract(parameters.GetType()) as JsonObjectContract;

            Dictionary<string, object> result = new Dictionary<string, object>();

            //No Contract returned so return an empty Dictionary
            if (contract == null)
                return result;

            //Loop through all properties and convert the property name to snake_case.
            foreach (var property in contract.Properties.Where(p => !p.Ignored))
            {
                var value = property.ValueProvider.GetValue(parameters);

                if (value != null)
                {
                    result.Add(property.PropertyName, value);
                }
            }

            return result;
        }
    }
}