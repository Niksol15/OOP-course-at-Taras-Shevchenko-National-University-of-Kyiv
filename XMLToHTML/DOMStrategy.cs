using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace XMLToHTML
{
    class DOMStrategy : ISearch
    {
        public List<Tank> Search(Tank targrtTank, string filePath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);
            XmlElement xmlRoot = xmlDoc.DocumentElement;
            List<Tank> res = new List<Tank>();
            foreach (XmlNode xmlNode in xmlRoot)
            {
                Tank currTank = new Tank();
                foreach (XmlAttribute atr in xmlNode.Attributes)
                {
                    currTank.SetProperty(atr.Name, atr.Value);
                }
                if (targrtTank.Equals(currTank))
                {
                    res.Add(currTank);
                }
            }
            return res;
        }
    }
}
