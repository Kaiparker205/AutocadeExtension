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
    public partial class Ajouter_partie_privative : Form
    {
        public Ajouter_partie_privative()
        {
            InitializeComponent();
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ajouter_partie_privative_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autocadDataSet2.Observation' table. You can move, or remove it, as needed.
            this.observationTableAdapter.Fill(this.autocadDataSet2.Observation);
            // TODO: This line of code loads data into the 'autocadDataSet1.p_surplomb' table. You can move, or remove it, as needed.
            this.p_surplombTableAdapter.Fill(this.autocadDataSet1.p_surplomb);
            // TODO: This line of code loads data into the 'autocadDataSet.Polylines' table. You can move, or remove it, as needed.
            this.polylinesTableAdapter.Fill(this.autocadDataSet.Polylines);

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
