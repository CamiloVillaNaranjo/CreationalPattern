using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodApp.PizzaRecipes
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        protected PizzaDoughType DoughType;
        protected SizePizza Size;
        protected List<string> Toppings = new List<string>();

        public void Prepare(SizePizza size)
        {
            Size = size;

            Console.WriteLine($"Preparing Recipe: {Name}");
            Console.WriteLine($"Dough selected: {DoughType}");
        }

        public void Bake() => Console.WriteLine("Cook for 20 min.");
        public void Cut() => Console.WriteLine($"Pizza cut into {(int)Size} equal slides.");
        public void Box() => Console.WriteLine($"Pizza packed in {Enum.GetName(typeof(SizePizza), Size)} box.");
    }
}
