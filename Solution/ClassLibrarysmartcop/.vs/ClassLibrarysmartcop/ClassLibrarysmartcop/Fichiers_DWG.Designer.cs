namespace ClassLibrarysmartcop
{
    partial class Fichiers_DWG
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fichierDWGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dWGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autocadDataSet6 = new ClassLibrarysmartcop.AutocadDataSet6();
            this.dWGTableAdapter = new ClassLibrarysmartcop.AutocadDataSet6TableAdapters.DWGTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dWGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autocadDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.fichierDWGDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.dWGBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(21, 51);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(566, 314);
            this.dataGridView2.TabIndex = 68;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fichierDWGDataGridViewTextBoxColumn
            // 
            this.fichierDWGDataGridViewTextBoxColumn.DataPropertyName = "FichierDWG";
            this.fichierDWGDataGridViewTextBoxColumn.HeaderText = "FichierDWG";
            this.fichierDWGDataGridViewTextBoxColumn.Name = "fichierDWGDataGridViewTextBoxColumn";
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
            // dWGBindingSource
            // 
            this.dWGBindingSource.DataMember = "DWG";
            this.dWGBindingSource.DataSource = this.autocadDataSet6;
            // 
            // autocadDataSet6
            // 
            this.autocadDataSet6.DataSetName = "AutocadDataSet6";
            this.autocadDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dWGTableAdapter
            // 
            this.dWGTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::ClassLibrarysmartcop.Properties.Resources.plus__1_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.Location = new System.Drawing.Point(99, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 23);
            this.button3.TabIndex = 82;
            this.button3.Text = "Ajouter surface";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.White;
            this.button14.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Image = global::ClassLibrarysmartcop.Properties.Resources.crayon;
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(307, 22);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(83, 23);
            this.button14.TabIndex = 81;
            this.button14.Text = "Modifies";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.White;
            this.button15.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Image = global::ClassLibrarysmartcop.Properties.Resources.supprimer;
            this.button15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button15.Location = new System.Drawing.Point(213, 22);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(88, 23);
            this.button15.TabIndex = 80;
            this.button15.Text = "Supprimer";
            this.button15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.White;
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button13.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Image = global::ClassLibrarysmartcop.Properties.Resources.plus__1_;
            this.button13.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button13.Location = new System.Drawing.Point(25, 24);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(68, 23);
            this.button13.TabIndex = 79;
            this.button13.Text = "Ajouter";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button13.UseVisualStyleBackColor = false;
            // 
            // annuler
            // 
            this.annuler.BackColor = System.Drawing.Color.White;
            this.annuler.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.annuler.ForeColor = System.Drawing.SystemColors.ControlText;
            this.annuler.Image = global::ClassLibrarysmartcop.Properties.Resources.annuler__2_;
            this.annuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.annuler.Location = new System.Drawing.Point(307, 386);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(75, 32);
            this.annuler.TabIndex = 78;
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
            this.button7.Location = new System.Drawing.Point(202, 386);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 32);
            this.button7.TabIndex = 77;
            this.button7.Text = "Accepter";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::ClassLibrarysmartcop.Properties.Resources._58979;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(497, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 72;
            this.button2.Text = "Vers le bas";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnVersbas);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::ClassLibrarysmartcop.Properties.Resources.fleches_vers_le_haut;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(396, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 71;
            this.button1.Text = "Vers le haut";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnVershaut_Click);
            // 
            // Fichiers_DWG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fichiers_DWG";
            this.Text = "Fichiers_DWG";
            this.Load += new System.EventHandler(this.Fichiers_DWG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dWGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autocadDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private AutocadDataSet6 autocadDataSet6;
        private System.Windows.Forms.BindingSource dWGBindingSource;
        private AutocadDataSet6TableAdapters.DWGTableAdapter dWGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fichierDWGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button14;
        protected System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button3;
    }
}