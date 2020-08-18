using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodApp.PizzaRecipes.NY
{
    public class NYHawaiianPizza : HawaiianPizza
    {
        public NYHawaiianPizza(SizePizza sizePizza) : base(PizzaDoughType.ThinCrust, sizePizza)
        {
            Name = "Hawaiian Pizza";
            DoughType = PizzaDoughType.ThinCrust;
            Size = sizePizza;
            Toppings.Add("Tomato sauce");
            Toppings.Add("mozzarella");
            Toppings.Add("pineapple chunks");
            Toppings.Add("pieces of ham");
            Toppings.Add("pieces of bacon");
        }
    }
}
