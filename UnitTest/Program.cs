using System;
using System.Linq;
using System.Linq.Expressions;

namespace UnitTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            UnitTest test = new UnitTest();
            test.TestMethod();

            Console.ReadKey();
        }
    }
}