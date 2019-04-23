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
    public partial class FormGererAfficherListe : Form
    {
        mission3Entities mesDonnees;
        string famille;
        DataTable table = new DataTable();
        public string id;


        public FormGererAfficherListe(mission3Entities mesDonnees, string famille)
        {
            InitializeComponent();
    
            this.famille = famille;
            this.mesDonnees = mesDonnees;
            dataGridView1.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(OnRowHeaderMouseClick);

            var nomMed = from medica in mesDonnees.medicaments
                         join familles in mesDonnees.familles on medica.idFamille equals familles.id
                         where familles.libelle == this.famille
                         select medica;// recuperer les medicament d'une famille donnée
            

            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Nom Commercial", typeof(string));
            table.Columns.Add("ID Famille", typeof(string));
            table.Columns.Add("Composition", typeof(string));
            table.Columns.Add("Effets", typeof(string));
            table.Columns.Add("Contre indications", typeof(string));

            foreach (var test in nomMed.ToList())
            {
                string id = $"{test.id}";
                


                table.Rows.Add(id, $"{test.nomCommercial}", $"{test.idFamille}", $"{test.composition}", $"{test.effets}", $"{test.contreIndications}");



            }



            dataGridView1.DataSource = table;
        }

        private void btnAjoutMed_Click(object sender, EventArgs e)
        {
            FormAjoutMedecin f = new FormAjoutMedecin(mesDonnees);
            f.Show();
        }

       


        private void FormGererAfficherListe_Load(object sender, EventArgs e)
        {
            var idFam = (from medicament in mesDonnees.medicaments
                         join familles in mesDonnees.familles on medicament.idFamille equals familles.id
                         where familles.libelle == famille
                         select medicament.idFamille).ToList();


            if (idFam.Count() != 0)
            {
                txt_IdFm.Text = idFam.First();
                label1.Text = "Famille : " + this.famille;
            }
            else
            {
                var idFamVide = (from familles in mesDonnees.familles
                                 where familles.libelle == famille
                                 select familles.id).ToList().First();
                txt_IdFm.Text = idFamVide;
            }
        }

        void OnRowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_id.Text = id;
            txt_NomCom.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_IdFm.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_comp.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_effet.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_ci.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "" && txt_NomCom.Text != "" && txt_comp.Text != "" && txt_effet.Text != "" && txt_ci.Text != "")
            {
                var result =
                        from medica in mesDonnees.medicaments
                        where medica.id == id
                        select medica;

                foreach (medicament salut in result.ToList())
                {
                    mesDonnees.medicaments.Remove(salut);

                }
                mesDonnees.SaveChanges();
                MessageBox.Show("Supression éffectuée");
            }
            else
                MessageBox.Show("Merci de remplir tous les champs");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
