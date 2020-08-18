using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodApp.PizzaRecipes.FL
{
    public class FLPepperoniPizza : PepperoniPizza
    {
        public FLPepperoniPizza(PizzaDoughType doughType, SizePizza sizePizza) : base(doughType, sizePizza)
        {
            Name = "Pepperoni Pizza";
            DoughType = doughType;
            Size = sizePizza;
            Toppings.Add("Tomato sauce");
            Toppings.Add("mozzarella");
            Toppings.Add("pepperoni");
        }
    }
}
