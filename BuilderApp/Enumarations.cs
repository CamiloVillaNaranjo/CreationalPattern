using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BuilderApp
{
    public enum BreadType
    {
        [Description("Honey Oat")]
        HoneyOat,
        [Description("Italian Bread")]
        ItalianBread,
        [Description("9-Grain Wheat")]
        GrainWheat,
        [Description("Italian Herbs and Cheese")]
        ItalianHerbsAndCheese
    }

    public enum CheeseType
    {
        Cheddar,
        Mozzarella,
        Provolone,
        Swiss
    }
}
