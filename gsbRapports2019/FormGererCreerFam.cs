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
    public partial class FormGererCreerFam : Form
    {
        mission3Entities mesDonnees;
        public FormGererCreerFam(mission3Entities mesDonnees)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            if (txtIdFam.Text != "" && txtLibelFam.Text != "")
            {
                famille nouvFam = new famille();

                nouvFam.id = txtIdFam.Text;
                nouvFam.libelle = txtLibelFam.Text;

                mesDonnees.familles.Add(nouvFam);
                mesDonnees.SaveChanges();

                this.Close();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
            }

        }

        private void FormGererCreerFam_Load(object sender, EventArgs e)
        {

        }
    }
}
