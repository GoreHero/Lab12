using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите радиус: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ведите точки для проверки:");
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y = ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Окружность имеет параметры:\nДлина = {Circle.Lengh(r)}\nПлощадь = {Circle.Square(r)}");
            
            bool Check = Circle.CheckPoint(x, y, r);
            Console.WriteLine($"Принадлежность точки к Окружности: {Check}");

            Console.WriteLine();
        }
    }
}
