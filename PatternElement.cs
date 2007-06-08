using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Text.RegularExpressions;
namespace HtmlCleaner
{
    public class PatternElement 
    {
        private string _pattern;
        private string _name;
        private string _replaceString;
        private Regex _compiledRegEx;

        public PatternElement()
        {
            
        }
        public PatternElement(string name)
        {
            Name = name;
        }
        
        public Regex CompiledRegex
        {
            get
            {
                if(_compiledRegEx == null)
                    _compiledRegEx = new Regex(Pattern, RegexOptions.IgnoreCase);
                return _compiledRegEx;
            }
            set
            {
                _compiledRegEx = value;
            }
        }

        public string Pattern
        {
            get { return _pattern; }
            set { _pattern = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string ReplaceString
        {
            get { return _replaceString; }
            set { _replaceString = value; }
        }
    }
}
