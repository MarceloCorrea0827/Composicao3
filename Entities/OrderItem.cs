namespace ExercComposição3.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Prod { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public void AddProduct(Product prod)
        {
            Prod = prod;
        }

        public double SubTotal()
        {
            return (Quantity * Price);
        }
    }
}
