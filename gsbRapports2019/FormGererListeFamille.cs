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
    public partial class FormGererListeFamille : Form
    {
        private mission3Entities mesDonnees;//declaration de mes donnees
        public FormGererListeFamille(mission3Entities mesDonnees)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;
            this.familleBindingSource.DataSource = mesDonnees.familles.ToList();//
            this.cmbFamille.DataSource = familleBindingSource;
            this.cmbFamille.DisplayMember = "libelle";

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string famille = (string)cmbFamille.Text;
            FormGererAfficherListe f = new FormGererAfficherListe(mesDonnees, famille);
            f.Show();
        }

        private void btnCreerFam_Click(object sender, EventArgs e)
        {
            FormGererCreerFam f = new FormGererCreerFam(mesDonnees);
            f.Show();
        }

        private void FormGererListeFamille_Load(object sender, EventArgs e)
        {

        }

        private void FormGererListeFamille_Load_1(object sender, EventArgs e)
        {

        }
    }
}
