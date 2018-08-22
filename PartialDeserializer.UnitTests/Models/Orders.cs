using System;
using System.Collections.Generic;

namespace PartialDeserializer.UnitTests.Models
{
    public enum PayType
    {
        Cash,
        Card
    }

    public class Order
    {
        public ICollection<OrderItem> Items { get; set; }

        public int OrderId { get; set; }
            
        public DateTime PaidTime { get; set; }

        public СashierInfo CashierInfo { get; set; }
            
        public PayType PayType { get; set; }
    }

    public class СashierInfo
    {
        public string FullName { get; set; }
            
        public int EmployeeId { get; set; }
            
        public int ShiftId { get; set; }
    }
        
    public class OrderItem
    {
        public int OrderItemId { get; set; }
            
        public int GoodId { get; set; }
            
        public int Quantity { get; set; }
            
        public double Commission { get; set; }
            
        public double Price { get; set; }
    }

}