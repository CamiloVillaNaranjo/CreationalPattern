using AbstractFactoryApp.SubwayFactory.Proteins;
using AbstractFactoryApp.SubwayFactory.Sauces;
using AbstractFactoryApp.SubwayFactory.Veggies;
using System.Collections.Generic;

namespace AbstractFactoryApp.SubwayFactory
{
    public interface ISubwayRecipeFactory
    {
        List<IProtein> ChooseProteins(TypeOfSubway subway);
        List<CheeseType> AddCheese(TypeOfSubway subway);
        List<IVeggie> AddVeggies(TypeOfSubway subway);
        List<ISauce> AddSauces(TypeOfSubway subway);
    }
}
