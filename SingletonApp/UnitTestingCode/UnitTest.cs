using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SingletonApp.SingletonCode;

namespace SingletonApp.UnitTestingCode
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var itemFinder = new DataItemFinder(new DummyObject());
            var expected = 242700 + 2228000;

            //Act
            var total = itemFinder.GetTotalPopulationByCities(new[] { "Medellín", "Cali" });

            //Assert
            Assert.AreEqual(expected, total);
        }
    }

    public class DummyObject : IItemContainer
    {
        public int GetPopulationByCapitalName(string capitalName)
        {
            return new Dictionary<string, int>
            {
                ["Bogotá D.C."] = 7413000,
                ["Medellín"] = 242700,
                ["Cali"] = 2228000
            } [capitalName];
        }
    }
}
