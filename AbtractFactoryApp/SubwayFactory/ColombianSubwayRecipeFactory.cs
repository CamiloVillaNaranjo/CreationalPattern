using AbstractFactoryApp.SubwayFactory.Proteins;
using AbstractFactoryApp.SubwayFactory.Sauces;
using AbstractFactoryApp.SubwayFactory.Veggies;
using System.Collections.Generic;

namespace AbstractFactoryApp.SubwayFactory
{
    public class ColombianSubwayRecipeFactory : ISubwayRecipeFactory
    {
        public List<CheeseType> AddCheese(TypeOfSubway subway)
        {
            var lstChees = new List<CheeseType>();
            switch (subway)
            {
                case TypeOfSubway.BbqRib:
                case TypeOfSubway.ColdCutCombo:
                    lstChees.Add(CheeseType.Provolone);
                    break;
                case TypeOfSubway.ChickenBaconRanchMelt:
                case TypeOfSubway.SpicyItalian:
                case TypeOfSubway.TurkeyBreast:
                    lstChees.Add(CheeseType.Cheddar);
                    break;
                case TypeOfSubway.ClassicTuna:
                case TypeOfSubway.SweetOnionChickenTeriyaki:
                    lstChees.Add(CheeseType.Parmesan);
                    break;
                case TypeOfSubway.ItalianBMT:
                case TypeOfSubway.MeatballMarinara:
                    lstChees.Add(CheeseType.Swiss);
                    break;
                case TypeOfSubway.OvenRoastedChicken:
                case TypeOfSubway.SteakCheese:
                case TypeOfSubway.VeggieDelite:
                case TypeOfSubway.BlackForestHam:
                    lstChees.Add(CheeseType.Mozzarella);
                    break;
                
                
            }
            return lstChees;
        }

        public List<ISauce> AddSauces(TypeOfSubway subway)
        {
            var lstSauces = new List<ISauce>();
            switch (subway)
            {
                case TypeOfSubway.BbqRib:
                    lstSauces.Add(new Barbecue());
                    lstSauces.Add(new TangyPickles());
                    lstSauces.Add(new Chippotle());
                    break;
                case TypeOfSubway.BlackForestHam:
                    lstSauces.Add(new TangyPickles());
                    lstSauces.Add(new SweetOnion());
                    break;
                case TypeOfSubway.ChickenBaconRanchMelt:
                    lstSauces.Add(new Ranch());
                    lstSauces.Add(new SweetOnion());
                    break;
                case TypeOfSubway.ClassicTuna:
                    lstSauces.Add(new Mayonnaise());
                    break;
                case TypeOfSubway.ColdCutCombo:
                case TypeOfSubway.ItalianBMT:
                    lstSauces.Add(new SweetOnion());
                    lstSauces.Add(new Chippotle());
                    break;
                case TypeOfSubway.MeatballMarinara:
                    lstSauces.Add(new Tomato());
                    lstSauces.Add(new Chippotle());
                    break;
                case TypeOfSubway.OvenRoastedChicken:
                    lstSauces.Add(new SweetOnion());
                    lstSauces.Add(new Barbecue());
                    lstSauces.Add(new Chippotle());
                    break;
                case TypeOfSubway.SpicyItalian:
                    lstSauces.Add(new Ranch());
                    lstSauces.Add(new Chippotle());
                    break;
                case TypeOfSubway.SteakCheese:
                    lstSauces.Add(new Mayonnaise());
                    lstSauces.Add(new Chippotle());
                    break;
                case TypeOfSubway.SweetOnionChickenTeriyaki:
                    lstSauces.Add(new SweetOnion());
                    lstSauces.Add(new Marinara());
                    break;
                case TypeOfSubway.TurkeyBreast:
                case TypeOfSubway.VeggieDelite:
                    lstSauces.Add(new SweetOnion());
                    lstSauces.Add(new Chippotle());
                    break;
            }
            return lstSauces;
        }

        public List<IVeggie> AddVeggies(TypeOfSubway subway)
        {
            var lstVeggies = new List<IVeggie>();

            switch (subway)
            {
                case TypeOfSubway.BbqRib:
                case TypeOfSubway.BlackForestHam:
                    lstVeggies.Add(new CrispLettuce());
                    lstVeggies.Add(new Tomatoes());
                    lstVeggies.Add(new Cucumbers());
                    break;
                case TypeOfSubway.ChickenBaconRanchMelt:
                case TypeOfSubway.ColdCutCombo:
                case TypeOfSubway.ItalianBMT:
                    lstVeggies.Add(item: new Lettuce());
                    lstVeggies.Add(new Tomatoes());
                    lstVeggies.Add(new Onions());
                    break;
                case TypeOfSubway.ClassicTuna:
                    lstVeggies.Add(new Lettuce());                    
                    lstVeggies.Add(new Cucumbers());
                    lstVeggies.Add(new Tomatoes());
                    lstVeggies.Add(new Onions());
                    break;
                case TypeOfSubway.MeatballMarinara:
                    lstVeggies.Add(new Tomatoes());
                    break;
                case TypeOfSubway.OvenRoastedChicken:
                    lstVeggies.Add(item: new Lettuce());
                    lstVeggies.Add(new Tomatoes());
                    lstVeggies.Add(new Onions());
                    lstVeggies.Add(new Cucumbers());
                    break;
                case TypeOfSubway.SpicyItalian:
                    lstVeggies.Add(item: new Lettuce());
                    lstVeggies.Add(new Tomatoes());
                    lstVeggies.Add(new Onions());
                    lstVeggies.Add(new GreenPeppers());
                    break;
                case TypeOfSubway.SteakCheese:
                    lstVeggies.Add(new GreenPeppers());
                    lstVeggies.Add(new Onions());
                    break;
                case TypeOfSubway.SweetOnionChickenTeriyaki:
                case TypeOfSubway.TurkeyBreast:
                case TypeOfSubway.VeggieDelite:
                    lstVeggies.Add(new Lettuce());
                    lstVeggies.Add(new Tomatoes());
                    lstVeggies.Add(new GreenPeppers());
                    lstVeggies.Add(new Spinach());
                    lstVeggies.Add(new Onions());
                    lstVeggies.Add(new Cucumbers());
                    break;
            }

            return lstVeggies;
        }

        public List<IProtein> ChooseProteins(TypeOfSubway subway)
        {
            var lstProteins = new List<IProtein>();

            switch (subway)
            {
                case TypeOfSubway.BbqRib:
                    lstProteins.Add(new Rib());
                    break;
                case TypeOfSubway.BlackForestHam:
                    lstProteins.Add(new BlackForestHam());
                    lstProteins.Add(new Ham());
                    break;
                case TypeOfSubway.ChickenBaconRanchMelt:
                    lstProteins.Add(new ChickenStrips());
                    lstProteins.Add(new Bacons());
                    break;
                case TypeOfSubway.ClassicTuna:
                    lstProteins.Add(new Tuna());
                    break;
                case TypeOfSubway.ColdCutCombo:
                    lstProteins.Add(new TurkeyHam());
                    lstProteins.Add(new Bologna());
                    lstProteins.Add(new TurkeySalami());
                    break;
                case TypeOfSubway.ItalianBMT:
                    lstProteins.Add(new Salami());
                    lstProteins.Add(new SpicyPepperoni());
                    lstProteins.Add(new BlackForestHam());
                    break;
                case TypeOfSubway.MeatballMarinara:
                    lstProteins.Add(new Meatball());
                    break;
                case TypeOfSubway.OvenRoastedChicken:
                    lstProteins.Add(new SavoryChickenBreast());
                    break;
                case TypeOfSubway.SpicyItalian:
                    lstProteins.Add(new SpicyPepperoni());
                    lstProteins.Add(new Salami());
                    break;
                case TypeOfSubway.SteakCheese:
                    lstProteins.Add(new Steak());
                    break;
                case TypeOfSubway.SweetOnionChickenTeriyaki:
                    lstProteins.Add(new ChickenStrips());
                    break;
                case TypeOfSubway.TurkeyBreast:
                    lstProteins.Add(new TurkeyHam());                    
                    break;
                case TypeOfSubway.VeggieDelite:
                    lstProteins.Add(new NoProtein());
                    break;
            }

            return lstProteins;
        }
    }
}
