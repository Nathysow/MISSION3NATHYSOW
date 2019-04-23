namespace gsbRapports2019
{
    partial class FormGererCreerFam
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
            this.txtIdFam = new System.Windows.Forms.TextBox();
            this.txtLibelFam = new System.Windows.Forms.TextBox();
            this.btnCreer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIdFam
            // 
            this.txtIdFam.Location = new System.Drawing.Point(31, 78);
            this.txtIdFam.Name = "txtIdFam";
            this.txtIdFam.Size = new System.Drawing.Size(100, 20);
            this.txtIdFam.TabIndex = 0;
            // 
            // txtLibelFam
            // 
            this.txtLibelFam.Location = new System.Drawing.Point(171, 78);
            this.txtLibelFam.Name = "txtLibelFam";
            this.txtLibelFam.Size = new System.Drawing.Size(100, 20);
            this.txtLibelFam.TabIndex = 1;
            // 
            // btnCreer
            // 
            this.btnCreer.BackColor = System.Drawing.Color.White;
            this.btnCreer.Location = new System.Drawing.Point(31, 104);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(240, 69);
            this.btnCreer.TabIndex = 2;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = false;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(70, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(197, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Libelle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(54, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Création d\'une famille";
            // 
            // FormGererCreerFam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(313, 183);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.txtLibelFam);
            this.Controls.Add(this.txtIdFam);
            this.Name = "FormGererCreerFam";
            this.Text = "FormGererCreerFam";
            this.Load += new System.EventHandler(this.FormGererCreerFam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdFam;
        private System.Windows.Forms.TextBox txtLibelFam;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}