using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Apitesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var demo = new Demo();
            var response = demo.GetUsers();
            Assert.AreEqual(2, response.Page);


        }
    }
}
