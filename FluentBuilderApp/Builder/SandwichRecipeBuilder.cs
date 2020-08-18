using FluentBuilderApp.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluentBuilderApp.Builder
{
    public class SandwichRecipeBuilder
    {
        private readonly Sandwich _sandwich;
        public SandwichRecipeBuilder(string recipeName)
        {
            _sandwich = new Sandwich { 
                RecipeName = recipeName
            };
        }

        public static SandwichRecipeBuilder CreateNew(string recipeName)
        {
            return new SandwichRecipeBuilder(recipeName);
        }

        public SandwichRecipeBuilder InBread(BreadType breadType)
        {
            _sandwich.Bread = breadType;
            return this;
        }

        public SandwichRecipeBuilder WithProtein(string protein)
        {
            _sandwich.Protein = protein;
            return this;
        }

        public SandwichRecipeBuilder WithOnions()
        {
            _sandwich.Vegetables = string.IsNullOrEmpty(_sandwich.Vegetables) ? "Onions": _sandwich.Vegetables + ", Onions";
            return this;
        }

        public SandwichRecipeBuilder WithLetuce()
        {
            _sandwich.Vegetables = string.IsNullOrEmpty(_sandwich.Vegetables) ? "Letuce" : _sandwich.Vegetables + ", Letuce";
            return this;
        }

        public Sandwich Build()
        {
            return _sandwich;
        }
    }
}
