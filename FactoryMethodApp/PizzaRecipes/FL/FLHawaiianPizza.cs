using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FactoryMethodApp.PizzaRecipes.FL
{
    public class FLHawaiianPizza : HawaiianPizza
    {
        public FLHawaiianPizza(PizzaDoughType doughType, SizePizza sizePizza):base(doughType, sizePizza)
        {
            Name = "Hawaiian Pizza";
            DoughType = doughType;
            Size = sizePizza;
            Toppings.Add("Tomato sauce");
            Toppings.Add("mozzarella");
            Toppings.Add("pineapple chunks");
            Toppings.Add("pieces of ham");
            Toppings.Add("pieces of bacon");
        }
    }
}
