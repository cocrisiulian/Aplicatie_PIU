using LibrarieModele;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace NivelStocareDate
{
    //clasa AdministrareAngajatii_FisierBinar implementeaza interfata IStocareData
    public class AdministrareAngajatii_FisierBinar : IStocareData
    {
        private const int ID_PRIMUL_ANGAJAT = 1;
        private const int INCREMENT = 1;

        string NumeFisier { get; set; }
        public AdministrareAngajatii_FisierBinar(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sBinFile = File.Open(NumeFisier, FileMode.OpenOrCreate);
            sBinFile.Close();

            //liniile de mai sus pot fi inlocuite cu linia de cod urmatoare deoarece
            //instructiunea 'using' va apela sBinFile.Close();
            //using (Stream sBinFile = File.Open(numeFisier, FileMode.OpenOrCreate)) { }
        }

        public void AddAngajat(Angajat a)
        {
            a.IdAngajat= GetId();

            try
            {
                BinaryFormatter b = new BinaryFormatter();

                //instructiunea 'using' va apela sBinFile.Close();
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Append, FileAccess.Write))
                {
                    //serializare unui obiect
                    b.Serialize(sBinFile, a);
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }

        public List<Angajat> GetAngajati()
        {
            List<Angajat> angajati = new List<Angajat>();
            try
            {
                BinaryFormatter b = new BinaryFormatter();

                //instructiunea 'using' va apela sBinFile.Close();
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Open))
                {

                    while (sBinFile.Position < sBinFile.Length)
                    {
                        //Observati conversia!!!
                        angajati.Add((Angajat)b.Deserialize(sBinFile));
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return angajati;
        }
        public Angajat GetAngajat(int IdAngajat)
        {
            throw new Exception("Optiunea GetAngajat by Id nu este implementata");
        }

        public Angajat GetAngajat(string nume, string prenume)
        {
            throw new Exception("Optiunea GetAngajat nu este implementata");
        }

        public bool UpdateAngajat(Angajat a)
        {
            throw new Exception("Optiunea UpdateAngajat nu este implementata");
        }

        private int GetId()
        {
            int IdAngajat = ID_PRIMUL_ANGAJAT;
            try
            {
                //instructiunea 'using' va apela sBinFile.Close();
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Open))
                {
                    BinaryFormatter b = new BinaryFormatter();

                    //citeste cate o linie si creaza un obiect de tip Angajat pe baza datelor din linia citita
                    while (sBinFile.Position < sBinFile.Length)
                    {
                        //Observati conversia!!!
                        Angajat a = (Angajat)b.Deserialize(sBinFile);
                        IdAngajat = a.IdAngajat + INCREMENT;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return IdAngajat;
        }


    }
}
