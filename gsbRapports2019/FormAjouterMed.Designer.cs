namespace gsbRapports2019
{
    partial class FormAjouterMed
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
            this.txtIdMed = new System.Windows.Forms.TextBox();
            this.txtNCMed = new System.Windows.Forms.TextBox();
            this.txtCompoMed = new System.Windows.Forms.TextBox();
            this.txtEffetsMed = new System.Windows.Forms.TextBox();
            this.txtCIMed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAjout = new System.Windows.Forms.Button();
            this.txtIdFamMed = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIdMed
            // 
            this.txtIdMed.Location = new System.Drawing.Point(27, 104);
            this.txtIdMed.Name = "txtIdMed";
            this.txtIdMed.Size = new System.Drawing.Size(100, 20);
            this.txtIdMed.TabIndex = 0;
            // 
            // txtNCMed
            // 
            this.txtNCMed.Location = new System.Drawing.Point(159, 104);
            this.txtNCMed.Name = "txtNCMed";
            this.txtNCMed.Size = new System.Drawing.Size(100, 20);
            this.txtNCMed.TabIndex = 1;
            // 
            // txtCompoMed
            // 
            this.txtCompoMed.Location = new System.Drawing.Point(27, 186);
            this.txtCompoMed.Name = "txtCompoMed";
            this.txtCompoMed.Size = new System.Drawing.Size(100, 20);
            this.txtCompoMed.TabIndex = 3;
            // 
            // txtEffetsMed
            // 
            this.txtEffetsMed.Location = new System.Drawing.Point(159, 186);
            this.txtEffetsMed.Name = "txtEffetsMed";
            this.txtEffetsMed.Size = new System.Drawing.Size(100, 20);
            this.txtEffetsMed.TabIndex = 4;
            // 
            // txtCIMed
            // 
            this.txtCIMed.Location = new System.Drawing.Point(290, 186);
            this.txtCIMed.Name = "txtCIMed";
            this.txtCIMed.Size = new System.Drawing.Size(100, 20);
            this.txtCIMed.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(65, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(143, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom Commercial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(302, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Id Famille";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(30, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Composition";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(183, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Effets";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(272, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Contre indications";
            // 
            // btnAjout
            // 
            this.btnAjout.BackColor = System.Drawing.Color.White;
            this.btnAjout.Location = new System.Drawing.Point(12, 221);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(394, 101);
            this.btnAjout.TabIndex = 12;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = false;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // txtIdFamMed
            // 
            this.txtIdFamMed.Location = new System.Drawing.Point(290, 104);
            this.txtIdFamMed.Name = "txtIdFamMed";
            this.txtIdFamMed.ReadOnly = true;
            this.txtIdFamMed.Size = new System.Drawing.Size(100, 20);
            this.txtIdFamMed.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(12, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "label8";
            // 
            // FormAjouterMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(418, 340);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIdFamMed);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCIMed);
            this.Controls.Add(this.txtEffetsMed);
            this.Controls.Add(this.txtCompoMed);
            this.Controls.Add(this.txtNCMed);
            this.Controls.Add(this.txtIdMed);
            this.Name = "FormAjouterMed";
            this.Text = "FormAjouterMed";
            this.Load += new System.EventHandler(this.FormAjouterMed_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdMed;
        private System.Windows.Forms.TextBox txtNCMed;
        private System.Windows.Forms.TextBox txtCompoMed;
        private System.Windows.Forms.TextBox txtEffetsMed;
        private System.Windows.Forms.TextBox txtCIMed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.TextBox txtIdFamMed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}