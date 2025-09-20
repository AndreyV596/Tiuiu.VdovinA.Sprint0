using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tiuiu.VdovinA.Sprint0.Task3.V0.Lib;


namespace Tiuiu.VdovinA.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}
