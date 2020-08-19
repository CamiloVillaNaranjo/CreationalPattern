using SingletonApp.SingletonCode;
using System;

namespace SingletonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var capitals = DataItemContainer.GetInstance();
            var capitalName = "London";
            Console.WriteLine($"The population for capital: {capitalName} - is: {capitals.GetPopulationByCapitalName(capitalName)}");

            var worldCapitals = DataItemContainer.GetInstance();
            capitalName = "Beijing";
            Console.WriteLine($"The population for capital: {capitalName} - is: {worldCapitals.GetPopulationByCapitalName(capitalName)}");
            Console.ReadLine();
        }
    }
}
