using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeApp.Serializing
{
    [Serializable]
    public class Category
    {
        public string Name { get; set; }
        public Category(string categoryName)
        {
            Name = categoryName;
        }

    }
}
