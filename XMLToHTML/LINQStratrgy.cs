using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Linq;

namespace XMLToHTML
{
    class LINQStratrgy : ISearch
    {
        public List<Tank> Search(Tank targetTank, string filePath)
        {
            XDocument xdoc = XDocument.Load(filePath);
            return (from xe in xdoc.Element("Tanks").Elements("Tank")
                    where ((targetTank.Name == "" || xe.Attribute("Name").Value.ToString().Equals(targetTank.Name)) &&
                           (targetTank.Country == "" || xe.Attribute("Country").Value.ToString().Equals(targetTank.Country)) &&
                           (targetTank.YearOfIssue == "" || xe.Attribute("YearOfIssue").Value.ToString().Equals(targetTank.YearOfIssue)) &&
                           (targetTank.Armor == "" || xe.Attribute("Armor").Value.ToString().Equals(targetTank.Armor)) &&
                           (targetTank.MainCaliber == "" || xe.Attribute("MainCaliber").Value.ToString().Equals(targetTank.MainCaliber)) &&
                           (targetTank.Weight == "" || xe.Attribute("Weight").Value.ToString().Equals(targetTank.Weight)))
                    select new Tank
                    {
                        Name = xe.Attribute("Name").Value.ToString(),
                        Country = xe.Attribute("Country").Value.ToString(),
                        YearOfIssue = xe.Attribute("YearOfIssue").Value.ToString(),
                        Armor = xe.Attribute("Armor").Value.ToString(),
                        MainCaliber = xe.Attribute("MainCaliber").Value.ToString(),
                        Weight = xe.Attribute("Weight").Value.ToString()
                    }).ToList();
        }
    }
}
