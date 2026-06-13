using System.Data.Common;

namespace Bai10_LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var dataSource = GetIntNumbers();
            //Console.WriteLine("Hello, World!");
            Print(dataSource);

            var ns = from n in dataSource
                     where n >= 0
                     select n;
            Print(ns);
        }


        static IEnumerable<int> GetIntNumbers()
        {
            var ns = new int[] { 1, 2, 3, 4, 898, 56, 8987, 3459, -1, -987, 55, -7 };
            return ns;
        }

        static void Print(IEnumerable<int> values)
        {

            Console.WriteLine("----------------");

            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}

