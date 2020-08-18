using System;

namespace PrototypeApp.MemberwiseClone
{
    public class Product
    {
        public string Name { get; set; }
        public Category Category { get; set; }

        public Product(string nameProduct, Category category)
        {
            Name = nameProduct;
            Category = category;
        }

        public Product ShallowCopy()
        {
            return (Product)this.MemberwiseClone();
        }

        public Product DeepCopy()
        {
            var clone = (Product)this.MemberwiseClone();

            clone.Category = new Category(Category.Name);
            clone.Name = String.Concat(Name);

            return clone;
        }

        public override string ToString()
        {
            return $"Product: {Name}, Category: {Category.Name}";
        }
    }
}