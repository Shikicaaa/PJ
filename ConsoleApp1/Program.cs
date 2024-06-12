using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class Program
    {
        public static void NitMetod(object nitIme)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000); // Pauza od 1 sekunde
                Console.WriteLine($"{nitIme} izvršava iteraciju {i}");
                Thread.Sleep(1000);
                Console.WriteLine($"{nitIme} izvršava iteraciju {i}");
            }
        }
        class KompleksniBroj
        {
            public float Realan { get; set; }
            public float Imaginaran { get; set; }
            public override string ToString()
            {
                return Realan + " + j" + Imaginaran;
            }
            public KompleksniBroj(float realan, float imaginaran)
            {
                Realan = realan;
                Imaginaran = imaginaran;
            }
        }
        delegate void PrikaziPoruku();
        class Generator 
        {
            public PrikaziPoruku PrikaziPoruku;
        }
        class Pretplatnik1
        {
            public void Stampa()
            {
                Console.WriteLine("Prvi pretplatnik");
            }
        }

        class Pretplatnik2 {
            public void Stampa()
            {
                Console.WriteLine("Drugi pretplatnik");
            }
        }    
        private static void Inkrement(double pi, DateTime danas, KompleksniBroj broj)
        {
            pi++;
            danas.AddDays(1);
            broj.Realan++;
            broj.Imaginaran++;
        }
        static void Main(string[] args)
        {
            /*Kvadar kvadar = new Kvadar(1, 2, 3);
            Valjak valjak = new Valjak(1, 2);
            if (kvadar > valjak)
            {
                Console.WriteLine("Zapremina kvadra je veca");
            }
            else if (kvadar < valjak)
            {
                Console.WriteLine("Zapremina valjka je veca");
            }
            else 
            {
                Console.WriteLine("Zapremine su jednake");
            }*/
            /*float[] niz = { 1.0f, 2.0f, 3.0f, 4.0f };
            IEnumerable<float> enumerable = new NizEnumerator<float>(niz);
            enumerable.Reset();
            while (enumerable.MoveNext())
            {
                Console.WriteLine(enumerable.Current);
            }*/

            /*int[] niz = { 1, 2, 3, 4, 5 };*/
            Console.WriteLine(ParamsKlasa.SumaKvadrata(1,2,3,4,5));
            Thread nit1 = new Thread(() => NitMetod("Prva nit"));
            Thread nit2 = new Thread(() => NitMetod("Druga nit"));
            /*List<String> list = new List<String>();
            list[0] = "Nula";
            list[0] = "Nula";
            list[1] = "Jedan";
            list[1] = "Jedan";
            list[2] = "Tri";
            list[2] = "Tri";
            foreach(String item in list)
            {
                Console.Write(item + " ");
            }*/
            // Pokretanje niti
            nit1.Start();
            nit2.Start();

            // Čekanje da niti završe
            nit1.Join();
            nit2.Join();

            Console.WriteLine("Glavna nit završava rad.");
            double pi = 3.14;
            DateTime danas = DateTime.Now;
            KompleksniBroj broj = new KompleksniBroj(1.0f, 0.0f);
            Console.WriteLine(pi);
            Console.WriteLine(danas.DayOfWeek);
            Console.WriteLine(broj);
            Inkrement(pi, danas, broj);
            Console.WriteLine(pi);
            Console.WriteLine(danas.DayOfWeek);
            Console.WriteLine(broj);
            IMatrica dijagonalna = new DijagonalnaMatrica(5);
            IMatrica donjetrougaona = new DonjatrougaonaMatrica(5);

            Console.WriteLine("Dijagonalna Matrica:");
            for (int i = 0; i < dijagonalna.Dimenzija; i++)
            {
                for (int j = 0; j < dijagonalna.Dimenzija; j++)
                {
                    Console.Write(dijagonalna[i, j].ToString("0.00") + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Donjetrougaona Matrica:");
            for (int i = 0; i < donjetrougaona.Dimenzija; i++)
            {
                for (int j = 0; j < donjetrougaona.Dimenzija; j++)
                {
                    Console.Write(donjetrougaona[i, j].ToString("0.00") + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
