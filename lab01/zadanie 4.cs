using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            tablica();
        }


        static void tablica()
        {

            int[] tab = new int[10];
            Console.WriteLine("Podaj 10 liczb");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Podaj liczbę: ");
                tab[i] = int.Parse(Console.ReadLine());

            }
            

            string wybor;
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1. Oblicz sumę elementów tablicy");
                Console.WriteLine("2. Oblicz iloczyn elementów tablicy");
                Console.WriteLine("3. Wyznacz wartość średnią");
                Console.WriteLine("4. Wyznacz wartość maksymalną");
                Console.WriteLine("5. Wyznacz wartość minimalną ");
                Console.WriteLine("6. Koniec ");
                Console.WriteLine("Wybierz co wyświetlić");
                wybor = Console.ReadLine();
                int x = int.Parse(wybor);

                if (x == 1) wyswietlanie_1(tab);
                else if (x == 2) wyswietlanie_2(tab);
                else if (x == 3) wyswietlanie_3(tab);
                else if (x == 4) wyswietlanie_4(tab);
                else if (x == 5) wyswietlanie_5(tab);
                else if (x == 6) Environment.Exit(0);
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Błąd, wybierz z zakresu:");
                }

            }



        }

        static void wyswietlanie_1(int[] tablica)
        {
            int suma = 0;
            for (int i = 0; i < tablica.Length; i++)
            {
                suma = suma + tablica[i]; ;
               
            }
            Console.WriteLine();
            Console.WriteLine($"Suma: {suma}");
           
        }

        static void wyswietlanie_2(int[] tablica)
        {
            int iloczn = 1;
            for (int i = 0; i < tablica.Length; i++)
            {
                iloczn = iloczn * tablica[i]; ;

            }
            Console.WriteLine();
            Console.WriteLine($"Iloczyn: {iloczn} ");
            
        }


        static void wyswietlanie_3(int[] tablica)
        {
            int suma = 0;
            for (int i = 0; i < tablica.Length; i++)
            {
                suma = suma + tablica[i]; ;

            }
            Console.WriteLine();
            Console.WriteLine($"Średnia: {suma/10}");
            
        }


        static void wyswietlanie_5(int[] tablica)
        {
            int min = tablica[0];
            for (int i = 0; i < tablica.Length; i++)
            {
                if (tablica[i] < min)
                {
                    min = tablica[i];   
                }

            }
            Console.WriteLine();
            Console.WriteLine($"Najmniejszy element: {min}");
            
        }

        static void wyswietlanie_4(int[] tablica)
        {
            int max = tablica[0];
            for (int i = 0; i < tablica.Length; i++)
            {
                if (tablica[i] > max)
                {
                    max = tablica[i];
                }

            }
            Console.WriteLine();
            Console.WriteLine($"Największy element: {max}");
            
        }
    }
}
