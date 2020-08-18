namespace AbstractFactoryApp.SubwayFactory.Recipies
{
    public class SteakCheeseSubway : SubwaySandwich
    {
        private readonly ISubwayRecipeFactory subwayRecipe;
        public SteakCheeseSubway(ISubwayRecipeFactory subwayRecipe)
        {
            this.subwayRecipe = subwayRecipe;
        }

        public override void Prepare(TypeOfSubway subway, TypeOfBread bread, BreadSize size)
        {
            RecipeName = "Steak & Cheese";
            Bread = bread;
            Size = size;
            Proteins = subwayRecipe.ChooseProteins(subway);
            Cheeses = subwayRecipe.AddCheese(subway);
            Veggies = subwayRecipe.AddVeggies(subway);
            Sauces = subwayRecipe.AddSauces(subway);
        }
    }
}
