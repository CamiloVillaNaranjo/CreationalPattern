using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodApp.PizzaRecipes.FL
{
    public class FLNeapolitanPizza : NeapolitanPizza
    {
        public FLNeapolitanPizza(PizzaDoughType doughType, SizePizza sizePizza) : base(doughType, sizePizza)
        {
            Name = "Neapolitan Pizza";
            DoughType = doughType;
            Size = sizePizza;
            Toppings.Add("Tomato sauce");
            Toppings.Add("mozzarella");
            Toppings.Add("fresh sliced ​​tomatoes");
            Toppings.Add("fresh sliced ​​basil");
            Toppings.Add("olive oil");
        }
    }
}
