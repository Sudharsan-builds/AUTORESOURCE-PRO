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
    public partial class Updatepassword : Form
    {
        public Updatepassword()
        {
            InitializeComponent();
        }

        private void updpwd_btn_Click(object sender, EventArgs e)
        {

            try
            {
                if (upd_newpwd.Text.Trim() == upd_cpwd.Text.Trim())
                {
                    if (upd_newpwd.Text.Trim().Length >= 8)
                    {
                        string connString = ConfigurationManager.ConnectionStrings["AutomotiveResourceManagement"].ConnectionString;
                        SqlConnection con = new SqlConnection(connString);
                        con.Open();
                        SqlCommand cmd = new SqlCommand("sp_updatepwd", con);
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter p1 = new SqlParameter("@uname", SqlDbType.VarChar);
                        cmd.Parameters.Add(p1).Value = upd_unmae.Text;

                        SqlParameter p2 = new SqlParameter("@pwd", SqlDbType.VarChar);
                        cmd.Parameters.Add(p2).Value = upd_newpwd.Text;

                        SqlParameter p3 = new SqlParameter("@cpwd ", SqlDbType.VarChar);
                        cmd.Parameters.Add(p3).Value = upd_cpwd.Text;


                        int a = (cmd.ExecuteNonQuery());

                        if (a > 0)
                        {
                            MessageBox.Show("Password Updated successfully");
                            Login login1 = new Login();
                            login1.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("!!Password Updated Failed!!");
                            con.Close();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Password must have more than 8 characters");
                    }

                }
                else
                {
                    MessageBox.Show("Missmatching password");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            upd_newpwd.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            upd_cpwd.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }
    }
}
