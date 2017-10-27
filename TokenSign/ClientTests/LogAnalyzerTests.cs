using Client;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientTests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void IsValidFileName_BadExtension_ReturnsFalse()
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.IsValidLogFileName("filewithbadextension.foo");
            Assert.AreEqual(false, result);
        }

        [Test]
        public void IsValidFileName_GoodExtensionLowercase_ReturnsTrue()
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.IsValidLogFileName("filewithgoodextension.slf");
            Assert.AreEqual(true, result);
        }

        [Test]
        [Category("TEST")]
        public void IsValidFileName_GoodExtensionUppercase_ReturnsTrue()
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.IsValidLogFileName("filewithgoodextension.SLF");
            Assert.AreEqual(true, result);
        }


        [TestCase("filewithgoodextension.slf")]
        [TestCase("filewithgoodextension.SLF")]
        public void IsValidFileName_ValidExtensions_ReturnsTrue(string fileName)
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.IsValidLogFileName(fileName);
            Assert.AreEqual(true, result);
        }
    }
}
