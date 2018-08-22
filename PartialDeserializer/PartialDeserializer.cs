using System;

namespace PartialDeserializer
{
    public static class PartialDeserializer
    {
        public static T Deserialize<T>(string json)
        {
            return default(T);
        }
    }
}