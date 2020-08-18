using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodApp.PizzaRecipes
{
    public class AmericanPizza : Pizza
    {
        public AmericanPizza(PizzaDoughType doughType, SizePizza sizePizza)
        {
            DoughType = doughType;
            Size = sizePizza;
        }
    }
}
