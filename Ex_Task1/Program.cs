using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double square = Rectangle.GetSquare(a, b);
            double perimetr = Rectangle.GetPerimetr(a, b);
            Console.WriteLine($"Площадь = {square}\nПериметр = {perimetr}");

        }
    }
}
