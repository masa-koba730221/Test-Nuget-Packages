using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestCSDll;

namespace CSUnitTest2
{
    [TestClass]
    public class CSUnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            var bmp = new CREBmp();
            var ret = bmp.CreateBMP("Test1", out List<CREBmp.BmpInfo> list);

            Console.WriteLine($"Count: {ret}");

            list.ForEach(item =>
            {
                Console.WriteLine($"FileName: {item.FileName} Offset: {item.Offset}");
            });
        }
    }
}
