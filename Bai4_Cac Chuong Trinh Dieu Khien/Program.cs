namespace Bai4_Cac_Chuong_Trinh_Dieu_Khien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach(string arg in args)
            {
                Console.WriteLine(arg);
            }

            var list = new List<string>();
            foreach (String arg in args)
            {
                list.Add(arg.ToUpper());
            }

            foreach(var s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
