using LibrarieModele;
using System.Collections.Generic;

namespace NivelStocareDate
{
    //definitia interfetei
    public interface IStocareData
    {
        void AddAngajat(Angajat a);
        List<Angajat> GetAngajati();
        Angajat GetAngajat(string nume, string prenume);
        Angajat GetAngajat(int idAngajat);
        bool UpdateAngajat(Angajat s);
    }
}
