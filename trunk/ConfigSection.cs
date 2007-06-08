using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Xml;
namespace HtmlCleaner
{
    internal class ConfigSection 
    {
        private static Dictionary <string, PatternElement> _patterns;
        public static Dictionary<string, PatternElement> Patterns
        {
            get
            {
                if(_patterns == null)
                {
                    XmlNodeList nodes = ConfigXml.GetElementsByTagName("regex");
                    _patterns = new Dictionary<string, PatternElement>();

                    foreach (XmlNode node in nodes)
                    {
                        PatternElement pattern = new PatternElement(node.Attributes["name"].Value);
                        pattern.Pattern = node.SelectSingleNode("pattern").InnerText;
                        pattern.ReplaceString = node.SelectSingleNode("replace").InnerText;
                        _patterns.Add(pattern.Name, pattern);
                    }

                    
                }
                return _patterns;
            }
        }
        protected static XmlDocument ConfigXml
        {
            get
            {
                string configFile = ConfigurationManager.AppSettings["HtmlCleanerConfigFile"];
                if (string.IsNullOrEmpty(configFile))
                    configFile = AppDomain.CurrentDomain.BaseDirectory.TrimEnd('\\') + "\\patterns.xml";

                XmlDocument doc = new XmlDocument();
                try
                {
                    doc.Load(configFile);
                }
                catch (Exception)
                {
                    throw new ConfigurationErrorsException("Couldn't find Patterns.xml file");
                }
                if (doc.DocumentElement == null)
                    throw new ConfigurationErrorsException("Couldn't find Patterns.xml file");
                return doc;
            }
        }

    }
}
