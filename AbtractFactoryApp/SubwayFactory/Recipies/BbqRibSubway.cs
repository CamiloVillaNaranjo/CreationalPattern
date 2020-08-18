using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryApp.SubwayFactory.Recipies
{
    public class BbqRibSubway : SubwaySandwich
    {
        private readonly ISubwayRecipeFactory subwayRecipe;

        public BbqRibSubway(ISubwayRecipeFactory subwayRecipe)
        {
            this.subwayRecipe = subwayRecipe;
        }
        public override void Prepare(TypeOfSubway subway, TypeOfBread bread, BreadSize size)
        {
            RecipeName = "BBQ Rib";
            Bread = bread;
            Size = size;
            Proteins = subwayRecipe.ChooseProteins(subway);
            Cheeses = subwayRecipe.AddCheese(subway);
            Veggies = subwayRecipe.AddVeggies(subway);
            Sauces = subwayRecipe.AddSauces(subway);
        }
    }
}
