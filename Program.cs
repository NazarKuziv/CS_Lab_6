using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equilateral e1=new Equilateral();
            Equilateral.Triangle t1 = new Equilateral.Triangle(5, 3, 4);
            Console.WriteLine("Equilateral: {0}", Equilateral.GetCounter());
            Console.WriteLine("Equilateral::Triangle: {0}", Equilateral.Triangle.GetCounter()); 
            Console.WriteLine("Equilateral::Triangle::t1:");
            t1.Display();
            
            Console.WriteLine("Equilateral::e1:");
            e1.Read();

            Console.ReadKey();


        }
    }
}
