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
    public partial class privates : Form
    {
        public privates()
        {
            InitializeComponent();
        }

        private void privates_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autocadDataSet12.Communes' table. You can move, or remove it, as needed.
            this.communesTableAdapter.Fill(this.autocadDataSet12.Communes);
            // TODO: This line of code loads data into the 'autocadDataSet11.Contenances' table. You can move, or remove it, as needed.
            this.contenancesTableAdapter.Fill(this.autocadDataSet11.Contenances);
            // TODO: This line of code loads data into the 'autocadDataSet10.privatives' table. You can move, or remove it, as needed.
            this.privativesTableAdapter.Fill(this.autocadDataSet10.privatives);

        }
    }
}
