using BuilderApp.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderApp.ConcreteBuilder
{
    public class ChickenBaconRanchMeltRecipe : SandwichRecipeBuilder
    {
        public ChickenBaconRanchMeltRecipe()
        {
            _sandwichRecipe = new Product.Sandwich
            {
                RecipeName = "Subway Chicken & Bacon Ranch Melt"
            };
        }
        public override void ChooseBread(BreadType breadType)
        {
            _sandwichRecipe.Bread = breadType;
        }

        public override void AddCheese(CheeseType cheeseType)
        {
            _sandwichRecipe.Cheese = cheeseType;
        }

        public override void AddProtein()
        {
            _sandwichRecipe.Protein = "Tender all-white meat chicken with seasoning and marinade, savory bacon";
        }

        public override void AddSauces()
        {
            _sandwichRecipe.Sauces = "Chipotle Southwest, Regular Mayonnaise, Ranch";
        }

        public override void AddVegetables()
        {
            _sandwichRecipe.Vegetables = "Lettuce, Tomatoes, Onion";
        }
    }
}
