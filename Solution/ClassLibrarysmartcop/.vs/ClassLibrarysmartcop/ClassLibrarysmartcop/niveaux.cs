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
    public partial class niveaux : Form
    {
        public niveaux()
        {
            InitializeComponent();
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ajouterniveau ajouterniveau = new ajouterniveau();
            ajouterniveau.Show();
        }

        private void niveaux_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autocadDataSet8.ajouterniveau' table. You can move, or remove it, as needed.
            this.ajouterniveauTableAdapter.Fill(this.autocadDataSet8.ajouterniveau);

            this.Text = "Niveaux";
            this.ShowIcon = false;
            this.Icon = null;

        }

        private void annuler_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
