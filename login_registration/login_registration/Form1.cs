using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace login_registration
{
    public partial class Form1 : Form
    {
        public string connectionString = "Data Source=DESKTOP-GFUUSMP;Initial Catalog=db_users;Integrated Security=True";
        string g;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if(checkbxShowPas.Checked)
            {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '•';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex r = new Regex("^[0-9]{10}$");
            Regex n = new Regex("^[A-Za-z]*$");
            if(rbtnmale.Checked==true)
            {
                g = "Male";
            }
            else
            {
                g = "Female";
            }
            if (txtUsername.Text == "" || txtpassword.Text == "" || txtName.Text == "" || txtmobileno.Text == "" || txtemail.Text == "")
                MessageBox.Show("Please fill mandatory fields", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (r.IsMatch(txtmobileno.Text))
            {
                // if (n.IsMatch(txtName.Text))
                //{
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@password", txtpassword.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@mobile_no", txtmobileno.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@email", txtemail.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@gender", g);
                        sqlCmd.Parameters.AddWithValue("@qualif", txtdropquali.SelectedItem.ToString());
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Registration is Success");
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
            if (rbtnmale.Checked || rbtnfemale.Checked)
            {
                rbtnmale.Checked = false;
                rbtnfemale.Checked = false;
            }
            txtUsername.Text = txtpassword.Text = txtName.Text = txtmobileno.Text = txtemail.Text = txtdropquali.Text = "";
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void rbtnmale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
