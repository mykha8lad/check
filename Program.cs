using System;
using System.Runtime.InteropServices;

namespace check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Check nC = new Check(10);
            nC.PrintCheck();
        }
    }
}