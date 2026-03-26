using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automotive_Resource_Management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            log_pwd.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if( log_uname.Text.Trim() == "" || log_pwd.Text.Trim() == "")
                {
                    MessageBox.Show("Fill all the Data's");
                }
                else if (log_uname.Text == "Admin" && log_pwd.Text == "1234")
                {
                    MessageBox.Show("Welcome Back Admin");
                    Home h  = new Home();
                    h.Show();
                    this.Hide();
                   

                }
                else
                {
                    string connString = ConfigurationManager.ConnectionStrings["AutomotiveResourceManagement"].ConnectionString;
                    SqlConnection con = new SqlConnection(connString);
                    SqlCommand cmd = new SqlCommand("sp_login", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter p1 = new SqlParameter("@uname", SqlDbType.VarChar);
                    cmd.Parameters.Add(p1).Value = log_uname.Text.Trim();

                    SqlParameter p2 = new SqlParameter("@pwd", SqlDbType.VarChar);
                    cmd.Parameters.Add(p2).Value = log_pwd.Text.Trim();

                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);


                    int a = Convert.ToInt32(DS.Tables[0].Rows.Count);
                    if (a > 0)
                    {
                        MessageBox.Show("Welcome");
                       Home vv = new Home();
                        vv.Show(); this.Hide();

                        
                    }

                    else
                    {
                        MessageBox.Show("Invalid User");

                    }
                    con.Close();


                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("are you sure want to exit", "Confiramation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Newuser nu = new Newuser();
            nu.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgetpassword fp = new Forgetpassword();
            fp.Show();
            this.Hide();
        }
    }
}
