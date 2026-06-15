using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.IO;

namespace Bai11_HDT2
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



