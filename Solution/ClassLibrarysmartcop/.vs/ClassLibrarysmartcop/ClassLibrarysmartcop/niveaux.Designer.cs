namespace ClassLibrarysmartcop
{
    partial class niveaux
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
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hauteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfaceavecsurplombDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ajouterniveauBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autocadDataSet8 = new ClassLibrarysmartcop.AutocadDataSet8();
            this.ajouterniveauTableAdapter = new ClassLibrarysmartcop.AutocadDataSet8TableAdapters.ajouterniveauTableAdapter();
            this.annuler = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajouterniveauBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autocadDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.hauteurDataGridViewTextBoxColumn,
            this.surfaceavecsurplombDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ajouterniveauBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(145, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(638, 384);
            this.dataGridView1.TabIndex = 41;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            // 
            // hauteurDataGridViewTextBoxColumn
            // 
            this.hauteurDataGridViewTextBoxColumn.DataPropertyName = "Hauteur";
            this.hauteurDataGridViewTextBoxColumn.HeaderText = "Hauteur";
            this.hauteurDataGridViewTextBoxColumn.Name = "hauteurDataGridViewTextBoxColumn";
            // 
            // surfaceavecsurplombDataGridViewTextBoxColumn
            // 
            this.surfaceavecsurplombDataGridViewTextBoxColumn.DataPropertyName = "Surface_avec_surplomb";
            this.surfaceavecsurplombDataGridViewTextBoxColumn.HeaderText = "Surface_avec_surplomb";
            this.surfaceavecsurplombDataGridViewTextBoxColumn.Name = "surfaceavecsurplombDataGridViewTextBoxColumn";
            // 
            // ajouterniveauBindingSource
            // 
            this.ajouterniveauBindingSource.DataMember = "ajouterniveau";
            this.ajouterniveauBindingSource.DataSource = this.autocadDataSet8;
            // 
            // autocadDataSet8
            // 
            this.autocadDataSet8.DataSetName = "AutocadDataSet8";
            this.autocadDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ajouterniveauTableAdapter
            // 
            this.ajouterniveauTableAdapter.ClearBeforeFill = true;
            // 
            // annuler
            // 
            this.annuler.BackColor = System.Drawing.Color.White;
            this.annuler.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.annuler.ForeColor = System.Drawing.SystemColors.ControlText;
            this.annuler.Image = global::ClassLibrarysmartcop.Properties.Resources.annuler__2_;
            this.annuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.annuler.Location = new System.Drawing.Point(392, 407);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(75, 32);
            this.annuler.TabIndex = 80;
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
            this.button7.Location = new System.Drawing.Point(287, 407);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 32);
            this.button7.TabIndex = 79;
            this.button7.Text = "Accepter";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.button5.Image = global::ClassLibrarysmartcop.Properties.Resources._58979__1_;
            this.button5.Location = new System.Drawing.Point(18, 329);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 72);
            this.button5.TabIndex = 31;
            this.button5.Text = "Vers le bas";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.button4.Image = global::ClassLibrarysmartcop.Properties.Resources.fleches_vers_le_haut__1_;
            this.button4.Location = new System.Drawing.Point(18, 251);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 72);
            this.button4.TabIndex = 30;
            this.button4.Text = "Vers le haut";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.button3.Image = global::ClassLibrarysmartcop.Properties.Resources.crayon__1_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(18, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 72);
            this.button3.TabIndex = 29;
            this.button3.Text = "Modifier";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.button2.Image = global::ClassLibrarysmartcop.Properties.Resources.supprimer__1_;
            this.button2.Location = new System.Drawing.Point(18, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 72);
            this.button2.TabIndex = 28;
            this.button2.Text = "Supprimer";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.button1.Image = global::ClassLibrarysmartcop.Properties.Resources.plus__3_1;
            this.button1.Location = new System.Drawing.Point(18, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 72);
            this.button1.TabIndex = 27;
            this.button1.Text = "Ajouter";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // niveaux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "niveaux";
            this.Text = "niveaux";
            this.Load += new System.EventHandler(this.niveaux_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajouterniveauBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autocadDataSet8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private AutocadDataSet8 autocadDataSet8;
        private System.Windows.Forms.BindingSource ajouterniveauBindingSource;
        private AutocadDataSet8TableAdapters.ajouterniveauTableAdapter ajouterniveauTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hauteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surfaceavecsurplombDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button button7;
    }
}