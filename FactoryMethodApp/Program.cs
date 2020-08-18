using FactoryMethodApp.PizzaStores;
using System;

namespace FactoryMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var flStore = new FLPizzaStore();
            var pizza = flStore.OrderPizza(TypeOfRecipe.American, PizzaDoughType.Traditional, SizePizza.Big);

            Console.WriteLine($"Your {pizza.Name}, is ready to go!");
            Console.ReadLine();
        }
    }
}
