using System;
using System.Windows.Forms;

namespace EvidentaAngajati_UI_WindowsForms
{
    partial class Angajati_IT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbProgrameSpecializari = new System.Windows.Forms.GroupBox();
            this.rdbQualityAssurance = new System.Windows.Forms.RadioButton();
            this.rdbBackend = new System.Windows.Forms.RadioButton();
            this.rdbFrontend = new System.Windows.Forms.RadioButton();
            this.lblSpecializare = new System.Windows.Forms.Label();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.lstAfisare = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonCauta = new System.Windows.Forms.Button();
            this.gpbProgrameSpecializari.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbProgrameSpecializari
            // 
            this.gpbProgrameSpecializari.Controls.Add(this.rdbQualityAssurance);
            this.gpbProgrameSpecializari.Controls.Add(this.rdbBackend);
            this.gpbProgrameSpecializari.Controls.Add(this.rdbFrontend);
            this.gpbProgrameSpecializari.Location = new System.Drawing.Point(147, 117);
            this.gpbProgrameSpecializari.Margin = new System.Windows.Forms.Padding(4);
            this.gpbProgrameSpecializari.Name = "gpbProgrameSpecializari";
            this.gpbProgrameSpecializari.Padding = new System.Windows.Forms.Padding(4);
            this.gpbProgrameSpecializari.Size = new System.Drawing.Size(277, 100);
            this.gpbProgrameSpecializari.TabIndex = 39;
            this.gpbProgrameSpecializari.TabStop = false;
            // 
            // rdbQualityAssurance
            // 
            this.rdbQualityAssurance.AutoSize = true;
            this.rdbQualityAssurance.Location = new System.Drawing.Point(20, 62);
            this.rdbQualityAssurance.Margin = new System.Windows.Forms.Padding(4);
            this.rdbQualityAssurance.Name = "rdbQualityAssurance";
            this.rdbQualityAssurance.Size = new System.Drawing.Size(127, 17);
            this.rdbQualityAssurance.TabIndex = 10;
            this.rdbQualityAssurance.TabStop = true;
            this.rdbQualityAssurance.Text = "Quality-Assurance";
            this.rdbQualityAssurance.UseVisualStyleBackColor = true;
            // 
            // rdbBackend
            // 
            this.rdbBackend.AutoSize = true;
            this.rdbBackend.Location = new System.Drawing.Point(20, 11);
            this.rdbBackend.Margin = new System.Windows.Forms.Padding(4);
            this.rdbBackend.Name = "rdbBackend";
            this.rdbBackend.Size = new System.Drawing.Size(79, 17);
            this.rdbBackend.TabIndex = 8;
            this.rdbBackend.TabStop = true;
            this.rdbBackend.Text = "Back-end";
            this.rdbBackend.UseVisualStyleBackColor = true;
            // 
            // rdbFrontend
            // 
            this.rdbFrontend.AutoSize = true;
            this.rdbFrontend.Location = new System.Drawing.Point(20, 37);
            this.rdbFrontend.Margin = new System.Windows.Forms.Padding(4);
            this.rdbFrontend.Name = "rdbFrontend";
            this.rdbFrontend.Size = new System.Drawing.Size(79, 17);
            this.rdbFrontend.TabIndex = 9;
            this.rdbFrontend.TabStop = true;
            this.rdbFrontend.Text = "Front-end";
            this.rdbFrontend.UseVisualStyleBackColor = true;
            // 
            // lblSpecializare
            // 
            this.lblSpecializare.AutoSize = true;
            this.lblSpecializare.Location = new System.Drawing.Point(43, 154);
            this.lblSpecializare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecializare.Name = "lblSpecializare";
            this.lblSpecializare.Size = new System.Drawing.Size(83, 13);
            this.lblSpecializare.TabIndex = 38;
            this.lblSpecializare.Text = "Specializarea";
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(285, 251);
            this.btnAfiseaza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(139, 28);
            this.btnAfiseaza.TabIndex = 34;
            this.btnAfiseaza.Text = "Afiseaza";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.BtnAfiseaza_Click);
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(147, 71);
            this.txtPrenume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(277, 20);
            this.txtPrenume.TabIndex = 32;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(147, 36);
            this.txtNume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(277, 20);
            this.txtNume.TabIndex = 31;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(147, 251);
            this.btnAdauga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(124, 28);
            this.btnAdauga.TabIndex = 30;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.BtnAdauga_Click);
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(43, 80);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(56, 13);
            this.lblPrenume.TabIndex = 28;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(43, 44);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(39, 13);
            this.lblNume.TabIndex = 27;
            this.lblNume.Text = "Nume";
            // 
            // lstAfisare
            // 
            this.lstAfisare.FormattingEnabled = true;
            this.lstAfisare.Location = new System.Drawing.Point(46, 357);
            this.lstAfisare.Name = "lstAfisare";
            this.lstAfisare.Size = new System.Drawing.Size(527, 95);
            this.lstAfisare.TabIndex = 42;
            // 
            // Angajati_IT
            // cauta
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 720);
            this.Controls.Add(this.lstAfisare);
            this.Controls.Add(this.gpbProgrameSpecializari);
            this.Controls.Add(this.lblSpecializare);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Angajati_IT";
            this.Text = "Informatii Angajati Firma IT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbProgrameSpecializari.ResumeLayout(false);
            this.gpbProgrameSpecializari.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void DataGridAngajati_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.GroupBox gpbProgrameSpecializari;
        private System.Windows.Forms.RadioButton rdbQualityAssurance;
        private System.Windows.Forms.RadioButton rdbBackend;
        private System.Windows.Forms.RadioButton rdbFrontend;
        private System.Windows.Forms.Label lblSpecializare;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.ListBox lstAfisare;
        private EventHandler gpbProgrameSpecializari_Enter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button buttonCauta;
    }
}

