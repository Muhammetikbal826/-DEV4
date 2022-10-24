using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖDEV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 20, y = 13, z = 42;
            if (23 == 55 && 76 > 45 && 5 < 12)
            {
                Console.WriteLine("1.DOĞRU");
                Console.Read();
            }
            else Console.WriteLine("1.YANLIŞ");
            Console.Read();

            if (23 >= 23 && 45 != 18) { 
            
                Console.WriteLine("2.DOĞRU");
                Console.Read();
                    }

            else Console.WriteLine("2.YANLIŞ");
            Console.Read();

            if (x>y && z==y && z < x) { 
            

                Console.WriteLine("3.DOĞRU");
                Console.ReadKey();
                    }

            else Console.WriteLine("3.YANLIŞ");
            Console.ReadKey();

            
            if (z >x && y<x)
            {

                Console.WriteLine("4.DOĞRU");
                Console.ReadKey();
            }

            else Console.WriteLine("4.YANLIŞ");
            Console.ReadKey();


            if (x!=z||y<=z)
            {

                Console.WriteLine("5.DOĞRU");
                Console.ReadKey();
            }

            else Console.WriteLine("5.YANLIŞ");
            Console.ReadKey();
        }
    }
}
