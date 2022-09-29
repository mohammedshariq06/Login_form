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

namespace login_registration
{
    public partial class regt2 : Form
    {
        public string connectionString = "Data Source=DESKTOP-GFUUSMP;Initial Catalog=db_users;Integrated Security=True";
        string g;
        public regt2()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtnmale.Checked == true)
            {
                g = "Male";
            }
            else
            {
                g = "Female";
            }
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("UserAddTwo", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@gender", g);
                sqlCmd.Parameters.AddWithValue("@qualif", txtdropquali.SelectedItem.ToString());
                sqlCmd.ExecuteNonQuery();
                new regt4().Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rbtnmale.Checked || rbtnfemale.Checked)
            {
                rbtnmale.Checked = false;
                rbtnfemale.Checked = false;
            }
            txtdropquali.Text = "";
        }
    }
}
