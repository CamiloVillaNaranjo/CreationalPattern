using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodApp
{
    public enum PizzaDoughType
    {
        Traditional,
        ThinCrust,
        DeepDish
    }

    public enum TypeOfRecipe
    {
        Pepperoni,
        American,
        Neapolitan,
        Hawaiian,
        DoubleCheese
    }

    public enum SizePizza
    {
        Personal = 2,
        Small=4,
        Medium = 6,
        Big = 8,
        X_Big = 12
    } 
}
