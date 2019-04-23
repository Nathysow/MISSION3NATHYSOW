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
    public partial class FormAjouterMed : Form
    {
        mission3Entities mesDonnees;
        string famille;
        public FormAjouterMed(mission3Entities mesDonnees, string famille)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;
            this.famille = famille;

            var idFam = (from medicament in mesDonnees.medicaments
                         join familles in mesDonnees.familles on medicament.idFamille equals familles.id
                         where familles.libelle == famille
                        select medicament.idFamille).ToList();//cherche l'id de la famille par rapoort au libelle de la famille
            if (idFam.Count() != 0)
            {
                txtIdFamMed.Text = idFam.First();
                label1.Text = "Famille : " + this.famille;
            }
            else
            {
                var idFamVide = (from familles in mesDonnees.familles
                                 where familles.libelle == this.famille
                                 select familles.id).ToList().First();
                
                txtIdFamMed.Text = idFamVide;
            }
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            if (txtIdMed.Text != "" && txtNCMed.Text != ""
                && txtIdFamMed.Text != "" && txtCompoMed.Text != "" && txtEffetsMed.Text != "" && txtCIMed.Text != "")
            {
                medicament nouvMed = new medicament();

                nouvMed.id = txtIdMed.Text;
                nouvMed.nomCommercial = txtNCMed.Text;
                nouvMed.idFamille = txtIdFamMed.Text;
                nouvMed.composition = txtCompoMed.Text;
                nouvMed.effets = txtEffetsMed.Text;
                nouvMed.contreIndications = txtCIMed.Text;

                mesDonnees.medicaments.Add(nouvMed);
                mesDonnees.SaveChanges();


                
                this.Close();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
            }
        }

        private void FormAjouterMed_Load(object sender, EventArgs e)
        {
            label7.Text = "Création medicament pour la famille : ";
            label8.Text = this.famille;

        }
    }
}
