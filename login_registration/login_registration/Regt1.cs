using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace login_registration
{
    public partial class Regt1 : Form
    {
        public string connectionString = "Data Source=DESKTOP-GFUUSMP;Initial Catalog=db_users;Integrated Security=True";
        public Regt1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex r = new Regex("^[0-9]{10}$");
            Regex n = new Regex("^[A-Za-z]*$");
            if (txtName.Text == "" || txtmobileno.Text == "" || txtemail.Text == "")
                MessageBox.Show("Please fill mandatory fields", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (r.IsMatch(txtmobileno.Text))
            {
                // if (n.IsMatch(txtName.Text))
                //{
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAddOne", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@mobile_no", txtmobileno.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@email", txtemail.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    new regt2().Show();
                    this.Hide();
                }
                //}
                //else
                //{
                //  MessageBox.Show("Enter a valid Name");
                //}
            }
            else
            {
                MessageBox.Show("Invalid Mobile Number");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Text = txtmobileno.Text = txtemail.Text = "";
        }
    }
}
