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

namespace login_registration
{
    public partial class frmLogin : Form
    {
        public string connectionString = "Data Source=DESKTOP-GFUUSMP;Initial Catalog=db_users;Integrated Security=True";
        public frmLogin()
        {
            InitializeComponent();
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
            new Regt1().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string login = "SELECT * FROM tbl_userpass WHERE username= '" + txtUsername.Text + "' and password= '" + txtpassword.Text + "'";
                SqlCommand sqlCmd = new SqlCommand(login, sqlCon);
                SqlDataReader dr = sqlCmd.ExecuteReader();

                if (dr.Read() == true)
                {
                    new dashboard().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username / Password is invalid");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = txtpassword.Text = "";
        }
    }
}