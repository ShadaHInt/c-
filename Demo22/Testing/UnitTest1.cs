using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using APIDemo;

namespace ApiTesting22

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var demo = new Demo22();
            var response = demo.GetUsers();
            Assert.AreEqual(2, response.page);


        }
    }
}
