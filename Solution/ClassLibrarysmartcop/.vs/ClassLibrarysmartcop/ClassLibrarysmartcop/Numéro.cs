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
    public partial class Numéro : Form
    {
        public Numéro()
        {
            InitializeComponent();
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Ajouter_partie_privative ajouter_Partie_Privative = new Ajouter_partie_privative();
            ajouter_Partie_Privative.Show();
        }

        private void Numéro_Load(object sender, EventArgs e)
        {
            this.Text = "Numéro";
            this.ShowIcon = false;
            this.Icon = null;
        }
    }
}
