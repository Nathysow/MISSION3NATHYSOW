namespace gsbRapports2019
{
    partial class FormGererAfficherListe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAjoutMed = new System.Windows.Forms.Button();
            this.medicamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_NomCom = new System.Windows.Forms.TextBox();
            this.txt_IdFm = new System.Windows.Forms.TextBox();
            this.txt_comp = new System.Windows.Forms.TextBox();
            this.txt_effet = new System.Windows.Forms.TextBox();
            this.txt_ci = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(83, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(705, 215);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAjoutMed
            // 
            this.btnAjoutMed.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAjoutMed.Location = new System.Drawing.Point(158, 168);
            this.btnAjoutMed.Name = "btnAjoutMed";
            this.btnAjoutMed.Size = new System.Drawing.Size(160, 49);
            this.btnAjoutMed.TabIndex = 1;
            this.btnAjoutMed.Text = "Ajouter un médicament";
            this.btnAjoutMed.UseVisualStyleBackColor = false;
            this.btnAjoutMed.Click += new System.EventHandler(this.btnAjoutMed_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(328, 168);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(160, 49);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Mise à jour";
            this.btnUpdate.UseVisualStyleBackColor = false;
         
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(158, 62);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(162, 20);
            this.txt_id.TabIndex = 3;
            // 
            // txt_NomCom
            // 
            this.txt_NomCom.Location = new System.Drawing.Point(326, 62);
            this.txt_NomCom.Name = "txt_NomCom";
            this.txt_NomCom.Size = new System.Drawing.Size(154, 20);
            this.txt_NomCom.TabIndex = 4;
            // 
            // txt_IdFm
            // 
            this.txt_IdFm.Location = new System.Drawing.Point(486, 62);
            this.txt_IdFm.Name = "txt_IdFm";
            this.txt_IdFm.ReadOnly = true;
            this.txt_IdFm.Size = new System.Drawing.Size(162, 20);
            this.txt_IdFm.TabIndex = 5;
            // 
            // txt_comp
            // 
            this.txt_comp.Location = new System.Drawing.Point(158, 133);
            this.txt_comp.Multiline = true;
            this.txt_comp.Name = "txt_comp";
            this.txt_comp.Size = new System.Drawing.Size(162, 20);
            this.txt_comp.TabIndex = 6;
            // 
            // txt_effet
            // 
            this.txt_effet.Location = new System.Drawing.Point(326, 133);
            this.txt_effet.Multiline = true;
            this.txt_effet.Name = "txt_effet";
            this.txt_effet.Size = new System.Drawing.Size(162, 20);
            this.txt_effet.TabIndex = 7;
            // 
            // txt_ci
            // 
            this.txt_ci.Location = new System.Drawing.Point(494, 133);
            this.txt_ci.Multiline = true;
            this.txt_ci.Name = "txt_ci";
            this.txt_ci.Size = new System.Drawing.Size(154, 20);
            this.txt_ci.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Id Médicament";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(539, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Id Famille";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Composition";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Effet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(530, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Contre indication";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(494, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 49);
            this.button1.TabIndex = 16;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormGererAfficherListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ci);
            this.Controls.Add(this.txt_effet);
            this.Controls.Add(this.txt_comp);
            this.Controls.Add(this.txt_IdFm);
            this.Controls.Add(this.txt_NomCom);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAjoutMed);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormGererAfficherListe";
            this.Text = "FormGererAfficherListe";
            this.Load += new System.EventHandler(this.FormGererAfficherListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource medicamentBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAjoutMed;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_NomCom;
        private System.Windows.Forms.TextBox txt_IdFm;
        private System.Windows.Forms.TextBox txt_comp;
        private System.Windows.Forms.TextBox txt_effet;
        private System.Windows.Forms.TextBox txt_ci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}