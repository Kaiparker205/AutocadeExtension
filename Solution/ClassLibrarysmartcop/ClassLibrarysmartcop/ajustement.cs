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
    public partial class ajustement : Form
    {
        public ajustement()
        {
            InitializeComponent();
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ajustement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autocadDataSet5.Tantiemes' table. You can move, or remove it, as needed.
            this.tantiemesTableAdapter.Fill(this.autocadDataSet5.Tantiemes);
            // TODO: This line of code loads data into the 'autocadDataSet4.calcul' table. You can move, or remove it, as needed.
            this.calculTableAdapter.Fill(this.autocadDataSet4.calcul);

        }
    }
}
