using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DijagonalnaMatrica : IMatrica
    {
        double[] dijagonala;
        public int Dimenzija {  get; set; }
        public DijagonalnaMatrica(int dimenzija)
        {
            Dimenzija = dimenzija;
            dijagonala = new double[dimenzija];
            Random rand = new Random();
            for (int i = 0; i < dimenzija; i++)
            {
                dijagonala[i] = rand.NextDouble();
            }
        }
        public double this[int i, int j]
        {
            get
            {
                if(i == j)
                {
                    return dijagonala[i];
                }
                return 0.0;
            }
            set
            {
                
            }
        }
    }
}
