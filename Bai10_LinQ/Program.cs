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

            //var ns = from n in dataSource
            //         where  GreaterThan0(n)  && n%2==0//(n >= 0)
            //         select n;
            //Print(ns);

            var ns = dataSource.Where(n => GreaterThan0(n) && n % 2 == 0);
            Print(ns);
        }

        static bool GreaterThan0(int n)
        {
            return (n > 0);
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

