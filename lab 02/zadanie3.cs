using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02
{
    internal class student
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        private List<int> tablica;


        public student(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            tablica = new List<int>();
        }

        public void dodaj_ocene(int ocena)
        {
            tablica.Add(ocena);
        }

        public double srednia_ocen
        {
            get
            {
                if(tablica.Count > 0)
                {
                    return tablica.Average();
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
