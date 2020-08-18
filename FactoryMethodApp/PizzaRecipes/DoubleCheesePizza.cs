using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodApp.PizzaRecipes
{
    public class DoubleCheesePizza : Pizza
    {
        public DoubleCheesePizza(PizzaDoughType doughType, SizePizza sizePizza)
        {
            DoughType = doughType;
            Size = sizePizza;
        }
    }
}
