using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            for (int i =0 ; i < 10 ; i++)
            {
                Console.Write("Enter a number: ");
                num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }
            }
            Console.ReadLine();
        }
    }
}
