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
    public partial class Calques : Form
    {
        public Calques()
        {
            InitializeComponent();
        }

        private void cliques_Load(object sender, EventArgs e)
        {
            this.Text = "Calques";
            this.ShowIcon = false;
            this.Icon = null;
        }
    }
}
