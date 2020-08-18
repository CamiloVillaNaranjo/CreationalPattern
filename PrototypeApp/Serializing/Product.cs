using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeApp.Serializing
{
    [Serializable]
    public class Product
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
    }
}
