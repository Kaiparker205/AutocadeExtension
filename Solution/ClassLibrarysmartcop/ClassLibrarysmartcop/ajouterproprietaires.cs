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
    public partial class ajouterproprietaires : Form
    {
        public ajouterproprietaires()
        {
            InitializeComponent();
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
           string connectionString = "Data Source=DESKTOP-08LSVC0\\SQLEXPRESS;Initial Catalog=Autocad;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO Clients (Nom, CIN, Adresse, Representant) VALUES (@Nom, @CIN, @Adresse, @Representant)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nom", txtNom.Text);
                    cmd.Parameters.AddWithValue("@CIN", txtCIN.Text);
                    cmd.Parameters.AddWithValue("@Adresse", txtAdresse.Text);
                    cmd.Parameters.AddWithValue("@Representant", txtRepresentant.Text);

                    cmd.ExecuteNonQuery();                                                                                                                                                                                                                                    
                }
            }

            MessageBox.Show("Client ajouté avec succès !");
        }
    }
}
