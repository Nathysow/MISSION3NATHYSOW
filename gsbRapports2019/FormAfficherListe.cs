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
    public partial class FormAfficherListe : Form
    {
        mission3Entities mesDonnees;
        string famille;
        DataTable table = new DataTable();//créa nouvelle table
        public FormAfficherListe(mission3Entities mesDonnees, string famille)
        {
            InitializeComponent();           


            this.famille = famille;
            this.mesDonnees = mesDonnees;

            var nomMed = from medica in mesDonnees.medicaments
                         join familles in mesDonnees.familles on medica.idFamille equals familles.id
                         where familles.libelle == this.famille
                         select medica;// recuperer les medicaments d'une famille donnée

            this.medicamentBindingSource.DataSource = nomMed.ToList();//affichage des medicament de cette famille en les mettant dans le biding de la combo box

            table.Columns.Add("Medicaments", typeof(string));//ajouter donnée
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Quantites", typeof(string));

            foreach(var test in nomMed.ToList())
            {
                string id = $"{test.id}";
                var quantite2 = (from ofr in mesDonnees.offrirs
                                 where ofr.idMedicament == id
                                 select ofr.quantite).Sum();
                

                table.Rows.Add($"{test.nomCommercial}", id, quantite2);



            }



            dataGridView1.DataSource = table;
        }

        private void cmbBoxNomMedicament_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void medicamentBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void txtboxQuantite_TextChanged(object sender, EventArgs e)
        {

        }

        private void offrirBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Médicament_Click(object sender, EventArgs e)
        {

        }

        private void btnExporter_Click(object sender, EventArgs e)
        {
             try
            {
                if (textBox1.Text != "")
                {
                    string a = textBox1.Text;
                    DataSet ds = new DataSet();
                    ds.Tables.Add(table);
                    ds.WriteXml(a + ".xml");
                    MessageBox.Show("Fichier exporté");
                }
                else
                    MessageBox.Show("Merci d'indiquer le nom de fichier !");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void FormAfficherListe_Load(object sender, EventArgs e)
        {
            label1.Text = "Famille : " + this.famille;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
