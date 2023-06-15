using LibrarieModele;
using System.Collections.Generic;
using System.IO;

namespace NivelStocareDate
{
    public class AdministrareAngajati_FisierText: IStocareData
    {
        private const int ID_PRIMUL_ANGAJAT = 1;
        private const int INCREMENT = 1;

        private string numeFisier;

        public AdministrareAngajati_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            // se incearca deschiderea fisierului in modul OpenOrCreate
            // astfel incat sa fie creat daca nu exista
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddAngajat(Angajat angajat)
        {
            angajat.IdAngajat = GetId();

            // instructiunea 'using' va apela la final streamWriterFisierText.Close(); 
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(angajat.ConversieLaSir_PentruFisier());
            }
        }

        public List<Angajat> GetAngajati()
        {
            List<Angajat> angajati = new List<Angajat>();

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                // citeste cate o linie si creaza un obiect de tip Angajat
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Angajat angajat = new Angajat(linieFisier);
                    angajati.Add(angajat);
                }
            }

            return angajati;
        }

        public Angajat GetAngajat(string nume, string prenume)
        {
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                // citeste cate o linie si creaza un obiect de tip Angajat
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Angajat angajat = new Angajat(linieFisier);
                    if (angajat.Nume.Equals(nume) && angajat.Prenume.Equals(prenume))
                        return angajat;
                }
            }

            return null;
        }

        public Angajat GetAngajat(int idAngajat)
        {
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                // citeste cate o linie si creaza un obiect de tip Angajat
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Angajat angajat = new Angajat(linieFisier);
                    if (angajat.IdAngajat == idAngajat)
                        return angajat;
                }
            }

            return null;
        }

        public bool UpdateAngajat(Angajat angajatActualizat)
        {
            List<Angajat> angajati = GetAngajati();
            bool actualizareCuSucces = false;

            //instructiunea 'using' va apela la final swFisierText.Close();
            //al doilea parametru setat la 'false' al constructorului StreamWriter indica modul 'overwrite' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, false))
            {
                foreach (Angajat angajat in angajati)
                {
                    Angajat angajatPentruScrisInFisier = angajat;
                    //informatiile despre angajatul actualizat vor fi preluate din parametrul "angajatActualizat"
                    if (angajat.IdAngajat == angajatActualizat.IdAngajat)
                    {
                        angajatPentruScrisInFisier = angajatActualizat;
                    }
                    streamWriterFisierText.WriteLine(angajatPentruScrisInFisier.ConversieLaSir_PentruFisier());
                }
                actualizareCuSucces = true;
            }

            return actualizareCuSucces;
        }

        private int GetId()
        {
            int IdAngajat = ID_PRIMUL_ANGAJAT;

            // instructiunea 'using' va apela sr.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                //citeste cate o linie si creaza un obiect de tip Angajat pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Angajat angajat = new Angajat(linieFisier);
                    IdAngajat = angajat.IdAngajat + INCREMENT;
                }
            }

            return IdAngajat;
        }
    }
}