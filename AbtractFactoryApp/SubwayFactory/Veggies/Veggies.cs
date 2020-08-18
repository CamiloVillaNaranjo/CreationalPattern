namespace AbstractFactoryApp.SubwayFactory.Veggies
{
    public class Onions : IVeggie
    {
        public string Description => "Onion Slices";
    }

    public class Cucumbers : IVeggie
    {
        public string Description => "Cucumber slices";
    }

    public class Tomatoes : IVeggie
    {
        public string Description => "Tomato slices";
    }

    public class Lettuce : IVeggie
    {
        public string Description => "Chopped lettuce leaf";
    }

    public class CrispLettuce : IVeggie
    {
        public string Description => "Crisp lettuce";
    }

    public class GreenPeppers : IVeggie
    {
        public string Description => "Green pepper sliced";
    }

    public class Spinach : IVeggie
    {
        public string Description => "Chopped spinach leaf";
    }
}
