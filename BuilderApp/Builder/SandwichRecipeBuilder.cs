using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderApp.Builder
{
    public abstract class SandwichRecipeBuilder : ISandwichRecipe
    {
        protected Product.Sandwich _sandwichRecipe;
        public Product.Sandwich Sandwich => _sandwichRecipe;
        public abstract void ChooseBread(BreadType breadType);
        public abstract void AddCheese(CheeseType cheeseType);
        public abstract void AddProtein();
        public abstract void AddSauces();
        public abstract void AddVegetables();
    }
}
