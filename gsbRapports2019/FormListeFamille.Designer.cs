namespace gsbRapports2019
{
    partial class FormListeFamille
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
            this.cmbBoxListeFamille = new System.Windows.Forms.ComboBox();
            this.familleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEnvoyerFamille = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBoxListeFamille
            // 
            this.cmbBoxListeFamille.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.familleBindingSource, "libelle", true));
            this.cmbBoxListeFamille.DataSource = this.familleBindingSource;
            this.cmbBoxListeFamille.DisplayMember = "libelle";
            this.cmbBoxListeFamille.FormattingEnabled = true;
            this.cmbBoxListeFamille.Location = new System.Drawing.Point(12, 48);
            this.cmbBoxListeFamille.Name = "cmbBoxListeFamille";
            this.cmbBoxListeFamille.Size = new System.Drawing.Size(343, 21);
            this.cmbBoxListeFamille.TabIndex = 9;
            this.cmbBoxListeFamille.SelectedIndexChanged += new System.EventHandler(this.cmbBoxListeFamille_SelectedIndexChanged);
            // 
            // btnEnvoyerFamille
            // 
            this.btnEnvoyerFamille.BackColor = System.Drawing.Color.White;
            this.btnEnvoyerFamille.Location = new System.Drawing.Point(12, 75);
            this.btnEnvoyerFamille.Name = "btnEnvoyerFamille";
            this.btnEnvoyerFamille.Size = new System.Drawing.Size(343, 81);
            this.btnEnvoyerFamille.TabIndex = 8;
            this.btnEnvoyerFamille.Text = "Sélectionner";
            this.btnEnvoyerFamille.UseVisualStyleBackColor = false;
            this.btnEnvoyerFamille.Click += new System.EventHandler(this.btnEnvoyerFamille_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(75, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sélectionner une famille";
            // 
            // FormListeFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(369, 175);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxListeFamille);
            this.Controls.Add(this.btnEnvoyerFamille);
            this.Name = "FormListeFamille";
            this.Text = "FormListeFamille";
            this.Load += new System.EventHandler(this.FormListeFamille_Load);
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxListeFamille;
        private System.Windows.Forms.BindingSource familleBindingSource;
        private System.Windows.Forms.Button btnEnvoyerFamille;
        private System.Windows.Forms.Label label1;
    }
}