using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryApp.SubwayFactory.Recipies
{
    public class ClassicTunaSandwich : SubwaySandwich
    {
        private readonly ISubwayRecipeFactory subwayRecipe;
        public ClassicTunaSandwich(ISubwayRecipeFactory subwayRecipe)
        {
            this.subwayRecipe = subwayRecipe;
        }
        public override void Prepare(TypeOfSubway subway, TypeOfBread bread, BreadSize size)
        {
            RecipeName = "Classic Tuna";
            Bread = bread;
            Size = size;
            Proteins = subwayRecipe.ChooseProteins(subway);
            Cheeses = subwayRecipe.AddCheese(subway);
            Veggies = subwayRecipe.AddVeggies(subway);
            Sauces = subwayRecipe.AddSauces(subway);
        }
    }
}
