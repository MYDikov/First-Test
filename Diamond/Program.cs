using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//MIROSLAV/



    Console.WriteLine("TEST GitHub");   
namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var leftRight = (n - 1) / 2;
            
            for (int i =1; i<=(n-1)/2; i++)
            {
                Console.Write(new string('-', leftRight));
                Console.Write("*");
                var mid = n - 2 * leftRight - 2;
                if (mid >=0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }
                
                Console.WriteLine(new string('-', leftRight));
                leftRight--;
            }

            //midlle//
           


            //bottom//
            for (int i = 0; i < (n - 1) / 2; i++)
            {
                Console.Write(new string('-', leftRight));
                Console.Write("*");
                var mid = n - 2 * leftRight - 2;
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }

                Console.WriteLine(new string('-', leftRight));
                leftRight++;

                //bottom2//
                
            }

            Console.Write(new string('-', leftRight));
            Console.Write("*");
            if (n%2==0)
            {
                Console.Write("*");
            }
           Console.WriteLine(new string('-', leftRight));
        }

    }
}
