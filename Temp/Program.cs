using System;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using Temp;
using System.IO;

namespace Temp
{

    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(@"D:\test.txt");
            sw.Write("Suka");
            sw.Close();
        }
    }
}
