using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blanketi2023Septembarski
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrica a = new Matrica(2, 1);
            Matrica b = new Matrica(2, 2);
            a[0, 0] = b[0, 0] = 0;
            b[0, 1] = 1;
            a[1, 0] = b[1, 0] = 2;
            b[1, 1] = 3;
            try
            {
                Matrica c = a + b; 

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.Write(c[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
