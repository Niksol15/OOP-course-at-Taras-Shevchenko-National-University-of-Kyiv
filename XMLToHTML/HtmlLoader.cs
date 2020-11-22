using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Xsl;

namespace XMLToHTML
{
    static class HtmlSaver
    {
        private static readonly string XSLTPath = "XSLTFile.xsl";
        public static void SaveHTML(string XMLFilePath, string HTMLFilePath = "Output.html")
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(XSLTPath);
            xslt.Transform(XMLFilePath, HTMLFilePath);
        }
    }
}
