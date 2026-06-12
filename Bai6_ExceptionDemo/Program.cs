namespace Bai6_ExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            try
            {

                try
                {
                    Console.WriteLine("Nhap n :");
                    int n = int.Parse(Console.ReadLine());
                    int x = 10 / n;
                    Console.WriteLine(x);

                    //throw new Exception("ABC");
                }

                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("loi chia cho 0");
                    throw ;
                }

                catch (FormatException ex)
                {
                    Console.WriteLine("Loi nhap ky tu khac ");
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                finally //LUOON LUON DDUWOJC THUWJC THI DUF COS LOIX HAY KHONG
                {
                    Console.WriteLine("Good byes");
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
