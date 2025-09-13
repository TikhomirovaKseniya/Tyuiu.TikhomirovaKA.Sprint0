using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TikhomirovaKA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.TikhomirovaKA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Ксюша";
            var res = DataService.GetMessage(name);
            Assert.AreEqual($"Привет, Ксюша", res);
        }
    }
}
