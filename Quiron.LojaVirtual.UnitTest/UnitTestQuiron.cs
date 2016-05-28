using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Quiron.LojaVirtual.UnitTest
{
    
    [TestClass]
    public class UnitTestQuiron
    {

        [TestMethod]
        public void Take()
        {
            int[] nums = { 1, 3, 4, 6, 8, 9, 7, 5, 6, 0 };

            var lista = from p in nums.Take(3) select p;
            int[] teste = { 1, 3, 4 };

            CollectionAssert.AreEqual(teste,lista.ToArray());
        }


        [TestMethod]
        public void Skip()
        {
            int[] nums = { 1, 3, 4, 6, 8, 9, 7, 5, 6, 0 };

            var lista = from p in nums.Take(10).Skip(5) select p;
            int[] teste = { 9, 7, 5, 6, 0 };

            CollectionAssert.AreEqual(teste, lista.ToArray());
        }
    }
}
