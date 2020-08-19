using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonApp.SingletonCode
{
    public class DataItemFinder
    {
        private IItemContainer itemContainer;
        public DataItemFinder(IItemContainer itemContainer)
        {
            this.itemContainer = itemContainer;
        }

        public int GetTotalPopulationByCities(IEnumerable<string> cities)
        {
            int totalPopulation = 0;

            foreach (var city in cities)
            {
                totalPopulation += itemContainer.GetPopulationByCapitalName(city);
            }

            return totalPopulation;
        }
    }
}
