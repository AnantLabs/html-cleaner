using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace HtmlCleaner
{
    public class Cleaner
    {
        /// <summary>
        /// Runs the named pattern from the patterns.xml file
        /// against the input html
        /// </summary>
        /// <param name="html">The html to clean</param>
        /// <param name="patternToRun">The name of the pattern to run</param>
        /// <returns>The cleaned html</returns>
        public static string CleanHtml(string html, string patternToRun)
        {
            return ConfigSection.Patterns[patternToRun].Replace(html);
        }

        /// <summary>
        /// Runs all the patterns configured in the patterns.xml file
        /// against the input html
        /// </summary>
        /// <param name="html">The html to clean</param>
        /// <returns>The cleaned html</returns>
        public static string CleanHtml(string html)
        {
            foreach (PatternElement pattern in ConfigSection.Patterns.Values)
            {
                html = pattern.Replace(html);
            }
            return html;
        }
    }
}
