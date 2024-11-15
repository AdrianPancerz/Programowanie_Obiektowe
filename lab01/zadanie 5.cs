using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 20; i >= 0; i--)
            {

                if (i == 2 || i == 6 || i == 9 || i == 15 || i == 19)
                {
                    continue;
                }
                Console.WriteLine(i);

            }
        }
    }
}
