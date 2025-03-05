namespace ClassLibrarysmartcop
{
    partial class ajouterniveau
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.delacoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alacoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hauteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ajoutercoteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.autocadDataSet3 = new ClassLibrarysmartcop.AutocadDataSet3();
            this.txtsurface = new System.Windows.Forms.TextBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txttype = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ajoutercoteTableAdapter = new ClassLibrarysmartcop.AutocadDataSet3TableAdapters.ajoutercoteTableAdapter();
            this.annuler = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.ajouterniveauBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ajoutercoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajoutercoteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autocadDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajouterniveauBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajoutercoteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.button15);
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(38, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 211);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "les cotes";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.White;
            this.button14.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Image = global::ClassLibrarysmartcop.Properties.Resources.crayon;
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(188, 19);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(83, 23);
            this.button14.TabIndex = 69;
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
            this.button15.Location = new System.Drawing.Point(94, 19);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(88, 23);
            this.button15.TabIndex = 68;
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
            this.button13.Location = new System.Drawing.Point(11, 21);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(68, 23);
            this.button13.TabIndex = 67;
            this.button13.Text = "Ajouter";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delacoteDataGridViewTextBoxColumn,
            this.alacoteDataGridViewTextBoxColumn,
            this.hauteurDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ajoutercoteBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(10, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(324, 150);
            this.dataGridView1.TabIndex = 54;
            // 
            // delacoteDataGridViewTextBoxColumn
            // 
            this.delacoteDataGridViewTextBoxColumn.DataPropertyName = "de_la_cote";
            this.delacoteDataGridViewTextBoxColumn.HeaderText = "de_la_cote";
            this.delacoteDataGridViewTextBoxColumn.Name = "delacoteDataGridViewTextBoxColumn";
            // 
            // alacoteDataGridViewTextBoxColumn
            // 
            this.alacoteDataGridViewTextBoxColumn.DataPropertyName = "a_la_cote";
            this.alacoteDataGridViewTextBoxColumn.HeaderText = "a_la_cote";
            this.alacoteDataGridViewTextBoxColumn.Name = "alacoteDataGridViewTextBoxColumn";
            // 
            // hauteurDataGridViewTextBoxColumn
            // 
            this.hauteurDataGridViewTextBoxColumn.DataPropertyName = "Hauteur";
            this.hauteurDataGridViewTextBoxColumn.HeaderText = "Hauteur";
            this.hauteurDataGridViewTextBoxColumn.Name = "hauteurDataGridViewTextBoxColumn";
            // 
            // ajoutercoteBindingSource1
            // 
            this.ajoutercoteBindingSource1.DataMember = "ajoutercote";
            this.ajoutercoteBindingSource1.DataSource = this.autocadDataSet3;
            // 
            // autocadDataSet3
            // 
            this.autocadDataSet3.DataSetName = "AutocadDataSet3";
            this.autocadDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtsurface
            // 
            this.txtsurface.Location = new System.Drawing.Point(188, 105);
            this.txtsurface.Name = "txtsurface";
            this.txtsurface.Size = new System.Drawing.Size(145, 20);
            this.txtsurface.TabIndex = 54;
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(188, 79);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(190, 20);
            this.txtnum.TabIndex = 53;
            // 
            // txttype
            // 
            this.txttype.Location = new System.Drawing.Point(188, 52);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(190, 20);
            this.txttype.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label3.Location = new System.Drawing.Point(38, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Surface avec surplomb :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label2.Location = new System.Drawing.Point(38, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "Numéro :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label1.Location = new System.Drawing.Point(38, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "Type :";
            // 
            // ajoutercoteTableAdapter
            // 
            this.ajoutercoteTableAdapter.ClearBeforeFill = true;
            // 
            // annuler
            // 
            this.annuler.BackColor = System.Drawing.Color.White;
            this.annuler.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.annuler.ForeColor = System.Drawing.SystemColors.ControlText;
            this.annuler.Image = global::ClassLibrarysmartcop.Properties.Resources.annuler__2_;
            this.annuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.annuler.Location = new System.Drawing.Point(222, 357);
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
            this.button7.Location = new System.Drawing.Point(117, 357);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 32);
            this.button7.TabIndex = 57;
            this.button7.Text = "Accepter";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // ajouterniveauBindingSource
            // 
            this.ajouterniveauBindingSource.DataMember = "ajouterniveau";
            // 
            // ajoutercoteBindingSource
            // 
            this.ajoutercoteBindingSource.DataMember = "ajoutercote";
            // 
            // ajouterniveau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 415);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtsurface);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.txttype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ajouterniveau";
            this.Text = "ajouterniveau";
            this.Load += new System.EventHandler(this.ajouterniveau_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajoutercoteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autocadDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajouterniveauBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajoutercoteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource ajouterniveauBindingSource;
        private System.Windows.Forms.BindingSource ajoutercoteBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtsurface;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private AutocadDataSet3 autocadDataSet3;
        private System.Windows.Forms.BindingSource ajoutercoteBindingSource1;
        private AutocadDataSet3TableAdapters.ajoutercoteTableAdapter ajoutercoteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn delacoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alacoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hauteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button14;
        protected System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button13;
    }
}