using FactoryMethodApp.PizzaRecipes;

namespace FactoryMethodApp.PizzaStores
{
    public abstract class PizzaStore
    {
        public abstract Pizza CreatePizza(TypeOfRecipe recipeType, PizzaDoughType doughType, SizePizza size);

        public Pizza OrderPizza(TypeOfRecipe recipeType, PizzaDoughType doughType, SizePizza size)
        {
            var pizza = CreatePizza(recipeType, doughType, size);

            pizza.Prepare(size);

            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
