using PrototypeApp.Serializing;
using System;

namespace PrototypeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example with ICloneable interface
            var noteBook1 = new Cloneable.Product("Macbook Pro", new Cloneable.Category("Computers"));

            var iPhoneX = (Cloneable.Product)noteBook1.Clone();
            iPhoneX.Name = "IPhone X 64GB";
            iPhoneX.Category.Name = "Cellphones";

            Console.WriteLine(noteBook1);
            Console.WriteLine(iPhoneX);
            Console.WriteLine("*:* ---------------------------- *:*");

            //Example with IPrototype interface.
            var dellComputer = new DeepCopy.Product("Dell Latitude 7490", new DeepCopy.Category("Computers"));
            
            var samSungPhone = dellComputer.DeepCopy();
            samSungPhone.Name = "Samsung Galaxy A70 128GB";
            samSungPhone.Category.Name = "Cellphones";

            Console.WriteLine(dellComputer);
            Console.WriteLine(samSungPhone);
            Console.WriteLine("*:* ---------------------------- *:*");

            //Example with Serialization
            var tvSamsung = new Serializing.Product("Q800T QLED 8K UHD HDR Smart TV", new Serializing.Category("TVs"));

            var lenovo = tvSamsung.Copy();
            lenovo.Name = "Lenovo ThinkBook 14";
            lenovo.Category.Name = "Computers";

            Console.WriteLine(tvSamsung);
            Console.WriteLine(lenovo);

            Console.ReadLine();
        }
    }
}
