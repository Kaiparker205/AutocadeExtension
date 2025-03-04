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

        }
    }
}
