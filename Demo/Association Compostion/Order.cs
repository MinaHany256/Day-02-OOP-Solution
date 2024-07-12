using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Association_Compostion
{
    internal class Order
    {
        // 1.1 Association Composition Relatioship (Required) [Has a]
        // Between Order and Items [Order Has Items]

        public int Id { get; set; }
        public string BuyerEmail { get; set; }
        public decimal SubTotal { get; set; }
        public OrderItem[] Items { get; set; }
        public decimal ShippingPrice { get; set; }

        public Order(string userEmail, OrderItem[] items)
        {
            BuyerEmail = userEmail;
            Items = items;
        }
    }
}
