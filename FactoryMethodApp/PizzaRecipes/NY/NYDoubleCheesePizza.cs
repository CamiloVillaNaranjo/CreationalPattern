using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodApp.PizzaRecipes.NY
{
    public class NYDoubleCheesePizza : DoubleCheesePizza
    {
        public NYDoubleCheesePizza(SizePizza sizePizza) : base(PizzaDoughType.ThinCrust, sizePizza)
        {
            Name = "Double Cheese Pizza";
            DoughType = PizzaDoughType.ThinCrust;
            Size = sizePizza;
            Toppings.Add("Tomatoe sauce");
            Toppings.Add("mozzarella (2)");
            Toppings.Add("cheddar");
        }
    }
}
