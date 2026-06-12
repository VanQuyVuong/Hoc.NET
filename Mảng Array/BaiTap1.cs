using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Mảng_Array
{
    public static class BaiTap1
    {
        public static void Bai1()
        {
            int slhs;
            int slmh;
            Console.WriteLine("Nhap so luong hoc sinh :");
            slhs = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so luong mon hoc :");
            slmh = int.Parse(Console.ReadLine());
            double[,] diem = new double[slhs,slmh];
            for (int i = 0; i < slhs; i++)
            {
                Console.WriteLine("Hoc sinh so " + (i + 1));
                for (int j = 0; j < slmh; j++)
                {
                    //Console.WriteLine("Mon hoc so" + k);

                    Console.WriteLine("Nhap diem mon:" + ( j + 1));
                    diem[i,j] = double.Parse(Console.ReadLine());



                }
            }

            KQBai1(diem,slhs,slmh);
            TimMax(diem, slhs, slmh);

        }



        public static void TimMax(double[,]diem, int slhs, int slmh)
        {
            for (int i = 0; i < slhs; i++)
            {

                double max = diem[i, 0];

                for (int j = 0; j <slmh; j++)
                {
                    if (diem[i, j] >= max)
                    {
                        max = diem[i, j];
                    }

                }
                Console.WriteLine($"Hoc sinh {i + 1} co diem max la {max}");
            }
        }


        public static void KQBai1(double[,] diem, int slhs, int slmh)
        {
            Console.WriteLine("Danh sach :");
            for (int i = 0; i < slhs; i++)
            {
                Console.WriteLine("Hoc sinh " + (i+1));
                for (int j = 0; j < slmh; j++)
                {
                    Console.WriteLine($"Mon {j + 1}: {diem[i,j]}");
                }
            }
            
        }
    }
}

