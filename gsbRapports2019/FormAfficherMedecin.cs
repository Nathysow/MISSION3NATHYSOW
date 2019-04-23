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
    public partial class FormAfficherMedecin : Form
    {
        mission3Entities mesDonnees;
        string medecin;
        public string id;
        DataTable table = new DataTable();
        public FormAfficherMedecin(mission3Entities mesDonnees, string medecin)

        {
            
            InitializeComponent();
            this.mesDonnees = mesDonnees;
            this.medecin = medecin;
            dataGridView1.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(OnRowHeaderMouseClick);

        }

        private void FormAfficherMedecin_Load(object sender, EventArgs e)
        {
            var nomMed = (from medecin in mesDonnees.medecins
                          where medecin.nom == this.medecin
                          select medecin).ToList().First();// recuperer les medicament d'une famille donnée


            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Nom ", typeof(string));
            table.Columns.Add("prenom", typeof(string));
            table.Columns.Add("adresse", typeof(string));
            table.Columns.Add("tel", typeof(string));
            table.Columns.Add("specialiteComplementaires", typeof(string));
            table.Columns.Add("departement", typeof(string));
            
            
                



                table.Rows.Add($"{nomMed.id}", $"{nomMed.nom}", $"{nomMed.prenom}", $"{nomMed.adresse}", $"{nomMed.tel}", $"{nomMed.specialiteComplementaire}", $"{nomMed.departement}");



            



            dataGridView1.DataSource = table;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        void OnRowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtId.Text = id;
            txtNom.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPrenom.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAdresse.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTel.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSpecialiteComplementaires.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtDepartement.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
        
        private void updat_Click(object sender, EventArgs e)
        {
            int id2 = Int32.Parse(id);
            var result =
                        (from medecin in mesDonnees.medecins
                         where medecin.id ==id2//conversion int
            select medecin).ToList().First();
                    result.nom = txtNom.Text; 
                   result.prenom = txtPrenom.Text;
                   result.adresse = txtAdresse.Text;
            result.tel = txtTel.Text;
            result.specialiteComplementaire = txtSpecialiteComplementaires.Text;
            result.departement = Int32.Parse(txtDepartement.Text);

            mesDonnees.SaveChanges();
                MessageBox.Show("Mis à jour :D!!! ");
                this.Close();
            
        }
    }

       
    
}
