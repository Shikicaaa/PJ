using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IMatrica
    {
        double this[int i, int j] { get; }
        int Dimenzija {  get; }
    }
}
