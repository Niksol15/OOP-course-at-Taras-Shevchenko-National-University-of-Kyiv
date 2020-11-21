using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace XMLToHTML
{
    static class XMLLoader
    {
        public static readonly List<string> attributes = new List<string>() { "Name", "Country", "YearOfIssue", "MainCaliber", "Armor", "Weight" };
        public static Dictionary<string, HashSet<string>> LoadXML(string filepath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filepath);
            XmlElement xmlRoot = xmlDoc.DocumentElement;
            Dictionary<string, HashSet<string>> res = new Dictionary<string, HashSet<string>>();
            foreach (string atr in attributes)
            {
                res.Add(atr, new HashSet<string>());
            }
            foreach (XmlNode xmlNode in xmlRoot)
            {
                foreach (XmlAttribute atr in xmlNode.Attributes)
                {
                    res[atr.Name].Add(atr.Value);
                }
            }
            return res;
        }

    }
}
