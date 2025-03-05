namespace ClassLibrarysmartcop
{
    partial class Habillage
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
            this.habillageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feuilleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habillageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autocadDataSet7 = new ClassLibrarysmartcop.AutocadDataSet7();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.habillageTableAdapter = new ClassLibrarysmartcop.AutocadDataSet7TableAdapters.HabillageTableAdapter();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habillageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autocadDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.habillageDataGridViewTextBoxColumn,
            this.feuilleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.habillageBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(493, 220);
            this.dataGridView1.TabIndex = 97;
            // 
            // habillageDataGridViewTextBoxColumn
            // 
            this.habillageDataGridViewTextBoxColumn.DataPropertyName = "Habillage";
            this.habillageDataGridViewTextBoxColumn.HeaderText = "Habillage";
            this.habillageDataGridViewTextBoxColumn.Name = "habillageDataGridViewTextBoxColumn";
            // 
            // feuilleDataGridViewTextBoxColumn
            // 
            this.feuilleDataGridViewTextBoxColumn.DataPropertyName = "Feuille";
            this.feuilleDataGridViewTextBoxColumn.HeaderText = "Feuille";
            this.feuilleDataGridViewTextBoxColumn.Name = "feuilleDataGridViewTextBoxColumn";
            // 
            // habillageBindingSource
            // 
            this.habillageBindingSource.DataMember = "Habillage";
            this.habillageBindingSource.DataSource = this.autocadDataSet7;
            // 
            // autocadDataSet7
            // 
            this.autocadDataSet7.DataSetName = "AutocadDataSet7";
            this.autocadDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(144, 155);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(267, 17);
            this.checkBox1.TabIndex = 96;
            this.checkBox1.Text = "Conserver la meme taille que l\'habillage sélectioné .";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Sous-sol",
            "Rez-de-chaussée",
            "Premiere etage",
            "Deuxiéme etage",
            "Troisiéme etage",
            "Quatrième etage",
            "Terasse"});
            this.comboBox2.Location = new System.Drawing.Point(91, 101);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(426, 21);
            this.comboBox2.TabIndex = 87;
            this.comboBox2.Text = "Selectionner niveau";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label3.Location = new System.Drawing.Point(24, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 86;
            this.label3.Text = "Niveau :";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(91, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 25);
            this.comboBox1.TabIndex = 85;
            this.comboBox1.Text = "Selectionner Fuille";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label2.Location = new System.Drawing.Point(24, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 84;
            this.label2.Text = "Feuille :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 82;
            this.label1.Text = "coordonnées de référence :";
            // 
            // habillageTableAdapter
            // 
            this.habillageTableAdapter.ClearBeforeFill = true;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.BackgroundImage = global::ClassLibrarysmartcop.Properties.Resources.plus;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button12.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(485, 28);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(32, 21);
            this.button12.TabIndex = 100;
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.White;
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button13.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Image = global::ClassLibrarysmartcop.Properties.Resources.plus__1_;
            this.button13.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button13.Location = new System.Drawing.Point(355, 60);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(68, 23);
            this.button13.TabIndex = 99;
            this.button13.Text = "Ajouter";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.White;
            this.button15.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Image = global::ClassLibrarysmartcop.Properties.Resources.supprimer;
            this.button15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button15.Location = new System.Drawing.Point(429, 60);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(88, 23);
            this.button15.TabIndex = 98;
            this.button15.Text = "Supprimer";
            this.button15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.button1.Image = global::ClassLibrarysmartcop.Properties.Resources.icons8_main_avec_stylo_48__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(27, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 28);
            this.button1.TabIndex = 94;
            this.button1.Text = "Dessiner";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::ClassLibrarysmartcop.Properties.Resources.icons8_vision_48__1_;
            this.button2.Location = new System.Drawing.Point(447, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 23);
            this.button2.TabIndex = 101;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Habillage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Habillage";
            this.Text = "Habillage";
            this.Load += new System.EventHandler(this.Habillage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habillageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autocadDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private AutocadDataSet7 autocadDataSet7;
        private System.Windows.Forms.BindingSource habillageBindingSource;
        private AutocadDataSet7TableAdapters.HabillageTableAdapter habillageTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn habillageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feuilleDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
        protected System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button2;
    }
}