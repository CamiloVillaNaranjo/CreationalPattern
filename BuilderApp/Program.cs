using BuilderApp.ConcreteBuilder;
using BuilderApp.Director;
using System;

namespace BuilderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var recipe = new SubwaySandwich(new ChickenBaconRanchMeltRecipe());

            recipe.PrepareRecipe(BreadType.ItalianBread, CheeseType.Provolone);

            var subway = recipe.GetSandwich();

            Console.WriteLine($"You pick: {subway.RecipeName}");
            Console.WriteLine("With the following details:");
            Console.WriteLine($" - Bread: {subway.Bread}");
            Console.WriteLine($" - Protein: {subway.Protein}");
            Console.WriteLine($" - Cheese: {subway.Cheese}");
            Console.WriteLine($" - Veggies: {subway.Vegetables}");
            Console.WriteLine($" - Sauces: {subway.Sauces}");

            Console.ReadKey();
        }
    }
}
