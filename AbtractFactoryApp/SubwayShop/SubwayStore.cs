using AbstractFactoryApp.SubwayFactory;
using AbstractFactoryApp.SubwayFactory.Recipies;

namespace AbstractFactoryApp
{
    public abstract class SubwayStore
    {
        public abstract SubwaySandwich CreateSandwich(TypeOfSubway subway);

        public SubwaySandwich OrderSandwich(TypeOfSubway subway, TypeOfBread bread, BreadSize size)
        {
            var subwayRecipe = CreateSandwich(subway);

            subwayRecipe.Prepare(subway, bread, size);

            return subwayRecipe;
        }
    }
}
