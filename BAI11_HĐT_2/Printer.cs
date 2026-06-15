using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.IO;

namespace BAI11_HĐT_2
{
    public class Printer
    {
        


            public Printer()
            {
                Console.WriteLine("------Hello------");
            }

            public Printer(string name)
            {
                Console.WriteLine($"------Hello------{name}");
            }


        public void print(String massage)
            {
                Console.WriteLine(massage);
            }
        }
    }

