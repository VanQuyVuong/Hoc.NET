namespace Bai5_PhuongThuc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mc = new MyClass()
            {
                M = 100
            };
            Printf(mc);

            UpdateMycklas(mc);

            Printf(mc); 
        }

        static void Printf(MyClass mc)
        {
            Console.WriteLine($"mc.M ={mc.M}");
        }

        static void UpdateMycklas(MyClass mc)
        {
            mc.M = 200 ;
            Printf(mc);
        }
    }
}
