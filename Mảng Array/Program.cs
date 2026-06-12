namespace Mảng_Array
{
    internal class Program
    {

        static void Main(string[] args)
        {
            BaiTap1.Bai1();

            
        }
        static void test()
        {
            int sl;
            double[] diem = new double[5] { 2, 4, 6, 8, 0 };
            for (int i = 0; i < diem.Length; i++)
            {


                Console.WriteLine("Hello, World! " + diem[i]);
            }
        }

        static void array_2chieu()
        {
            int[,] mang2chieu =
            {
                {1,3,46,7,8,4,3,6,8,9,4,46,3 },
                {3,6,2,6,4,5,6,9,4,2,4,5,6 }
            };
            Console.WriteLine("Mang da chieu , 2 chieu ");
            Console.WriteLine("In ra 2 chieu :" + mang2chieu[0,9]);
        }

        static void fi()
        {
            int[][] mm = new int[4][];

                mm[0] = new int [4] ;
            mm[0][0] = 1;
         }

        
    }
}
