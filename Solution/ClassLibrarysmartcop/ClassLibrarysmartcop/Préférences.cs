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
    }
}
