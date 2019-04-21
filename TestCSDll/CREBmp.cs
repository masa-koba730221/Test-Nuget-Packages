using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace TestCSDll
{
    public class CREBmp
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

        public int CreateBMP(string fileName, out List<BmpInfo> list)
        {
            var array = new BmpInfo[300];

            var ret = CreateBmp(fileName, array);

            list = new List<BmpInfo>();

            for (int i = 0; i<ret; i++)
            {
                list.Add(array[i]);
            }

            return ret;
        }
    }
}
