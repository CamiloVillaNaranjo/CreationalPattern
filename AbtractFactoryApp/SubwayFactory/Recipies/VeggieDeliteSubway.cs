
namespace AbstractFactoryApp.SubwayFactory.Recipies
{
    public class VeggieDeliteSubway : SubwaySandwich
    {
        private readonly ISubwayRecipeFactory subwayRecipe;
        public VeggieDeliteSubway(ISubwayRecipeFactory subwayRecipe)
        {
            this.subwayRecipe = subwayRecipe;
        }

        public override void Prepare(TypeOfSubway subway, TypeOfBread bread, BreadSize size)
        {
            RecipeName = "Veggie Delite";
            Bread = bread;
            Size = size;
            Proteins = subwayRecipe.ChooseProteins(subway);
            Cheeses = subwayRecipe.AddCheese(subway);
            Veggies = subwayRecipe.AddVeggies(subway);
            Sauces = subwayRecipe.AddSauces(subway);
        }
    }
}
