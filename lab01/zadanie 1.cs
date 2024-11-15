using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj współczynniki równania kwadratowego ax^2 + bx + c = 0");

            Console.Write("Podaj a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Podaj b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Podaj c: ");
            double c = double.Parse(Console.ReadLine());

            
            Console.WriteLine($"Delta wynosi: {Delta(a, b, c)}");
            Oblicz(a, b, c);
        }

        static double Delta(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }

       
        static void Oblicz(double a, double b, double c)
        {
            double delta = Delta(a, b, c);

            if (delta > 0)
            {
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Równanie ma dwa rozwiązania: x1 = {x1}, x2 = {x2}");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Równanie ma jedeo rozwiązanie: x = {x}");
            }
            else
            {
                Console.WriteLine("Równanie nie jest prawidłowe ");
            }
        }
    }
}
