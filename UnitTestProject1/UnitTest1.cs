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
            var a = new Treap(7, 10,
                new Treap(4, 6, new Treap(2, 4, new Treap(0, 3, null, null), new Treap(3, 3, null, null)), new Treap(6, 2, new Treap(5, 1, null, null), null)),
                new Treap(13, 8, new Treap(9, 7, null, new Treap(11, 3, null, null)), new Treap(14, 4, null, null)));
            a.Add()

            Assert.AreEqual("0 => 2 => 3 => 4 => 5 => 6 => 7 => 9 => 11 => 13 => 14 =>",a. )
        }
    }
}
