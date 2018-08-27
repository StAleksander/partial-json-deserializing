using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace PartialDeserializer
{
    public class PartialDeserializer<T> 
    {
        private readonly DeserializationPossibilityChecker<T> _deserializeChecker;

        public PartialDeserializer(DeserializationPossibilityChecker<T> deserializeChecker)
        {
            _deserializeChecker = deserializeChecker;
        }
        
        public IEnumerable<T> Deserialize(string json)
        {
            var rootToken =  JToken.Parse(json);
            foreach (var token in rootToken.GetChildrenRecursive())
            {
                if (_deserializeChecker.CheckDeserializtionPossibility(token))
                {
                    var obj = token.ToObject<T>();
                    yield return obj;
                }
            }
        }   
    }
}