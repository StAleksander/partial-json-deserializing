using Newtonsoft.Json.Linq;
using PartialDeserializer.UnitTests.Models;
using Xunit;

namespace PartialDeserializer.UnitTests
{
    public class DeserializationPossibilityCheckerTests
    {
        [Fact]
        public void Check_Success()
        {
            var token = JToken.FromObject(new СashierInfo());
            var checker = new DeserializationPossibilityChecker<СashierInfo>();
            checker.CheckDeserializtionPossibility(token);
        }
        
        [Fact]
        public void Check_NotSuccess()
        {
            var token = JToken.FromObject(new OrderItem());
            var checker = new DeserializationPossibilityChecker<СashierInfo>();
            checker.CheckDeserializtionPossibility(token);
        }
    }
}