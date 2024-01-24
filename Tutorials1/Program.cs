using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials1
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

            Console.Write("Enter The Length : ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Enter The Width : ");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;

            Console.WriteLine("Area is : " + area);

            Console.ReadLine();


        }
    }
}
