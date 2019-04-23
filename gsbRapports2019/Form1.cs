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
    public partial class Form1 : Form
    {
        private mission3Entities mesDonnees;
        public Form1()
        {
            InitializeComponent();
            this.mesDonnees = new mission3Entities(); //declaration de mes donnees (lien entre le programme et le BDD)
        }

        private void gererToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGererListeFamille f = new FormGererListeFamille(mesDonnees);
            f.Show();
        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListeFamille f = new FormListeFamille(mesDonnees);//creer fenetre avec les données BDD(formlistFamille)
            f.Show();//afficher fenetre
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGererListeFamille f = new FormGererListeFamille(mesDonnees); //creer fenetre avec les données BDD(formGererlistefamille)
            f.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormListeFamille f = new FormListeFamille(mesDonnees);//creer fenetre avec le données(médic offerts)
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormGererMedecin f = new FormGererMedecin(mesDonnees);
            f.Show();
            //rip
        }

        private void majToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGererMedecin f = new FormGererMedecin(mesDonnees);
            f.Show();
        }
    }
}
