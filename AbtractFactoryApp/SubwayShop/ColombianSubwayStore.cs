using AbstractFactoryApp.SubwayFactory;
using AbstractFactoryApp.SubwayFactory.Recipies;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryApp.SubwayShop
{
    public class ColombianSubwayStore : SubwayStore
    {
        public override SubwaySandwich CreateSandwich(TypeOfSubway subway)
        {
            ISubwayRecipeFactory recipeFactory = new ColombianSubwayRecipeFactory();
            var typeObject = Type.GetType($"AbstractFactoryApp.SubwayFactory.Recipies.{Enum.GetName(typeof(TypeOfSubway), subway)}Subway");
            return (SubwaySandwich)Activator.CreateInstance(typeObject, recipeFactory);
        }
    }
}
