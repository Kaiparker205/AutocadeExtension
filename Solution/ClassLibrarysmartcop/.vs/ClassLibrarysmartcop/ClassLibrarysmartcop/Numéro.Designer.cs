namespace ClassLibrarysmartcop
{
    partial class Numéro
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.annuler = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Numéro :";
            // 
            // annuler
            // 
            this.annuler.BackColor = System.Drawing.Color.White;
            this.annuler.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.annuler.ForeColor = System.Drawing.SystemColors.ControlText;
            this.annuler.Image = global::ClassLibrarysmartcop.Properties.Resources.annuler__2_;
            this.annuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.annuler.Location = new System.Drawing.Point(178, 65);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(75, 32);
            this.annuler.TabIndex = 82;
            this.annuler.Text = "Annuler";
            this.annuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.annuler.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.button7.Image = global::ClassLibrarysmartcop.Properties.Resources.coche;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(73, 65);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 32);
            this.button7.TabIndex = 81;
            this.button7.Text = "Accepter";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // Numéro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 109);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Numéro";
            this.Text = "Numéro";
            this.Load += new System.EventHandler(this.Numéro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button button7;
    }
}