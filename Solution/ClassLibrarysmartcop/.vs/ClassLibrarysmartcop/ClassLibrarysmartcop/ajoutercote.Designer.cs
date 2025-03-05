namespace ClassLibrarysmartcop
{
    partial class ajoutercote
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
            this.txta = new System.Windows.Forms.TextBox();
            this.txtde = new System.Windows.Forms.TextBox();
            this.lbla = new System.Windows.Forms.Label();
            this.lblde = new System.Windows.Forms.Label();
            this.annuler = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(92, 57);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(149, 20);
            this.txta.TabIndex = 41;
            // 
            // txtde
            // 
            this.txtde.Location = new System.Drawing.Point(92, 31);
            this.txtde.Name = "txtde";
            this.txtde.Size = new System.Drawing.Size(149, 20);
            this.txtde.TabIndex = 40;
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.lbla.Location = new System.Drawing.Point(12, 55);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(65, 17);
            this.lbla.TabIndex = 39;
            this.lbla.Text = "A_la_cote ";
            // 
            // lblde
            // 
            this.lblde.AutoSize = true;
            this.lblde.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.lblde.Location = new System.Drawing.Point(12, 31);
            this.lblde.Name = "lblde";
            this.lblde.Size = new System.Drawing.Size(73, 17);
            this.lblde.TabIndex = 38;
            this.lblde.Text = "De_la_cote ";
            // 
            // annuler
            // 
            this.annuler.BackColor = System.Drawing.Color.White;
            this.annuler.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.annuler.ForeColor = System.Drawing.SystemColors.ControlText;
            this.annuler.Image = global::ClassLibrarysmartcop.Properties.Resources.annuler__2_;
            this.annuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.annuler.Location = new System.Drawing.Point(126, 94);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(75, 32);
            this.annuler.TabIndex = 58;
            this.annuler.Text = "Annuler";
            this.annuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.annuler.UseVisualStyleBackColor = false;
            this.annuler.Click += new System.EventHandler(this.annuler_Click_1);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.button7.Image = global::ClassLibrarysmartcop.Properties.Resources.coche;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(28, 94);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 32);
            this.button7.TabIndex = 57;
            this.button7.Text = "Accepter";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // ajoutercote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 132);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.txtde);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.lblde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ajoutercote";
            this.Text = "ajoutercote";
            this.Load += new System.EventHandler(this.ajoutercote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtde;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label lblde;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button button7;
    }
}