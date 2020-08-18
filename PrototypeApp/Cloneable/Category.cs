using System;

namespace PrototypeApp.Cloneable
{
    public class Category : ICloneable
    {
        public string Name { get; set; }
        public Category(string categoryName)
        {
            Name = categoryName;
        }

        public object Clone()
        {
            return new Category(Name);
        }
    }
}
