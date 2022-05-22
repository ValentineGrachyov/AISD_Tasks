using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_TestMethod1()
        {
            var a = new Treap();
            var c = new TreapMethods();
            Assert.AreEqual("0 => 2 => 3 => 4 => 5 => 6 => 7 => 9 => 11 => 13 => 14 =>");
        }
    }
}
