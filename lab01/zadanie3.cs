using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            int[] tab = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string wybor;
            while (true) {
                Console.WriteLine();
                Console.WriteLine("1. Wyświetlanie tablicy od pierwszego do ostatniego indeksu");
                Console.WriteLine("2. Wyświetlanie tablicy od ostatniego do pierwszego indeksu.");
                Console.WriteLine("3. Wyświetlanie elementów o nieparzystych indeksach.");
                Console.WriteLine("4. Wyświetlanie elementów o parzystych indeksach.");
                Console.WriteLine("5. Koniec ");
                Console.WriteLine("Wybierz co wyświetlić");
                wybor =  Console.ReadLine();
              int x =  int.Parse(wybor);

                if(x == 1) wyswietlanie_1(tab); 
                else if (x == 2) wyswietlanie_2(tab);
                else if (x == 3) wyswietlanie_3(tab);
                else if (x == 4) wyswietlanie_4(tab);
                else if (x == 5) Environment.Exit(0);
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Błąd, wybierz z zakresu:");
                }

            }



        }

        static void wyswietlanie_1(int [] tablica )
        {
            for (int i = 0; i < tablica.Length; i++) { 
            
                Console.Write(tablica[i]+", ");
            
            }
            Console.WriteLine();    
        }

        static void wyswietlanie_2(int [] tablica)
        {
            for (int i = tablica.Length -1; i >= 0 ; i--) {

                Console.Write(tablica[i] + ", ");

            
            }
            Console.WriteLine();
        }


        static void wyswietlanie_3(int[] tablica)
        {
            for (int i = tablica.Length - 1; i >= 0; i--)
            {
                if(i % 2 != 0)
                Console.Write(tablica[i] + ", ");


            }
            Console.WriteLine(); 
        }


        static void wyswietlanie_4(int[] tablica)
        {
            for (int i = tablica.Length - 1; i >= 0; i--)
            {
                if (i % 2 == 0)
                    Console.Write(tablica[i] + ", ");


            }
        }
    }
}
