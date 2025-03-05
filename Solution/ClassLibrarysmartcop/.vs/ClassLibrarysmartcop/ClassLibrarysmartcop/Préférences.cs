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
    public partial class Préférences : Form
    {
        public Préférences()
        {
            InitializeComponent();
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            DialogResult result = folder.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtparcourir.Text = folder.SelectedPath;
            }
        }

        private void Préférences_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autocadDataSet15.Niveau' table. You can move, or remove it, as needed.
            this.niveauTableAdapter.Fill(this.autocadDataSet15.Niveau);
            // TODO: This line of code loads data into the 'autocadDataSet9.Personnels' table. You can move, or remove it, as needed.
            this.personnelsTableAdapter.Fill(this.autocadDataSet9.Personnels);

            this.Text = "Préférences";
            this.ShowIcon = false;
            this.Icon = null;

        }

        private void annuler_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}
