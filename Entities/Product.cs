namespace ExercComposição3.Entities
{
    class Product
    {
        public string Nome { get; set; }
        public double Price { get; set; }

        public Product() { }

        public Product(string nome, double price)
        {
            Nome = nome;
            Price = price;
        }
    }
}
