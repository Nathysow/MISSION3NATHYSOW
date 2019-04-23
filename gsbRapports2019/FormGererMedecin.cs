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
    public partial class FormGererMedecin : Form
    {
        mission3Entities mesDonnees;

        
        public FormGererMedecin(mission3Entities mesDonnees)
        {   
            InitializeComponent();
            this.mesDonnees = mesDonnees;
            var nomMedecin = (from medecins in mesDonnees.medecins
                              select medecins.nom).ToList();
            this.cmbListMed.DataSource = nomMedecin;
                        
        }

        private void cmbListMed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string medecin = (string)cmbListMed.Text;
            FormAfficherMedecin f = new FormAfficherMedecin(mesDonnees,medecin);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAjoutMedecin f = new FormAjoutMedecin(mesDonnees);
            f.Show();
        }
    }

}

