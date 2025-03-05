namespace ClassLibrarysmartcop
{
    partial class Dupliquer
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.annuler = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 236);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(145, 17);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Text = "Dupliquer els annotations";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Sous-Sol",
            "Deuxiem Etage",
            "Troisiéme Etage",
            "Quatriéme Etage",
            "Rez-de-chaussée",
            "Terrasse"});
            this.checkedListBox1.Location = new System.Drawing.Point(19, 95);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(206, 124);
            this.checkedListBox1.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(453, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Dipliquer les parties privatives et communes de ce nuveau dans les niveaux :";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Premier Etage",
            "Deuxiem Etage",
            "Troisiéme Etage",
            "Quatriéme Etage",
            "Etage",
            "Sous-Sol",
            "Rez-de-chaussée",
            "Mezzanine",
            "Etage",
            "Terrasse"});
            this.comboBox1.Location = new System.Drawing.Point(169, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 25);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.Text = "Selectionner Niveau dupliquer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Niveau à dupliquer :";
            // 
            // annuler
            // 
            this.annuler.BackColor = System.Drawing.Color.White;
            this.annuler.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.annuler.ForeColor = System.Drawing.SystemColors.ControlText;
            this.annuler.Image = global::ClassLibrarysmartcop.Properties.Resources.annuler__2_;
            this.annuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.annuler.Location = new System.Drawing.Point(250, 260);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(75, 32);
            this.annuler.TabIndex = 62;
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
            this.button7.Location = new System.Drawing.Point(145, 260);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 32);
            this.button7.TabIndex = 61;
            this.button7.Text = "Accepter";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // Dupliquer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 304);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dupliquer";
            this.Text = "Dupliquer";
            this.Load += new System.EventHandler(this.Dupliquer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button button7;
    }
}