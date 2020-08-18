using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeApp.Cloneable
{
    public class Product : ICloneable
    {
        public string Name { get; set; }
        public Category Category { get; set; }

        public Product(string productName, Category categoryName)
        {
            Name = productName;
            Category = categoryName;
        }

        public override string ToString()
        {
            return $"Product: {Name}, Category: {Category.Name}";
        }

        public object Clone()
        {
            return new Product(Name, (Category)Category.Clone());
        }
    }
}
