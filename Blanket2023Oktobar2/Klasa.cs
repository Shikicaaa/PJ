using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blanket2023Oktobar2
{
    internal class Klasa
    {
        public static int SumaKvadrata(params int[] lista)
        {
            int suma = 0;
            foreach (int x in lista)
            {
                suma += x * x;
            }
            return suma;
        }
    }
}