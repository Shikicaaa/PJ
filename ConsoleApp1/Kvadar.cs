using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Kvadar : GeometrijskoTelo
    {
        int a, b, c;

        int this[i,j,k] { }
        public override double Zapemina { get
            {
                return a * b * c; 
            }
        }
        public Kvadar(int a, int b, int c)
        :base()
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }
}
