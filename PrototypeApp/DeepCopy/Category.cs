namespace PrototypeApp.DeepCopy
{
    public class Category: IPrototype<Category>
    {
        public string Name { get; set; }

        public Category(string categoryName)
        {
            Name = categoryName;
        }

        public Category DeepCopy()
        {
            return new Category(Name);
        }
    }
}
