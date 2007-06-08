using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace HtmlCleaner
{
    public class HtmlCleaner
    {
        private static ConfigSection section = ConfigurationManager.GetSection("HtmlCleaner") as ConfigSection;
        public static string CleanHtml(string html, string patternToRun)
        {
            //If the config section doesn't exist, then give up
            if (section == null)
                throw new Exception("HtmlCleaner configSetting does not exist");

            foreach (PatternElement pattern in section.Patterns)
            {
                if (pattern.Name == patternToRun)
                {
                    html       
                }
            }

            return html;
        }
    }
}
