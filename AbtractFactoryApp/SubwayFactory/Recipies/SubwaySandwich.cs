using AbstractFactoryApp.SubwayFactory.Proteins;
using AbstractFactoryApp.SubwayFactory.Sauces;
using AbstractFactoryApp.SubwayFactory.Veggies;
using System;
using System.Collections.Generic;

namespace AbstractFactoryApp.SubwayFactory.Recipies
{
    public abstract class SubwaySandwich
    {
        public string RecipeName { get; set; }
        public TypeOfBread Bread { get; set; }
        public BreadSize Size { get; set; }
        public List<CheeseType> Cheeses { get; set; } = new List<CheeseType>();
        public List<IProtein> Proteins { get; set; } = new List<IProtein>();
        public List<IVeggie> Veggies { get; set; } = new List<IVeggie>();
        public List<ISauce> Sauces { get; set; } = new List<ISauce>();
        public abstract void Prepare(TypeOfSubway subway, TypeOfBread bread , BreadSize size);

        public override string ToString()
        {
            var recipe = $"Subway choosen: {RecipeName}";
            recipe += $"{Environment.NewLine}To be prepared in Bread: {Bread}";
            recipe += $"{Environment.NewLine}Size: {Size}";
            recipe += $"{Environment.NewLine}- Cheese :";
            foreach (var cheese in Cheeses)
            {
                recipe += $"{Environment.NewLine}  * {cheese}";
            }

            recipe += $"{Environment.NewLine}- Proteins :";
            foreach (var protein in Proteins)
            {
                recipe += $"{Environment.NewLine}  * {protein.Description}";
            }

            recipe += $"{Environment.NewLine}- With Veggies :";
            foreach (var veggie in Veggies)
            {
                recipe += $"{Environment.NewLine}  * {veggie.Description}";
            }

            recipe += $"{Environment.NewLine}And Sauces :";
            foreach (var sauce in Sauces)
            {
                recipe += $"{Environment.NewLine}  * {sauce.Description}";
            }

            return recipe;
        }
    }
}
