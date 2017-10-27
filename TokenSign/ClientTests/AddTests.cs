using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Tests
{
    [TestClass()]
    public class AddTests
    {
        [TestMethod()]
        public void AdddTest()
        {
            Add ad = new Add();
            int ret = ad.Addd(1, 1);
            Assert.AreEqual(3, ret);
        }
    }
}