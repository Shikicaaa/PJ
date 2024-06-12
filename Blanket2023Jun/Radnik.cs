using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Blanket2023Jun
{
    internal class Radnik
    {
        long jmbg;
        string ime,prezime;
        double plata;
        public Radnik(long jmbg, string ime, string prezime, double plata)
        {
            this.jmbg = jmbg;
            this.ime = ime;
            this.prezime = prezime;
            this.plata = plata;
        }
        public static Dictionary<long,Radnik> ProcitajFajl(string imeFajla)
        {
            Dictionary<long, Radnik> diq = new Dictionary<long,Radnik>();
            try
            {
                FileStream fs = new FileStream(imeFajla, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                
                while (sr.Peek() != null)
                {
                    string line = sr.ReadLine();
                    long _jmbg = long.Parse(line);
                    if (!diq.ContainsKey(_jmbg))
                    {
                        string ime = sr.ReadLine();
                        string prezime = sr.ReadLine();
                        double plata = double.Parse(sr.ReadLine());
                        Radnik r = new Radnik(_jmbg, ime, prezime, plata);
                        diq.Add(_jmbg, r);
                    }
                    else
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            sr.ReadLine();
                        }
                    }

                }
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return diq;
        }
    }
}
