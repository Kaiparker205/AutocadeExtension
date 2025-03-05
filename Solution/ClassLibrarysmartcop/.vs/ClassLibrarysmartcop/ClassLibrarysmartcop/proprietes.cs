using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrarysmartcop
{
    public partial class proprietes : Form
    {
        public proprietes()
        {
            InitializeComponent();
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void proprietes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autocadDataSet14.proprietaires' table. You can move, or remove it, as needed.
            this.proprietairesTableAdapter.Fill(this.autocadDataSet14.proprietaires);
            // TODO: This line of code loads data into the 'autocadDataSet13.Riverains' table. You can move, or remove it, as needed.
            this.riverainsTableAdapter.Fill(this.autocadDataSet13.Riverains);

            this.Text = "Propriétés";
            this.ShowIcon = false;
            this.Icon = null;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            ajouterproprietaires ajouterproprietaires = new ajouterproprietaires();
            ajouterproprietaires.Show();
        }

        private void bntsupprimer_Click(object sender, EventArgs e)
        {
            
        }

      

        private void annuler_Click_2(object sender, EventArgs e)
        {
          this.Close();
        }
    }
}
