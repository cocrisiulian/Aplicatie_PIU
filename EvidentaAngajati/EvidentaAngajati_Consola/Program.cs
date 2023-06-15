using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using LibrarieModele;
using NivelStocareDate;

namespace EvidentaAngajati_Consola
{
    class Program
    {
        static void Main()
        {
            Angajat angajat = new Angajat();
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
			string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            // setare locatie fisier in directorul corespunzator solutiei
            // astfel incat datele din fisier sa poata fi utilizate si de alte proiecte
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;

            AdministrareAngajati_FisierText adminAngajati = new AdministrareAngajati_FisierText(caleCompletaFisier);
            int nrAngajati = 0;
            // acest apel ajuta la obtinerea numarului de angajati inca de la inceputul executiei
            // astfel incat o eventuala adaugare sa atribuie un IdAngajat corect noului angajat
            adminAngajati.GetAngajati();

            string optiune;
            do
            {
                Console.WriteLine("I. Introducere informatii angajat");
                Console.WriteLine("A. Afisarea ultimului angajat introdus");
                Console.WriteLine("F. Afisare angajati din fisier");
                Console.WriteLine("S. Salvare angajat in fisier");
                Console.WriteLine("X. Inchidere program");
                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "I":
                        angajat = CitireAngajatTastatura();

                        break;
                    case "A":
                        AfisareAngajat(angajat);

                        break;
                    case "F":
                        List<Angajat> angajati = adminAngajati.GetAngajati();
                        if (angajati.Count > 0)
                        {
                            AfisareAngajati(angajati);
                        }
                        else
                        {
                            Console.WriteLine("Nu exista angajati inregistrati in fisier.");
                        }
                        break;

                    case "S":
                        int idAngajat = nrAngajati + 1;
                        angajat.IdAngajat = idAngajat;
                        //adaugare angajat in fisier
                        adminAngajati.AddAngajat(angajat);

                        nrAngajati++;

                        break;
                    case "X":
                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }
            } while (optiune.ToUpper() != "X");

            Console.ReadKey();
        }

        public static void AfisareAngajat(Angajat angajat)
        {
            string infoAngajat = string.Format("Angajatul cu id-ul #{0} are numele: {1} {2} si specializarea: {3}",
                    angajat.IdAngajat,
                    angajat.Nume ?? " NECUNOSCUT ",
                    angajat.Prenume ?? " NECUNOSCUT ",
                    angajat.Specializare );

            Console.WriteLine(infoAngajat);
        }

        public static void AfisareAngajati(List<Angajat> angajati)
        {
            Console.WriteLine("Angajatii sunt:");
            foreach (Angajat angajat in angajati)
            {
                AfisareAngajat(angajat);
            }
        }


        public static Angajat CitireAngajatTastatura()
        {
            Console.WriteLine("Introduceti numele");
            string nume = Console.ReadLine();

            Console.WriteLine("Introduceti prenumele");
            string prenume = Console.ReadLine();

            Console.WriteLine("Introduceti specializare");
            string specializare = Console.ReadLine();

            Angajat angajat = new Angajat(0, nume, prenume, specializare);


            return angajat;
        }
    }
}
