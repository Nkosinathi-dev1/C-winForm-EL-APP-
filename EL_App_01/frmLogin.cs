using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using EL_App_01.Forms;

namespace EL_App_01
{
    public partial class frmLogin : Form
    {
        public static frmLogin instance;
        public string uId = "";
        public frmLogin()
        {
            InitializeComponent();
            instance = this;
        }
        //
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-143KBPT\SQLEXPRESS;Initial Catalog=ELearning_Proj_DB;Integrated Security=True;Pooling=False");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-143KBPT\SQLEXPRESS;Initial Catalog=E - L APP DB;Integrated Security=True");
            //string query = "SELECT * FROM tbl_users WHERE username'" + txtUsername.Text.Trim() + "' AND PASSWORD = '" + txtpassword.Text.Trim()+"'";
            //SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            //DataTable dtbl = new DataTable();
            //sda.Fill(dtbl);
            //if (dtbl.Rows.Count == 1)
            //{
            //    //enter form
            //}

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string login= "SELECT * FROM tbl_users a1 JOIN student a2 on a1.Id=a2.Id WHERE username ='" + txtUsername.Text.Trim() + "' AND PASSWORD = '" + txtpassword.Text + "'";
            //string login = "SELECT * FROM tbl_users WHERE username ='" + txtUsername.Text.Trim() + "' AND PASSWORD = '" + txtpassword.Text + "'";

            cmd = new SqlCommand(login, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                FormClasses form = new FormClasses();

                uId = dr.GetValue(0).ToString();
                new dashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please try again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //txtUsername.Text = "";
                txtpassword.Text = "";
                txtUsername.Focus();
            }
            con.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtpassword.Text = "";
            txtUsername.Focus();
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
                txtpassword.PasswordChar = '*';
            }
        }
    }
}
