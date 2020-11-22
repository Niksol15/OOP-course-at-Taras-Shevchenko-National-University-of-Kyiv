using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace XMLToHTML
{
    class SAXStrategy : ISearch
    {
        public List<Tank> Search(Tank targetTank, string filePath)
        {
            XmlTextReader xReader = new XmlTextReader(filePath);
            List<Tank> res = new List<Tank>();
            while (xReader.Read())
            {
                if (xReader.Name == "Tank" && xReader.HasAttributes)
                {
                    Tank currTank = new Tank();
                    while (xReader.MoveToNextAttribute())
                    {
                        currTank.SetProperty(xReader.Name, xReader.Value);
                    }
                    if (targetTank.Equals(currTank))
                    {
                        res.Add(currTank);
                    }
                }
            }
            return res;
        }
    }
}
