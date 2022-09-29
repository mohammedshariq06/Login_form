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
    public partial class regt4 : Form
    {
        public string connectionString = "Data Source=DESKTOP-GFUUSMP;Initial Catalog=db_users;Integrated Security=True";
        public regt4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '•';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtpassword.Text == "")
                MessageBox.Show("Please fill mandatory fields", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAddThree", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@password", txtpassword.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Registration is Success");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = txtpassword.Text = "";
        }
    }
}
