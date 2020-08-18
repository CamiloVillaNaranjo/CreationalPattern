namespace AbstractFactoryApp.SubwayFactory.Proteins
{
    public class Bologna : IProtein
    {
        public string Description => "Bologna";
    }
    public class Meatball : IProtein
    {
        public string Description => "Meatball";
    }
    public class SpicyPepperoni : IProtein
    {
        public string Description => "Spicy Pepperoni";
    }
    public class Bacons : IProtein
    {
        public string Description => "Bacons";
    }
    public class TurkeySalami : IProtein
    {
        public string Description => "Turkey salami";
    }

    public class ChickenStrips : IProtein
    {
        public string Description => "Chicken strips";
    }

    public class SavoryChickenBreast : IProtein
    {
        public string Description => "Chicken breast";
    }

    public class Steak : IProtein
    {
        public string Description => "Steak";
    }

    public class TurkeyHam : IProtein
    {
        public string Description => "Turkey ham";
    }
    public class Ham : IProtein
    {
        public string Description => "Ham";
    }
    public class Rib : IProtein
    {
        public string Description => "Rib";
    }
    public class Salami : IProtein
    {
        public string Description => "Salami";
    }
    public class BlackForestHam : IProtein
    {
        public string Description => "Black forest ham";
    }

    public class Tuna : IProtein
    {
        public string Description => "Flaked tuna blended with creamy mayo";
    }

    public class NoProtein : IProtein
    {
        public string Description => "No protein";
    }

}