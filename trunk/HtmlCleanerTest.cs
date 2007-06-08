using System;
using System.Collections.Generic;
using System.Text;
using HtmlCleaner;
using NUnit.Framework;
namespace Newsdesk.UnitTests
{
    [TestFixture]
    public class HtmlCleanerTest 
    {
        [Test]
        public void TestEmptyDivsToPTags()
        {
            string html = "<div>blah blah blah</div>";
            html = Cleaner.CleanHtml(html, "EmptyDivsToPTags");
            Assert.AreEqual("<p>blah blah blah</p>", html);

        }
        [Test]
        public void TestRemoveEmptyDivsAndPTags()
        {
            string html = "2.<p>&nbsp;</p> or <div>&nbsp;</div> could be removed.";
            html = Cleaner.CleanHtml(html, "RemoveEmptyDivsAndPTags");
            Assert.AreEqual("2. or  could be removed.", html);
        }
    }
}
