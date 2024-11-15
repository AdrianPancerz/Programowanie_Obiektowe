using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            program();

        }
        static void program() {

              Console.WriteLine("Wprowadź liczby całkowite. Aby zakończyć, podaj liczbę mniejszą od zera.");

            while (true)
            {
                Console.Write("Podaj liczbę: ");
                string liczba = Console.ReadLine();


                bool numer = int.TryParse(liczba, out int calkowita);
                if (!numer)
                {
                    Console.WriteLine("Błąd: podj liczbę całkowitą.");
                    continue;
                }


                if (calkowita < 0)
                {
                    Console.WriteLine("Liczba mniejsza od zera - koniec.");
                    break;
                }

                Console.WriteLine($"Wprowadzona liczba: {calkowita}");
            }
        }
    }
}
