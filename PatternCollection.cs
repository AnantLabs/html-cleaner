using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
namespace HtmlCleaner
{
    public class PatternCollection : ConfigurationElementCollection
    {
        public override
            ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return
                    ConfigurationElementCollectionType.AddRemoveClearMap;
            }
        }

        protected override
            ConfigurationElement CreateNewElement()
        {
            return new PatternElement();
        }


        protected override
            ConfigurationElement CreateNewElement(
            string elementName)
        {
            return new PatternElement(elementName);
        }


        protected override Object
            GetElementKey(ConfigurationElement element)
        {
            return ((PatternElement)element).Name;
        }


        public new string AddElementName
        {
            get
            { return base.AddElementName; }

            set
            { base.AddElementName = value; }

        }

        public new string ClearElementName
        {
            get
            { return base.ClearElementName; }

            set
            { base.AddElementName = value; }

        }

        public new string RemoveElementName
        {
            get
            { return base.RemoveElementName; }


        }

        public new int Count
        {

            get { return base.Count; }

        }


        public PatternElement this[int index]
        {
            get
            {
                return (PatternElement)BaseGet(index);
            }
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }

        new public PatternElement this[string Name]
        {
            get
            {
                return (PatternElement)BaseGet(Name);
            }
        }

        public int IndexOf(PatternElement pattern)
        {
            return BaseIndexOf(pattern);
        }

        public void Add(PatternElement pattern)
        {
            BaseAdd(pattern);

            // Add custom code here.
        }

        protected override void
            BaseAdd(ConfigurationElement element)
        {
            BaseAdd(element, false);
            // Add custom code here.
        }

        public void Remove(PatternElement pattern)
        {
            if (BaseIndexOf(pattern) >= 0)
                BaseRemove(pattern.Name);
        }

        public void RemoveAt(int index)
        {
            BaseRemoveAt(index);
        }

        public void Remove(string name)
        {
            BaseRemove(name);
        }

        public void Clear()
        {
            BaseClear();
            // Add custom code here.
        }

    }
}
