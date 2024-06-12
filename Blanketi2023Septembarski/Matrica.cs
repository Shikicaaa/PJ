using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blanketi2023Septembarski
{
    class Matrica : IMatrica
    {
        double [,] matrix;
        readonly int row, col;
        public Matrica() { }
        public Matrica(int row, int col)
        {
            this.row = row;
            this.col = col;
            matrix = new double[row, col];
        }
        public double this[int i, int j]
        {
            get
            {
                return matrix[i, j];
            }
            set
            {
                matrix[i, j] = value;
            }
        }
        public int BrojVrsta {  get
            { return row; }
        }
        public int BrojKolona
        {
            get
            { return col; }
        }
        public static Matrica operator +(Matrica lhs, Matrica rhs)
        {
            if(lhs.BrojVrsta != rhs.BrojVrsta || lhs.BrojKolona != rhs.BrojKolona)
            {
                throw new Exception("Nece da moze zato sto ima neki problem, nemoj da te masiram");
            }
            Matrica tmp = new Matrica(lhs.BrojVrsta, lhs.BrojKolona);

            for (int i = 0; i < lhs.BrojVrsta; i++)
            {
                for (int j = 0; j < rhs.BrojKolona; j++)
                {
                    tmp[i, j] = lhs[i, j] + lhs[i, j];
                }
            }
            return tmp;
        }
    }
}
