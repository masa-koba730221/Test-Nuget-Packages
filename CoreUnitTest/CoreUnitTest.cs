using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TestCSDll;

namespace CoreUnitTest
{
    [TestClass]
    public class CoreUnitTest
    {
        [TestMethod]
        public void CoreTestMethod1()
        {
            var bmp = new CREBmp();
            var ret = bmp.CreateBMP("Test1", out List<CREBmp.BmpInfo> list);

            Console.WriteLine($"Count: {ret}");

            list.ForEach(item =>
            {
                Console.WriteLine($"FileName: {item.FileName} Offset: {item.Offset}");
            });

            Assert.IsTrue(true);
        }
    }
}
