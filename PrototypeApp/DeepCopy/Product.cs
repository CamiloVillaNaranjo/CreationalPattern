namespace PrototypeApp.DeepCopy
{
    public class Product : IPrototype<Product>
    {
        public string Name { get; set; }
        public Category Category { get; set; }

        public Product(string productName, Category category)
        {
            Name = productName;
            Category = category;
        }

        public override string ToString()
        {
            return $"Product: {Name}, Category: {Category.Name}";
        }

        public Product DeepCopy()
        {
            return new Product(Name, Category.DeepCopy());
        }
    }
}
