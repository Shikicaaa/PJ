using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{
    internal class DonjatrougaonaMatrica : IMatrica
    {
        double[][] trougao;
        public int Dimenzija { get; set; }
        public DonjatrougaonaMatrica(int dimenzija)
        {
            Dimenzija = dimenzija;
            trougao = new double[dimenzija][];
            Random random = new Random();
            for (int i = 0; i < dimenzija; i++)
            {
                trougao[i] = new double[i+1];
                for (int j = 0; j <= i; j++)
                {
                    trougao[i][j] = random.NextDouble();
                }
            }
        }
        public double this[int i, int j]
        {
            get { 
                if (j <= i) 
                {
                    return trougao[i][j];
                }
                return 0.0;
            }
            set
            {

            }
        }
        public static DonjatrougaonaMatrica operator+(DonjatrougaonaMatrica d1, DonjatrougaonaMatrica d2)
        {
            DonjatrougaonaMatrica tmp = d1;
            for (int i = 0; i < tmp.Dimenzija; i++)
            {
                tmp[i, i] += d2[i, i];
            }
            return tmp;
        }

    }
}
