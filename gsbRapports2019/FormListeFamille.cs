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
    public partial class FormListeFamille : Form
    {
        private mission3Entities mesDonnees;//déclaration de mes données
        public FormListeFamille(mission3Entities mesDonnees)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;
            this.familleBindingSource.DataSource = mesDonnees.familles.ToList();
        }

        private void cmbBoxListeFamille_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEnvoyerFamille_Click(object sender, EventArgs e)
        {
            string famille = (string)cmbBoxListeFamille.Text;
            FormAfficherListe f = new FormAfficherListe(mesDonnees, famille);
            f.Show();
        }

        private void FormListeFamille_Load(object sender, EventArgs e)
        {

        }
    }
}
