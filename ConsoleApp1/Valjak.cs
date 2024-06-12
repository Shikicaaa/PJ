using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class Valjak : GeometrijskoTelo
    {
        int r, h;
        public Valjak(int r, int h)
        : base()
        {
            this.r = r;
            this.h = h;
        }
        public override double Zapemina
        { 
            get { return 2 * r * r * Math.PI + 2 * r * Math.PI * h; }
        }
    }
}
