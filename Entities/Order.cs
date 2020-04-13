using ExercComposição3.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercComposição3.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Cli { get; set; }

        public Order() { }

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public void AddCliente(Client client)
        {
            Cli = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach(OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Items:");
            foreach(OrderItem orderItem in Items)
            {
                sb.AppendLine(orderItem.Prod.Name + ", " + 
                          "$" + orderItem.Prod.Price.ToString("F2", CultureInfo.InvariantCulture) + ", " + 
                          "Quantity: " +  orderItem.Quantity + ", " + 
                          "Subtotal: $" + orderItem.SubTotal().ToString("F2", CultureInfo.InvariantCulture)
                );
            }
            sb.AppendLine("Total Price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
