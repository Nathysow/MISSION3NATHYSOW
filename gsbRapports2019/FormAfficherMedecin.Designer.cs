namespace gsbRapports2019
{
    partial class FormAfficherMedecin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDepartement = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtSpecialiteComplementaires = new System.Windows.Forms.TextBox();
            this.updat = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(250, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(273, 170);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtDepartement
            // 
            this.txtDepartement.Location = new System.Drawing.Point(439, 134);
            this.txtDepartement.Name = "txtDepartement";
            this.txtDepartement.Size = new System.Drawing.Size(100, 20);
            this.txtDepartement.TabIndex = 1;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(176, 134);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(312, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 3;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(439, 91);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(100, 20);
            this.txtAdresse.TabIndex = 4;
            this.txtAdresse.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(176, 91);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 5;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(312, 91);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 6;
            // 
            // txtSpecialiteComplementaires
            // 
            this.txtSpecialiteComplementaires.Location = new System.Drawing.Point(312, 134);
            this.txtSpecialiteComplementaires.Name = "txtSpecialiteComplementaires";
            this.txtSpecialiteComplementaires.Size = new System.Drawing.Size(100, 20);
            this.txtSpecialiteComplementaires.TabIndex = 7;
            // 
            // updat
            // 
            this.updat.Location = new System.Drawing.Point(579, 158);
            this.updat.Name = "updat";
            this.updat.Size = new System.Drawing.Size(125, 62);
            this.updat.TabIndex = 8;
            this.updat.Text = "Update";
            this.updat.UseVisualStyleBackColor = true;
            this.updat.Click += new System.EventHandler(this.updat_Click);
            // 
            // DELETE
            // 
            this.DELETE.Location = new System.Drawing.Point(579, 238);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(125, 57);
            this.DELETE.TabIndex = 9;
            this.DELETE.Text = "Delete";
            this.DELETE.UseVisualStyleBackColor = true;
            // 
            // FormAfficherMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.updat);
            this.Controls.Add(this.txtSpecialiteComplementaires);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtDepartement);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAfficherMedecin";
            this.Text = "FormAfficherMedecin";
            this.Load += new System.EventHandler(this.FormAfficherMedecin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDepartement;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtSpecialiteComplementaires;
        private System.Windows.Forms.Button updat;
        private System.Windows.Forms.Button DELETE;
    }
}