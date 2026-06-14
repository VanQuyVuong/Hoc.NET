using System;
using System.Collections.Generic;
using System.Data.Common;

using System.Text;

namespace Bai10_LinQ
{
    internal class Program
    {

        // bài 1
    //    static void Main(string[] args)
    //    {

    //        var dataSource = GetIntNumbers();
    //        //Console.WriteLine("Hello, World!");
    //        Print(dataSource);

    //        var ns = from n in dataSource
    //                 where GreaterThan0(n) && n % 2 == 0//(n >= 0)
    //                 select n;
    //        Print(ns);

    //        //var ns = dataSource.Where(n => GreaterThan0(n) && n % 2 == 0);


    //        //Print(ns);

    //        Console.WriteLine("----------------");

    //        Console.WriteLine(ns.Sum());
    //        Console.WriteLine(ns.Count());

    //    }

    //    static bool GreaterThan0(int n)
    //    {
    //        return (n > 0);
    //    }

    //    static IEnumerable<int> GetIntNumbers()
    //    {
    //        var ns = new int[] { 1, 2, 3, 4, 898, 56, 8987, 3459, -1, -987, 55, -7 };
    //        return ns;
    //    }

    //    static void Print(IEnumerable<int> values)
    //    {

    //        Console.WriteLine("----------------");

    //        foreach (var value in values)
    //        {
    //            Console.WriteLine(value);
    //        }
    //    }



       // ------------------------



        //  bài 2 :class student

        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var students = GetStudents();
            Print(students.Where(s=> s.Yob >= 2000).OrderBy(s => s.Yob).OrderBy(s => s.Name));
        }




        static void Print(IEnumerable<Student> students)
        {
            foreach(var student in students)
            {
                Print(student);
            }
        }


        private static void Print(Student student)
        {
            Console.WriteLine($"Name: {student.Name}, City: {student.City}, Yob: {student.Yob}");
        }
        static IEnumerable<Student> GetStudents()
        {
            return new Student[]
            {
                new Student()
                {
                    Name = "Test 1",
                    City = "DA NANG CỈTY",
                    Yob = 1995
                },
                new Student()
                {
                    Name = "Test 1",
                    City = "DA NANG CỈTY",
                    Yob = 1992
                },
                new Student()
                {
                    Name = "Test 1",
                    City = "DA NANG CỈTY",
                    Yob = 2005
                },

                new Student()
                {
                    Name = "Test 2",
                    City = "DA NANG CỈTY",
                    Yob = 2006
                },

                new Student()
                {
                    Name = "Test 7",
                    City = "DA NANG CỈTY",
                    Yob = 2002
                },
                 new Student()
                {
                    Name = "Test 1",
                    City = "DA NANG CỈTY",
                    Yob = 2002
                },

                new Student()
                {
                    Name = "Test 3",
                    City = "DA NANG CỈTY",
                    Yob = 2007
                }
            };
            ;
        }

    }


}

