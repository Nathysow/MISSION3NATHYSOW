namespace gsbRapports2019
{
    partial class FormGererListeFamille
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
            this.familleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnValider = new System.Windows.Forms.Button();
            this.cmbFamille = new System.Windows.Forms.ComboBox();
            this.btnCreerFam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(12, 84);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(165, 114);
            this.btnValider.TabIndex = 0;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // cmbFamille
            // 
            this.cmbFamille.FormattingEnabled = true;
            this.cmbFamille.Location = new System.Drawing.Point(12, 57);
            this.cmbFamille.Name = "cmbFamille";
            this.cmbFamille.Size = new System.Drawing.Size(337, 21);
            this.cmbFamille.TabIndex = 1;
            // 
            // btnCreerFam
            // 
            this.btnCreerFam.BackColor = System.Drawing.Color.White;
            this.btnCreerFam.Location = new System.Drawing.Point(184, 84);
            this.btnCreerFam.Name = "btnCreerFam";
            this.btnCreerFam.Size = new System.Drawing.Size(165, 114);
            this.btnCreerFam.TabIndex = 2;
            this.btnCreerFam.Text = "Créer Famille";
            this.btnCreerFam.UseVisualStyleBackColor = false;
            this.btnCreerFam.Click += new System.EventHandler(this.btnCreerFam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(70, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sélectionner une famille";
            // 
            // FormGererListeFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(364, 210);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreerFam);
            this.Controls.Add(this.cmbFamille);
            this.Controls.Add(this.btnValider);
            this.Name = "FormGererListeFamille";
            this.Text = "FormGererListeFamille";
            this.Load += new System.EventHandler(this.FormGererListeFamille_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource familleBindingSource;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ComboBox cmbFamille;
        private System.Windows.Forms.Button btnCreerFam;
        private System.Windows.Forms.Label label1;
    }
}