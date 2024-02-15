using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.AssertionDemo
{
    [TestClass]
    public class CustomExceptionCreation
    {
        [TestMethod]
        public void TestCustomException()
        {
            string str = "Hello, world!";

            string transformed = str.Remove(0);

            Assert.That.StringIsEmpty(transformed);
        }

        [TestMethod]
        public void TestCustomException2()
        {
            string str = "Hello, world!";

            string transformed = str.Remove(3);

            Assert.That.StringIsEmpty(transformed);
        }
    }

    internal static class CustomAssert
    {
        public static void StringIsEmpty(this Assert assert, string actual)
        {
            if (string.IsNullOrEmpty(actual))
                return;

            throw new AssertFailedException($"Expect empty string but was {actual}");
        }
    }
}
