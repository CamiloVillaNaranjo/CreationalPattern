using FactoryMethodApp.PizzaRecipes;
using FactoryMethodApp.PizzaRecipes.FL;
using System;

namespace FactoryMethodApp.PizzaStores
{
    public class FLPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(TypeOfRecipe recipeType, PizzaDoughType doughType, SizePizza size)
        {
            var typeName = $"FactoryMethodApp.PizzaRecipes.FL.FL{Enum.GetName(typeof(TypeOfRecipe), recipeType)}Pizza";
            return (Pizza)Activator.CreateInstance(Type.GetType(typeName), doughType, size);
        }
    }
}
