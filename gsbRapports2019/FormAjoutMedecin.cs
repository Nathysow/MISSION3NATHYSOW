using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsbRapports2019
{
    public partial class FormAjoutMedecin : Form
    {
        mission3Entities mesDonnees;
        public FormAjoutMedecin(mission3Entities mesDonnees)
        {
            InitializeComponent();
            this.mesDonnees = new mission3Entities();
        }

        private void FormAjoutMedecin_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            medecin nouvMed = new medecin();

          
            nouvMed.nom = txtNom.Text;
            nouvMed.prenom = txtPrenom.Text;
            nouvMed.adresse = txtAdresse.Text;
            nouvMed.tel = txtTel.Text;
            nouvMed.specialiteComplementaire = txtSpecialiteComplementaire.Text;
            nouvMed.departement = Int32.Parse(txtDepartement.Text);

            mesDonnees.medecins.Add(nouvMed);
            mesDonnees.SaveChanges();



            this.Close();
        }
    }
}
