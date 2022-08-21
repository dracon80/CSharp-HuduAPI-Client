using Newtonsoft.Json.Serialization;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// </summary>
    public interface IParameters
    {
    }

    internal static class IParameterExtensions
    {
        private static readonly DefaultContractResolver _defaultResolver = new()
        {
            NamingStrategy = new SnakeCaseNamingStrategy()
        };

        public static IDictionary<string, object> GetPropertyDictionary(this IParameters parameters, IContractResolver? resolver = null)
        {
            if (parameters == null)
                throw new ArgumentNullException();

            resolver = resolver ?? _defaultResolver;

            var contract = resolver.ResolveContract(parameters.GetType()) as JsonObjectContract;

            Dictionary<string, object> result = new Dictionary<string, object>();

            //No Contract returned so return an empty Dictionary
            if (contract == null)
                return result;

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