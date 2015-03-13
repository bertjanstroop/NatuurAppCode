using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NatuurApp.DataAccessLayer;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConnection_Test1()
        {
            DB db = new DB();
            bool Expected = true;
            bool Actual;
            Actual = db.TestConnection();
            Assert.AreEqual(Expected, Actual, "Test Failed, Connection Closed!");
        }
    }
}
