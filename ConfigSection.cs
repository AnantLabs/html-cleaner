using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Xml;
namespace HtmlCleaner
{
    public class ConfigSection 
    {
        private static PatternCollection _patterns;
        public static PatternCollection Patterns
        {
            get
            {
                if(_patterns == null)
                {
                    try
                    {
                        XmlDocument doc = new XmlDocument();
                        if(!File.Exists("Patterns.xml"))
                            throw new ConfigurationErrorsException("Couldn't find Patterns.xml file");
                        
                        doc.Load("Patterns.xml");
                        XmlNodeList nodes = doc.GetElementsByTagName("pattern");
                        foreach (XmlNode node in nodes)
                        {
                            
                        }

                    }
                }
            }
        }
    }
}
