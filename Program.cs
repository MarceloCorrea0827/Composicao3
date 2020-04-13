using ExercComposição3.Entities;
using ExercComposição3.Entities.Enum;
using System;
using System.Globalization;

namespace ExercComposição3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dados do Cliente
            //Instanciando Client
            Client client = new Client();

            Console.WriteLine("Enter Client Data: ");
            Console.Write("Name: ");
            client.Name = Console.ReadLine();
            Console.Write("E-mail: ");
            client.Email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            client.BirthDate = DateTime.Parse(Console.ReadLine());

            // Criação da Ordem
            Console.WriteLine("Enter Order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            // Instanciando Order e associando o Client
            Order order = new Order() { Moment = DateTime.Now, Status = status };
            order.AddCliente(client);

            // Criação e Entrada dos ítens da Ordem
            Console.Write("How many items to this order?");
            int qtdItemsOrder = int.Parse(Console.ReadLine());

            for (int i=1; i <= qtdItemsOrder; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product Name: ");
                string name = Console.ReadLine();
                Console.Write("Product Price:");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                // Instanciando Product
                Product produto = new Product() { Name = name, Price = price};

                // Instanciando OrderItem
                OrderItem orderItem = new OrderItem() { Quantity = quantity, Price = price };
                orderItem.AddProduct(produto); // Associando Product à OrdemItem

                // Adicionando a OrdemItem à Order
                order.AddItem(orderItem);
            }

            // Mostrando os resultados na Tela
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine("Order Moment: " + order.Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            Console.WriteLine("Order Status: " + order.Status);
            Console.WriteLine("Client: " + order.Cli.Name + " (" + order.Cli.BirthDate.ToString("dd/MM/yyyy") + ")" + " - " + order.Cli.Email);
            Console.WriteLine(order);
        }
    }
}
