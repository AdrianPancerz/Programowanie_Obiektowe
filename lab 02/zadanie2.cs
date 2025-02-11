using lab_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02
{
    internal class Cbankaccountcs
    {
        public decimal saldo { get; private set; }

        public string wlascicel {get; set;}

        public Cbankaccountcs(string wlascicel, decimal saldo)
        {
            wlascicel = wlascicel;
            saldo = saldo;
        }

        public void wplata(decimal kwota)
        {
            if (kwota <= 0) throw new ArgumentException("Kwota wpłaty musi być większa niż zero.");
            else saldo += kwota;
        }

        public void wyplata(decimal kwota)
        {
            if (kwota <= 0)
            {
                throw new ArgumentException("Kwota wypłaty musi być większa niż zero.");
            }
            if (kwota > saldo)
            {
                throw new InvalidOperationException("Niewystarczające środki na koncie.");
            }
            saldo -= kwota;
            Console.WriteLine($"Wypłacono {kwota:C}. Nowe saldo: {saldo:C}");
        }

    }
}
