using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSUnitTest
{
    [TestClass]
    public class CSUnitTest
    {

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BmpInfo
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 255)]
            public string FileName;
            public long Offset;
        }

        [DllImport("TestCppDll.dll", EntryPoint = "CreateBMP", CallingConvention = CallingConvention.Cdecl)]
        private extern static int CreateBmp(string FileName, [In, Out] BmpInfo[] array);

        [TestMethod]
        public void CSTestMethod()
        {   
            try
            {
                var array = new BmpInfo[10];

                var cnt = CreateBmp("test", array);

                Console.WriteLine($"count in test: {cnt}");

                foreach (var bmp in array)
                {
                    Console.WriteLine($"fileName: {bmp.FileName} offset:{bmp.Offset}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Assert.Fail();
            }
        }
    }
}
