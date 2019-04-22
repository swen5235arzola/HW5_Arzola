using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter_Arzola;

namespace UnitTestProject1
{
    [TestClass]
    public class ParserTests
    {
        [TestMethod]
        public void TestParser()
        {
            var parser = new NamesParser(@"\\Mac\Home\Documents\Visual Studio 2015\Projects\NameSorter_Arzola\NameSorter_Arzola\names.txt");
            var names = parser.Parse();

            Assert.IsTrue(names.Count > 0);
        }
    }
}
