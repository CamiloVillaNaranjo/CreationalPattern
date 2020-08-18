using FactoryMethodApp.PizzaRecipes;
using FactoryMethodApp.PizzaRecipes.NY;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodApp.PizzaStores
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(TypeOfRecipe recipeType, PizzaDoughType doughType, SizePizza size)
        {
            var typeName = $"FactoryMethodApp.PizzaRecipes.NY.NY{Enum.GetName(typeof(TypeOfRecipe), recipeType)}Pizza";            
            return (Pizza)Activator.CreateInstance(Type.GetType(typeName), size);
        }
    }
}
