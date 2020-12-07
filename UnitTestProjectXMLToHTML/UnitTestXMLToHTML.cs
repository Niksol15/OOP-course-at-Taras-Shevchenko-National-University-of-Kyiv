using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace XMLToHTML
{
    [TestClass]
    public class UnitTestSearch
    {
        private Tank Tiger = new Tank
        {
            Name = "Tiger",
            Country = "Third Reich",
            YearOfIssue = "1942",
            MainCaliber = "88mm",
            Armor = "100mm",
            Weight = "57ton"
        };

        private Tank Sherman = new Tank
        {
            Name = "M4A1 Sherman",
            Country = "USA",
            YearOfIssue = "1942",
            MainCaliber = "76mm",
            Armor = "45mm",
            Weight = "30ton"
        };

        private Tank T34 = new Tank
        {
            Name = "T-34",
            Country = "USSR",
            YearOfIssue = "1939",
            MainCaliber = "76mm",
            Armor = "45mm",
            Weight = "30ton",
        };

        [TestMethod]
        public void TestDOMSearch()
        {
            DOMStrategy dom = new DOMStrategy();
            Tank targetTank = new Tank();
            targetTank.SetProperty("YearOfIssue", "1942");
            string exprcted = Tiger.ToString() + Sherman.ToString();
            List<Tank> actualList = dom.Search(targetTank, 
                @"D:\Project\OOP\OOP-course-at-Taras-Shevchenko-National-University-of-Kyiv\XMLToHTML\XMLTanks.xml");

            string actualString = "";
            foreach (Tank tank in actualList)
            {
                actualString += tank.ToString();
            }
            Assert.AreEqual(exprcted, actualString);
        }

        [TestMethod]
        public void TestSAXSearch()
        {
            SAXStrategy sax = new SAXStrategy();
            Tank targetTank = new Tank();
            targetTank.SetProperty("Country", "USSR");
            string exprcted = T34.ToString();
            List<Tank> actualList = sax.Search(targetTank,
                @"D:\Project\OOP\OOP-course-at-Taras-Shevchenko-National-University-of-Kyiv\XMLToHTML\XMLTanks.xml");

            string actualString = "";
            foreach (Tank tank in actualList)
            {
                actualString += tank.ToString();
            }
            Assert.AreEqual(exprcted, actualString);
        }

        [TestMethod]
        public void TestLINQSearch()
        {
            SAXStrategy linq = new SAXStrategy();
            Tank targetTank = new Tank();
            targetTank.SetProperty("MainCaliber", "76mm");
            string exprcted = T34.ToString() + Sherman.ToString();
            List<Tank> actualList = linq.Search(targetTank,
                @"D:\Project\OOP\OOP-course-at-Taras-Shevchenko-National-University-of-Kyiv\XMLToHTML\XMLTanks.xml");

            string actualString = "";
            foreach (Tank tank in actualList)
            {
                actualString += tank.ToString();
            }
            Assert.AreEqual(exprcted, actualString);
        }
    }
}
