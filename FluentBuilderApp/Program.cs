using FluentBuilderApp.Builder;
using System;

namespace FluentBuilderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var subway = SandwichRecipeBuilder.CreateNew("BBQ Rib")
                .InBread(BreadType.HoneyOat)
                .WithProtein("Rib")
                .WithOnions()
                .WithLetuce()
                .Build();

            Console.WriteLine(subway);

            Console.ReadKey();
        }
    }
}
