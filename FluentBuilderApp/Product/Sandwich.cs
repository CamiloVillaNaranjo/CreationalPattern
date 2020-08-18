using System;
using System.Collections.Generic;
using System.Text;

namespace FluentBuilderApp.Product
{
    public sealed class Sandwich
    {
        public string RecipeName;
        public BreadType Bread;
        public string Protein;
        public CheeseType Cheese;
        public string Vegetables;
        public string Sauces;

        public override string ToString()
        {
            return $"Your subway is: {RecipeName},{Environment.NewLine}Preapred in Bread: {Bread},{Environment.NewLine}protein: {Protein},{Environment.NewLine}Plus: {Cheese},{Environment.NewLine}{Vegetables} and {Sauces}";
        }
    }
}
