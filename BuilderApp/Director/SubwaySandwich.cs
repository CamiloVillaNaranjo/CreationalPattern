using BuilderApp.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderApp.Director
{
    public class SubwaySandwich
    {
        private SandwichRecipeBuilder _sandwichRecipe;
        public SubwaySandwich(SandwichRecipeBuilder sandwichRecipe)
        {
            this._sandwichRecipe = sandwichRecipe;
        }

        public void PrepareRecipe(BreadType breadType, CheeseType cheeseType)
        {
            _sandwichRecipe.ChooseBread(breadType);            
            _sandwichRecipe.AddProtein();
            _sandwichRecipe.AddCheese(cheeseType);
            _sandwichRecipe.AddVegetables();
            _sandwichRecipe.AddSauces();
        }

        public Product.Sandwich GetSandwich() { 
            return _sandwichRecipe.Sandwich; 
        }
    }
}
