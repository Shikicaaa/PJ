using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class GeometrijskoTelo
    {
        public GeometrijskoTelo() { }

        public abstract double Zapemina { get; }
        public static bool operator <(GeometrijskoTelo telo1, GeometrijskoTelo telo2)
        {
            return telo1.Zapemina < telo2.Zapemina;
        }
        public static bool operator >(GeometrijskoTelo telo1, GeometrijskoTelo telo2)
        {
            return telo1.Zapemina > telo2.Zapemina;
        }

    }
}
