using AbstractFactoryApp.SubwayShop;
using AbstractFactoryApp.SubwayFactory;
using System;

namespace AbstractFactoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var colombianStore = new ColombianSubwayStore();
            var sandwich = colombianStore.OrderSandwich(TypeOfSubway.ChickenBaconRanchMelt, 
                                                        TypeOfBread.ItalianHerbsAndCheese, 
                                                        BreadSize.Footlong);
            Console.WriteLine(sandwich);
            Console.ReadLine();
        }
    }
}
