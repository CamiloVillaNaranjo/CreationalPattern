using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodApp.PizzaRecipes.FL
{
    public class FLDoubleCheesePizza : DoubleCheesePizza
    {
        public FLDoubleCheesePizza(PizzaDoughType doughType, SizePizza sizePizza) :base(doughType, sizePizza)
        {
            Name = "Double Cheese Pizza";
            DoughType = doughType;
            Size = sizePizza;
            Toppings.Add("Tomatoe sauce");
            Toppings.Add("mozzarella (2)");
            Toppings.Add("cheddar");
        }
    }
}
