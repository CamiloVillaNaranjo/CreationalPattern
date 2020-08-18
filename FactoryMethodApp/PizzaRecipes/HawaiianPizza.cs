using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodApp.PizzaRecipes
{
    public class HawaiianPizza : Pizza
    {
        public HawaiianPizza(PizzaDoughType doughType, SizePizza sizePizza)
        {
            DoughType = doughType;
            Size = sizePizza;
        }
    }
}
