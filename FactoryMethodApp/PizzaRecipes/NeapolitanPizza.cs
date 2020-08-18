using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodApp.PizzaRecipes
{
    public class NeapolitanPizza : Pizza
    {
        public NeapolitanPizza(PizzaDoughType doughType, SizePizza sizePizza)
        {
            DoughType = doughType;
            Size = sizePizza;
        }
    }
}
