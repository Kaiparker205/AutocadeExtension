using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrarysmartcop
{
    public partial class Fichiers_DWG : Form
    {
        public Fichiers_DWG()
        {
            InitializeComponent();
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fichiers_DWG_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autocadDataSet6.DWG' table. You can move, or remove it, as needed.
            this.dWGTableAdapter.Fill(this.autocadDataSet6.DWG);

            this.Text = "Fichiers DWG";
            this.ShowIcon = false;
            this.Icon = null;
        }

        private void annuler_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVershaut_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int currentIndex = dataGridView2.SelectedRows[0].Index;

                if (currentIndex > 0) // Vérifier qu'on ne dépasse pas la première ligne
                {
                    for (int col = 0; col < dataGridView2.ColumnCount; col++)
                    {
                        //  Ignorer les colonnes en lecture seule
                        if (!dataGridView2.Columns[col].ReadOnly) 
                        {
                            object temp = dataGridView2[col, currentIndex].Value;
                            dataGridView2[col, currentIndex].Value = dataGridView2[col, currentIndex - 1].Value;
                            dataGridView2[col, currentIndex - 1].Value = temp;
                        }
                    }

                    // Sélectionner la ligne déplacée
                    dataGridView2.ClearSelection();
                    dataGridView2.Rows[currentIndex - 1].Selected = true;
                }
            }
        }

        private void btnVersbas(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int currentIndex = dataGridView2.SelectedRows[0].Index;

                if (currentIndex < dataGridView2.Rows.Count - 1) // Vérifier qu'on ne dépasse pas la dernière ligne
                {
                    for (int col = 0; col < dataGridView2.ColumnCount; col++)
                    {
                        if (!dataGridView2.Columns[col].ReadOnly) // ✅ Ignorer les colonnes en lecture seule
                        {
                            object temp = dataGridView2[col, currentIndex].Value;
                            dataGridView2[col, currentIndex].Value = dataGridView2[col, currentIndex + 1].Value;
                            dataGridView2[col, currentIndex + 1].Value = temp;
                        }
                    }

                    // Sélectionner la ligne déplacée
                    dataGridView2.ClearSelection();
                    dataGridView2.Rows[currentIndex + 1].Selected = true;
                }
            }
        
        }
    }
}
