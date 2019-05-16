using System;
using System.Configuration;
using System.IO;
using System.Xml;
using System.Xml.XPath;

namespace EAAutoFramework.Config
{
   public class ConfigReader
    {

        public static void SetFrameWorkSettings() {

            XPathItem aut;
            

            string strFileName = Environment.CurrentDirectory.ToString() + "\\Config\\GlobalConfig.xml";
            FileStream stream = new FileStream(strFileName, FileMode.Open);
            XPathDocument document = new XPathDocument(stream);
            XPathNavigator navigator = document.CreateNavigator();

            aut = navigator.SelectSingleNode("EAAutoFramework/RunSettings/AUT");
            Settings.AUT = aut.ToString();

        }
    }
}
