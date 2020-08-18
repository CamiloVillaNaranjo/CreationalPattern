using AbstractFactoryApp.SubwayFactory.Proteins;
using AbstractFactoryApp.SubwayFactory.Sauces;
using AbstractFactoryApp.SubwayFactory.Veggies;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryApp.SubwayFactory.Recipies
{
    public class BlackForestHamSubway : SubwaySandwich
    {
        private readonly ISubwayRecipeFactory subwayRecipe;
        public BlackForestHamSubway(ISubwayRecipeFactory subwayRecipe)
        {
            this.subwayRecipe = subwayRecipe;
        }

        public override void Prepare(TypeOfSubway subway, TypeOfBread bread, BreadSize size)
        {
            RecipeName = "Black Forest Ham";
            Bread = bread;
            Size = size;
            Proteins = subwayRecipe.ChooseProteins(subway);
            Cheeses = subwayRecipe.AddCheese(subway);
            Veggies = subwayRecipe.AddVeggies(subway);
            Sauces = subwayRecipe.AddSauces(subway);
        }
    }
}
