using BuilderApp.Builder;

namespace BuilderApp.ConcreteBuilder
{
    public class BbqRibRecipe : SandwichRecipeBuilder
    {
        public BbqRibRecipe()
        {
            _sandwichRecipe = new Product.Sandwich
            {
                RecipeName = "Subway BBQ Rib"
            };
        }

        public override void ChooseBread(BreadType breadType)
        {
            _sandwichRecipe.Bread = breadType;
        }

        public override void AddCheese(CheeseType cheeseType)
        {
            _sandwichRecipe.Cheese= cheeseType;
        }

        public override void AddProtein()
        {
            _sandwichRecipe.Protein = "Tender pork topped";
        }

        public override void AddSauces()
        {
            _sandwichRecipe.Sauces = "Sweet BBQ Sauce";
        }

        public override void AddVegetables()
        {
            _sandwichRecipe.Vegetables = "Crisp lettuce, onions and tangy pickles";
        }
    }
}
