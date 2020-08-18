using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodApp.PizzaRecipes.NY
{
    public class NYNeapolitanPizza : NeapolitanPizza
    {
        public NYNeapolitanPizza(SizePizza sizePizza) : base(PizzaDoughType.ThinCrust, sizePizza)
        {
            Name = "Neapolitan Pizza";
            DoughType = PizzaDoughType.ThinCrust;
            Size = sizePizza;
            Toppings.Add("Tomato sauce");
            Toppings.Add("mozzarella");
            Toppings.Add("fresh sliced ​​tomatoes");
            Toppings.Add("fresh sliced ​​basil");
        }
    }
}
