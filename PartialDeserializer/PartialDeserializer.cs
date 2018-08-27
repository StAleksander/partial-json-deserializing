using System.Collections.Generic;

namespace PartialDeserializer
{
    public static class PartialDeserializer
    {
        public static IEnumerable<T> Deserialize<T>(string json)
        {
            var deserializer = new PartialDeserializer<T>( new DeserializationPossibilityChecker<T>());
            return deserializer.Deserialize(json);
        }
    }
}