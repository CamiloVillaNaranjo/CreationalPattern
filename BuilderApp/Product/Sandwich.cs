using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderApp.Product
{
    public class Sandwich
    {
        public string RecipeName { get; set; }
        public BreadType Bread { get; set; }
        public CheeseType Cheese { get; set; }
        public string Protein { get; set; }
        public string Vegetables { get; set; }
        public string Sauces { get; set; }
    }
}
