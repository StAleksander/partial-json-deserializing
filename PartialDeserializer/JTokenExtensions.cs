using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace PartialDeserializer
{
    public static class JTokenExtensions
    {
        //todo: unroll recursion - https://stackoverflow.com/questions/2012274/how-to-unroll-a-recursive-structure
        public static IEnumerable<JToken> GetChildrenRecursive( this JToken token )
        {
            var childen = token.Children<JToken>();
            foreach (var child in childen)
            {
                yield return child;
                foreach (var childOfChild in GetChildrenRecursive(child))
                {
                    yield return childOfChild;
                }
            }
        }
    }
}