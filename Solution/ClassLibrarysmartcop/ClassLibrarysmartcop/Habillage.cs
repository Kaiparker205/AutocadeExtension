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
    public partial class Habillage : Form
    {
        public Habillage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Habillage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autocadDataSet7.Habillage' table. You can move, or remove it, as needed.
            this.habillageTableAdapter.Fill(this.autocadDataSet7.Habillage);

        }
    }
}
