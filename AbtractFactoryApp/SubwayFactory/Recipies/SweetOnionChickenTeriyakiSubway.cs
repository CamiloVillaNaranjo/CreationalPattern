using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryApp.SubwayFactory.Recipies
{
    public class SweetOnionChickenTeriyakiSubway : SubwaySandwich
    {
        private readonly ISubwayRecipeFactory subwayRecipe;
        public SweetOnionChickenTeriyakiSubway(ISubwayRecipeFactory subwayRecipe)
        {
            this.subwayRecipe = subwayRecipe;
        }
        public override void Prepare(TypeOfSubway subway, TypeOfBread bread, BreadSize size)
        {
            RecipeName = "Sweet Onion Chicken Teriyaki";
            Bread = bread;
            Size = size;
            Proteins = subwayRecipe.ChooseProteins(subway);
            Cheeses = subwayRecipe.AddCheese(subway);
            Veggies = subwayRecipe.AddVeggies(subway);
            Sauces = subwayRecipe.AddSauces(subway);
        }
    }
}
