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
            XmlNodeList searched = xmlRoot.SelectNodes(targrtTank.ToXPath());
            List<Tank> res = new List<Tank>();
            foreach (XmlNode node in searched)
            {
                Tank tank = new Tank();
                foreach(XmlAttribute atr in node.Attributes)
                {
                    tank.SetProperty(atr.Name, atr.Value);
                }
                res.Add(tank);
            }
            return res;
        }
    }
}
