namespace Bai9_BT.Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sum = (int a, int b) => a + b;  //cách viết lambda expression để tính tổng hai số nguyên a và b
            Func<int, int, int>  count = (int c, int d) => c + d; //cách viết lambda expression sử dụng Func delegate để tính tổng hai số nguyên a và b
            Console.WriteLine(sum(3,6));
            Console.WriteLine(count(10, 9));


            var printUpper = (String s) => Console.WriteLine(s.ToUpper());

            printUpper("dvasdfhhg jhadugsa ádgesad jhavsdjsa ");


            var t = object (int a, int b) => a > b ? 0 : "A";
            Console.WriteLine(t(1, 2));
            Console.WriteLine(t(2, 1));
        }
    }
}
