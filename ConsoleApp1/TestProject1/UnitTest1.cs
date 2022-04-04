using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;


namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = ("Hello world from hemanth");
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Consoleapp.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}