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
    public partial class generate : Form
    {
        public generate()
        {
            InitializeComponent();
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void generate_Load(object sender, EventArgs e)
        {
            this.Text = "Generate";
            this.ShowIcon = false;
            this.Icon = null;
        }

        private void annuler_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
