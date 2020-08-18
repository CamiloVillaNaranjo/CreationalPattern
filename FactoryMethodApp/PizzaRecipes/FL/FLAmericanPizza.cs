using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodApp.PizzaRecipes.FL
{
    public class FLAmericanPizza : AmericanPizza
    {
        public FLAmericanPizza(PizzaDoughType doughType, SizePizza sizePizza):base(doughType,sizePizza)
        {
            Name = "American Pizza";
            DoughType = doughType;
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
