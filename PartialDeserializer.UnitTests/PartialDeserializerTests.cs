using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Newtonsoft.Json;
using PartialDeserializer;
using PartialDeserializer.UnitTests.Models;
using Xunit;

namespace PartialDeserializer.UnitTests
{
    
    public class PartialDeserializerTests
    {
        [Fact]
        public void Deserialize_Success()
        {
            var orders =  new[]
            {
                new Order()
                {
                    OrderId = 1,
                    PaidTime = new DateTime(2018,1,1),
                    CashierInfo = new СashierInfo()
                    {
                        EmployeeId = 1,
                        FullName = "Sasha Pupkin",
                        ShiftId = 1
                    },
                    Items = new  
                        List<OrderItem>()
                        {
                            new OrderItem()
                            {
                                GoodId = 1,
                                Commission = 0.5,
                                OrderItemId = 1,
                                Price = 11.5,
                                Quantity = 2
                            }
                        }
                }
            };
            var json = JsonConvert.SerializeObject(orders);
            var cashierInfo = PartialDeserializer.Deserialize<СashierInfo>(json).First();
            Assert.Equal(cashierInfo.EmployeeId, 1 );
            Assert.Equal(cashierInfo.FullName, "Sasha Pupkin" );
            Assert.Equal(cashierInfo.ShiftId, 1 );
        }

    }
}