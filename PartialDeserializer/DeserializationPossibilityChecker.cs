using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace PartialDeserializer
{
    public class DeserializationPossibilityChecker<T>
    {
        private readonly IEnumerable<string> _propertyNames;

        public DeserializationPossibilityChecker()
        {
            _propertyNames = typeof(T).GetProperties().Select(p => p.Name).ToArray();
        }
        
        public bool CheckDeserializtionPossibility(JToken token)
        {
            var tokenProperyNames = token.Children<JProperty>().Select(p => p.Name);
            return tokenProperyNames.SequenceEqual(_propertyNames); 
        }
    }
}