using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Menu_kal();
            }
        }

        static void Menu_kal()
        {
            Console.WriteLine("------------- Kalkulator ---------------");
            Console.WriteLine("1. Suma dwóch liczb");
            Console.WriteLine("2. Różnica dwóch liczb");
            Console.WriteLine("3. Iloczyn dwóch liczb");
            Console.WriteLine("4. Iloraz dwóch liczb");
            Console.WriteLine("5. Potęgowanie");
            Console.WriteLine("6. Pierwiastek kwadratowy");
            Console.WriteLine("7. Funkcje trygonometryczne (sin, cos, tan)");
            Console.WriteLine("8. Wyjście");
            Console.Write("Wybierz opcję: ");

            int opcja = int.Parse(Console.ReadLine());

            kalkulator(opcja);

        }

        static void kalkulator(int numer)
        {
            switch (numer)
            {
                case 1:
                    Console.Write("Podaj pierwszą liczbę: ");
                    double a1 = double.Parse(Console.ReadLine());
                    Console.Write("Podaj drugą liczbę: ");
                    double b1 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Suma: {a1 + b1}");
                    break;
                
                case 2:
                    Console.Write("Podaj pierwszą liczbę: ");
                    double a2 = double.Parse(Console.ReadLine());
                    Console.Write("Podaj drugą liczbę: ");
                    double b2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Różnica: {a2 - b2}");
                    break;

                case 3: 
                    Console.Write("Podaj pierwszą liczbę: ");
                    double a3 = double.Parse(Console.ReadLine());
                    Console.Write("Podaj drugą liczbę: ");
                    double b3 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Iloczyn: {a3 * b3}");
                    break;

                case 4:
                    Console.Write("Podaj pierwszą liczbę: ");
                    double a4 = double.Parse(Console.ReadLine());
                    Console.Write("Podaj drugą liczbę: ");
                    double b4 = double.Parse(Console.ReadLine());
                    if (b4 != 0)
                        Console.WriteLine($"Iloraz: {a4 / b4}");
                    else
                        Console.WriteLine("Nie można dzielić przez 0");
                    break;

                case 5: 
                    Console.Write("Podaj podstawę: ");
                    double podstawa = double.Parse(Console.ReadLine());
                    Console.Write("Podaj wykładnik: ");
                    double wykladnik = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Wynik: {Math.Pow(podstawa, wykladnik)}");
                    break;

                case 6: 
                    Console.Write("Podaj liczbę: ");
                    double liczba = double.Parse(Console.ReadLine());
                    if (liczba >= 0)
                        Console.WriteLine($"Pierwiastek kwadratowy: {Math.Sqrt(liczba)}");
                    else
                        Console.WriteLine("Nie można obliczyć pierwiastka z liczby ujemnej");
                    break;

                case 7: 
                    Console.Write("Podaj kąt w stopniach: ");
                    double katStopnie = double.Parse(Console.ReadLine());
                    double katRadiany = katStopnie * Math.PI / 180; 
                    Console.WriteLine($"sin({katStopnie}°) = {Math.Sin(katRadiany)}");
                    Console.WriteLine($"cos({katStopnie}°) = {Math.Cos(katRadiany)}");
                    Console.WriteLine($"tan({katStopnie}°) = {Math.Tan(katRadiany)}");
                    break;
                case 8:
                    Environment.Exit(0);
                    break;

            }
        }
    }
}
