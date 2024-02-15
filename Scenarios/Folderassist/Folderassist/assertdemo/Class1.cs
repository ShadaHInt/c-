using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestProject1.AssertionDemo
{
    [TestClass]
    public class AssertDemoTests
    {
        [TestMethod]
        [TestCategory("AssertTest")]
        public void AssertEqualsWithIntValues()
        {
            int expected = 10;
            int actual = 2 * 5;
            Assert.AreEqual(expected, actual, "Validation failed");
            // Assert.AreEqual(expected + 1, actual,"Validation failed");
            Assert.AreNotEqual(expected, actual, "Validation failed");
        }

        [TestMethod]
        [TestCategory("AssertTest")]
        public void AssertEqualsWithDifferentIntValues()
        {
            Int32 expected = 10;
            Int64 actual = 2 * 5;
            Assert.AreEqual(expected, actual);
            // Assert.AreEqual(expected + 1, actual,"Validation failed");
            Assert.AreNotEqual(expected, actual, "Validation failed");
        }

        [TestMethod]
        [TestCategory("AssertTest")]
        public void AssertEqualsTestWithDoubleValues()
        {
            double expected = 10.747d;
            double actual = 10.749d;
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected, actual, 0.05d);
        }

        [TestMethod]
        [TestCategory("AssertTest")]
        public void AssertEqualsTestWithFloatValues()
        {
            float expected = 10.747f;
            float actual = 10.749f;
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected, actual, 0.05d);
        }

        [TestMethod]
        [TestCategory("AssertTest")]
        public void AssertString()
        {
            string expected = "FOO";
            string actual = "foo".ToUpper();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAreSameObjectsInList()
        {
            User expected = new User() { Id = 2, Username = "Rocky" };
            List<User> userList = new();
            userList.Add(expected);
            User actual = userList.First();
            Assert.AreSame(expected, actual);
        }

        [TestMethod]
        [TestCategory("StringAssert")]
        public void StringAssertMethodTests()
        {
            string stringToTest = "I am a human";
            StringAssert.Contains(stringToTest, "human");
            StringAssert.StartsWith(stringToTest, "I am");
        }

        [TestMethod]
        [TestCategory("StringAssert")]
        public void StringAssertThatMatches()
        {
            Regex regex = new Regex(@"[a-z]+");
            StringAssert.Matches("foo", regex);
            StringAssert.DoesNotMatch("123", regex);
        }

        [TestMethod]
        [TestCategory("StringAssert")]
        public void StringAssertThatEndsWith()
        {
            string full = "Uncle Scrooge";
            string substring = "ooge";
            StringAssert.EndsWith(full, substring); //OK
            substring = "OOGE";
            StringAssert.EndsWith(full, substring); //KO
        }

        [TestMethod]
        [TestCategory("StringAssert")]
        public void StringAssertStartsWithTest()
        {
            string full = "Donald Duck";
            string substring = "Don";
            StringAssert.StartsWith(full, substring); //OK
            substring = "don";
            StringAssert.StartsWith(full, substring); //KO
        }

        [TestMethod]
        public void TestIsNull()
        {
            string nullString = null;
            Assert.IsNull(nullString);
            string notNullString = "hello Mary";
            Assert.IsNotNull(notNullString);
        }

        [TestMethod]
        public void TestIsTrue()
        {
            int a = 10, b = 20;
            Assert.IsTrue(a == 10);
            Assert.IsTrue(b == 20);
            Assert.IsFalse(a == b);
            Assert.IsTrue(a != b);

        }
    }

    class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
    }
}
