using EvidentaStudenti_UI_WindowsForms;

using LibrarieModele;
using LibrarieModele.Enumerari;
using NivelStocareDate;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace EvidentaAngajati_UI_WindowsForms
{
    public partial class Angajati_IT : Form
    {
        IStocareData adminAngajati;

        private Label lblHeaderNume;
        private Label lblHeaderPrenume;
        private Label lblHeaderSpecializare;


        private Label[] lblsNume;
        private Label[] lblsPrenume;
        private Label[] lblsSpecializare;


        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 120;
        private const int OFFSET_X = 600;

        ArrayList specializariSelectate = new ArrayList();

        public Angajati_IT()
        {
            
            adminAngajati = StocareFactory.GetAdministratorStocare();

            InitializeComponent();

            //setare proprietati
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.LimeGreen;
            this.Text = "Informatii Angajati";

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Angajat> angajati = adminAngajati.GetAngajati();
            
            AfiseazaAngajati(angajati);
        }

        private void AfiseazaAngajati(List<Angajat> angajati)
        {
            //adaugare control de tip Label pentru 'Nume';
            lblHeaderNume = new Label();
            lblHeaderNume.Width = LATIME_CONTROL;
            lblHeaderNume.Text = "Nume";
            lblHeaderNume.Left = OFFSET_X + 0;
            lblHeaderNume.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblHeaderNume);

            //adaugare control de tip Label pentru 'Prenume';
            lblHeaderPrenume = new Label();
            lblHeaderPrenume.Width = LATIME_CONTROL;
            lblHeaderPrenume.Text = "Prenume";
            lblHeaderPrenume.Left = OFFSET_X + DIMENSIUNE_PAS_X;
            lblHeaderPrenume.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblHeaderPrenume);

            //adaugare control de tip Label pentru 'Specializare';
            lblHeaderSpecializare = new Label();
            lblHeaderSpecializare.Width = LATIME_CONTROL;
            lblHeaderSpecializare.Text = "Specializare";
            lblHeaderSpecializare.Left = OFFSET_X + 2 * DIMENSIUNE_PAS_X;
            lblHeaderSpecializare.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblHeaderSpecializare);

            int nrAngajati = angajati.Count;
            lblsNume = new Label[nrAngajati];
            lblsPrenume = new Label[nrAngajati];
            lblsSpecializare = new Label[nrAngajati];

            int i = 0;
            foreach (Angajat angajat in angajati)
            {
                //adaugare control de tip Label pentru numele angajatilor;
                lblsNume[i] = new Label();
                lblsNume[i].Width = LATIME_CONTROL;
                lblsNume[i].Text = angajat.Nume;
                lblsNume[i].Left = OFFSET_X + 0;
                lblsNume[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsNume[i]);

                //adaugare control de tip Label pentru prenumele angajatilor
                lblsPrenume[i] = new Label();
                lblsPrenume[i].Width = LATIME_CONTROL;
                lblsPrenume[i].Text = angajat.Prenume;
                lblsPrenume[i].Left = OFFSET_X + DIMENSIUNE_PAS_X;
                lblsPrenume[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsPrenume[i]);

                //adaugare control de tip Label pentru specializarea angajatilor
                lblsSpecializare[i] = new Label();
                lblsSpecializare[i].Width = LATIME_CONTROL;
                lblsSpecializare[i].Text = angajat.Specializare.ToString();
                lblsSpecializare[i].Left = OFFSET_X + 2 * DIMENSIUNE_PAS_X;
                lblsSpecializare[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsSpecializare[i]);
                i++;
            }
        }

        private void BtnAdauga_Click(object sender, EventArgs e)
        {

            Angajat a = new Angajat(0, txtNume.Text, txtPrenume.Text);
            ProgrameSpecializari specializareSelectata = GetSpecializare();
            a.Specializare = specializareSelectata;
            //verificare radioButton selectat

            adminAngajati.AddAngajat(a);
            //resetarea controalelor pentru a introduce datele unui angajat nou
            ResetareControale();

        }


        private void ResetareControale()
        {
            txtNume.Text = txtPrenume.Text  = string.Empty;
            
            rdbBackend.Checked = false;
            rdbFrontend.Checked = false;
            rdbQualityAssurance.Checked = false;

            specializariSelectate.Clear();
        }

        private ProgrameSpecializari GetSpecializare()
        {
            if (rdbBackend.Checked)
                return ProgrameSpecializari.Backend;
            if (rdbFrontend.Checked)
                return ProgrameSpecializari.Frontend;
            if (rdbQualityAssurance.Checked)
                return ProgrameSpecializari.QualityAssurance;

            // Afișează o fereastră MessageBox cu mesajul excepției
            MessageBox.Show("Nicio specializare nu a fost selectată.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // În cazul în care nu se selectează nicio specializare, returnează o valoare implicită sau null, în funcție de nevoile tale.
            return ProgrameSpecializari.None;
        }


        private void BtnAfiseaza_Click(object sender, EventArgs e)
        {
            List<Angajat> angajati = adminAngajati.GetAngajati();
            AfiseazaAngajati(angajati);
            AfisareAngajatiInControlListbox(angajati);
        }

        private void AfisareAngajatiInControlListbox(List<Angajat> angajati)
        {
            lstAfisare.Items.Clear();
            foreach (Angajat angajat in angajati)
            {
                //pentru a adauga un obiect de tip Angajat in colectia de Items a unui control de tip ListBox, 
                // clasa Angajat trebuie sa implementeze metoda ToString() specificand cuvantul cheie 'override' in definitie
                //pentru a arata ca metoda ToString a clasei de baza (Object) este suprascrisa
                lstAfisare.Items.Add(angajat);
            }
        }
   }
}
