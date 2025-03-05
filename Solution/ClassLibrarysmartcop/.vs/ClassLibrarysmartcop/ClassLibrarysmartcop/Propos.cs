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
    public partial class Propos : Form
    {
        public Propos()
        {
            InitializeComponent();
        }

        private void Propos_Load(object sender, EventArgs e)
        {
            this.Text = "Propos";
            this.ShowIcon = false;
            this.Icon = null;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
