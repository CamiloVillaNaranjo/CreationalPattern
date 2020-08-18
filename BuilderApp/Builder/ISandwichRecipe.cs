using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderApp.Builder
{
    public interface ISandwichRecipe
    {
        void ChooseBread(BreadType breadType);
        void AddCheese(CheeseType cheeseType);
        void AddProtein();
        void AddVegetables();
        void AddSauces();
    }
}
