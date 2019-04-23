namespace gsbRapports2019
{
    partial class FormGererMedecin
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
            this.cmbListMed = new System.Windows.Forms.ComboBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbListMed
            // 
            this.cmbListMed.FormattingEnabled = true;
            this.cmbListMed.Location = new System.Drawing.Point(234, 114);
            this.cmbListMed.Name = "cmbListMed";
            this.cmbListMed.Size = new System.Drawing.Size(237, 21);
            this.cmbListMed.TabIndex = 0;
            this.cmbListMed.SelectedIndexChanged += new System.EventHandler(this.cmbListMed_SelectedIndexChanged);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(307, 141);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 1;
            this.btnValider.Text = "Valider :)";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ptitnouveau";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormGererMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.cmbListMed);
            this.Name = "FormGererMedecin";
            this.Text = "FormGererMedecin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbListMed;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button button1;
    }
}