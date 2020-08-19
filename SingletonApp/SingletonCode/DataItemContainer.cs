using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SingletonApp.SingletonCode
{
    public class DataItemContainer : IItemContainer
    {
        private Dictionary<string, int> _capitals = new Dictionary<string, int>();

        private static Lazy<DataItemContainer> _instance;

        private DataItemContainer()
        {
            Console.WriteLine("Nueva instancia DataItemContainer");
            var fileElements = File.ReadAllLines("Capitals.txt");
            for (int i = 0; i< fileElements.Length; i += 2)
            {
                _capitals.Add(fileElements[i], int.Parse(fileElements[i + 1]));
            }
        }

        public static DataItemContainer GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Lazy<DataItemContainer>(new DataItemContainer());
            }

            return _instance.Value;
        }

        public int GetPopulationByCapitalName(string capitalName)
        {
            return _capitals[capitalName];
        }
    }
}
