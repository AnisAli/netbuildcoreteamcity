using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecpConsoleApp;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StringConvertTest()
        {
            test t = new test();

            var result = t.ConvertString("abc");

            Assert.AreEqual("abc converted", result);
        }
    }
}
