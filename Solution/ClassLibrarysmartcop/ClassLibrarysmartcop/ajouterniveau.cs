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
    public partial class ajouterniveau : Form
    {
        public ajouterniveau()
        {
            InitializeComponent();
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ajouterniveau_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autocadDataSet3.ajoutercote' table. You can move, or remove it, as needed.
            this.ajoutercoteTableAdapter.Fill(this.autocadDataSet3.ajoutercote);

        }
    }
}
