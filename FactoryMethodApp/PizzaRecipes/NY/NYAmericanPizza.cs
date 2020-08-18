using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodApp.PizzaRecipes.NY
{
    public class NYAmericanPizza : AmericanPizza
    {
        public NYAmericanPizza(SizePizza sizePizza) : base(PizzaDoughType.ThinCrust, sizePizza)
        {
            Name = "American Pizza";
            DoughType = PizzaDoughType.ThinCrust;
            Size = sizePizza;
            Toppings.Add("Tomato sauce");
            Toppings.Add("mozzarella");
            Toppings.Add("frankfurter");
            Toppings.Add("peppers diced");
            Toppings.Add("crumbled sausage");
            Toppings.Add("fresh sliced ​​tomatoes");
            Toppings.Add("sliced onion");
            Toppings.Add("mushrooms");
        }
    }
}
