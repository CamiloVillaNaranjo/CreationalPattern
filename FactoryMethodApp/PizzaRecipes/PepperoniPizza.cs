using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodApp.PizzaRecipes
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza(PizzaDoughType doughType, SizePizza sizePizza)
        {
            DoughType = doughType;
            Size = sizePizza;
        }
    }
}
