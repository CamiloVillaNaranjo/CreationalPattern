using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodApp.PizzaRecipes.NY
{
    public class NYPepperoniPizza : PepperoniPizza
    {
        public NYPepperoniPizza(SizePizza sizePizza) : base(PizzaDoughType.ThinCrust, sizePizza)
        {
            Name = "Pepperoni Pizza";
            DoughType = PizzaDoughType.ThinCrust;
            Size = sizePizza;
            Toppings.Add("Tomato sauce");
            Toppings.Add("mozzarella");
            Toppings.Add("pepperoni");
        }
    }
}
