using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automotive_Resource_Management
{
    public partial class Newuser : Form
    {
        public Newuser()
        {
            InitializeComponent();
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            try
            {

                if (reg_nametb.Text.Trim() != "" && reg_mobtb.Text.Trim() != "" && reg_unametb.Text.Trim() != "" && reg_pwdtb.Text.Trim() != "" && reg_cpwdtb.Text.Trim() != "")
                {
                   

                        if (reg_pwdtb.Text.Trim().Length >= 8)
                        {
                            if (reg_pwdtb.Text.Trim() == reg_cpwdtb.Text.Trim())
                            {
                            string connString = ConfigurationManager.ConnectionStrings["AutomotiveResourceManagement"].ConnectionString;
                            SqlConnection con = new SqlConnection(connString); 
                            con.Open();
                                SqlCommand cmd = new SqlCommand("sp_newuser1", con);
                                cmd.CommandType = CommandType.StoredProcedure;

                                SqlParameter p1 = new SqlParameter("@name ", SqlDbType.VarChar);
                                cmd.Parameters.Add(p1).Value = reg_nametb.Text.Trim();

                                SqlParameter p2 = new SqlParameter("@mob", SqlDbType.VarChar);
                                cmd.Parameters.Add(p2).Value = reg_mobtb.Text.Trim();

                                SqlParameter p3 = new SqlParameter("@uname", SqlDbType.VarChar);
                                cmd.Parameters.Add(p3).Value = reg_unametb.Text.Trim();

                                SqlParameter p4 = new SqlParameter("@pwd", SqlDbType.VarChar);
                                cmd.Parameters.Add(p4).Value = reg_pwdtb.Text.Trim();

                                SqlParameter p5 = new SqlParameter("@cpwd", SqlDbType.VarChar);
                                cmd.Parameters.Add(p5).Value = reg_cpwdtb.Text.Trim();

                                int a = cmd.ExecuteNonQuery();

                                if (a > 0)
                                {
                                    MessageBox.Show("Registered Successfully");
                                Login l = new Login();  
                                l.Show();
                                this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Registration Failed");
                                    con.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Missmatching password");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password must have 8 digits");
                        }


                }
                else
                {
                    MessageBox.Show("Fill the Data's");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();  
            l.Show();
            this.Hide();
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
    }
}
