using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _27
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo f = new FileInfo("D:/Radha/C#");
            Console.WriteLine(" size of a file : " + f.Length.ToString());


        }
    }
}
