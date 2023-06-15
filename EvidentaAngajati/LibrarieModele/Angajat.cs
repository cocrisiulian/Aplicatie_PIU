using LibrarieModele.Enumerari;
using System;
using System.Collections;
using System.Linq;

namespace LibrarieModele
{
    [Serializable]
    public class Angajat
    {
        //constante
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';

        private const int ID = 0;
        private const int NUME = 1;
        private const int PRENUME = 2;
        private const int SPECIALIZARE = 3;
        private readonly string specializare;



        //proprietati auto-implemented
        public int IdAngajat { get; set; } //identificator unic Angajat
        public string Nume { get; set; }
        public string Prenume { get; set; }

        public ProgrameSpecializari Specializare { get; set; }
        public ArrayList Specializari { get; set; }

        public string SpecializariAsString
        {
            get
            {
                return string.Join(SEPARATOR_SECUNDAR_FISIER.ToString(), values: Specializari.ToArray());
            }
        }



        //contructor implicit
        public Angajat()
        {
            Nume = Prenume = string.Empty;
        }

        //constructor cu parametri
        public Angajat(int idAngajat, string nume, string prenume, string specializare)
        {
            this.IdAngajat = idAngajat;
            this.Nume = nume;
            this.Prenume = prenume;
            this.specializare = specializare;
        }

        public Angajat(int idAngajat, string nume, string prenume)
        {
            this.IdAngajat = idAngajat;
            this.Nume = nume;
            this.Prenume = prenume;
            
        }
        //constructor cu un singur parametru de tip string care reprezinta o linie dintr-un fisier text 
        public Angajat(string linieFisier)
        {
            string[] dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            IdAngajat = Convert.ToInt32(dateFisier[ID]);
            Nume = dateFisier[NUME];
            Prenume = dateFisier[PRENUME];


            Specializare = (ProgrameSpecializari)Enum.Parse(typeof(ProgrameSpecializari), dateFisier[SPECIALIZARE]);
            Specializari = new ArrayList();
            //adauga mai multe elemente in lista de specializari
            Specializari.AddRange(dateFisier[SPECIALIZARE].Split(SEPARATOR_SECUNDAR_FISIER));

        }


        public string Info()
        {
            string info = string.Format("Id:{0} Nume:{1} Prenume: {2} Specializare: {3}",
                IdAngajat.ToString(),
                (Nume ?? " NECUNOSCUT "),
                (Prenume ?? " NECUNOSCUT "),
                specializare);
                

            return info;
        }

        public string ConversieLaSir_PentruFisier()
        {

            string obiectAngajatPentruFisier = $"{IdAngajat.ToString()}{SEPARATOR_PRINCIPAL_FISIER}{(Nume ?? " NECUNOSCUT ")}{SEPARATOR_PRINCIPAL_FISIER}{(Prenume ?? " NECUNOSCUT ")}{SEPARATOR_PRINCIPAL_FISIER}{Specializare}{SEPARATOR_PRINCIPAL_FISIER}";

            return obiectAngajatPentruFisier;
        }

        public override string ToString()
        {
            return ConversieLaSir_PentruFisier();
        }

    }
}
