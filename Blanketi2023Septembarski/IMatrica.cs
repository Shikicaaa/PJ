

namespace Blanketi2023Septembarski
{
    interface IMatrica
    {
        double this[int i, int j]
        {
            get;
            set;
        }
        int BrojVrsta
        {
            get;
        }
        int BrojKolona
        {
            get;
        }
    }
}
