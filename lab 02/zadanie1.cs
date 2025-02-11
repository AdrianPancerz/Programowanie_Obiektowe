using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02
{
    internal class Osoba
    {
        private string imie;
        private string nazwisko;
        private int wiek;

        public string Imie
        {
            get { return imie; }
            set
            {
                if (value.Length >= 2)
                    imie = value;
                else
                    throw new ArgumentException("Imię musi mieć co najmniej 2 znaki.");
            }
        }

        public string Nazwisko
        {
            get { return nazwisko; }
            set
            {
                if (value.Length >= 2)
                    nazwisko = value;
                else
                    throw new ArgumentException("Nazwisko musi mieć co najmniej 2 znaki.");
            }
        }

        public int Wiek
        {
            get { return wiek; }
            set
            {
                if (value > 0)
                    wiek = value;
                else
                    throw new ArgumentException("Wiek musi być liczbą dodatnią.");
            }
        }

        public Osoba(string imie, string nazwisko, int wiek)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine($"Imię: {Imie}, Nazwisko: {Nazwisko}, Wiek: {Wiek}");
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                Osoba osoba = new Osoba("Jan", "Kowalski", 30);
                osoba.WyswietlInformacje();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Błąd: " + ex.Message);
            }
        }
    }

}
