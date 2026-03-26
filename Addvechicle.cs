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
    public partial class Addvechicle : Form
    {
        public Addvechicle()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("are you sure want to exit", "Confiramation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Home h = new Home();    
                h.Show();
                this.Hide();
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

        private void reg_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["AutomotiveResourceManagement"].ConnectionString;
                SqlConnection con = new SqlConnection(connString);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_addvechile", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@vname", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = advname_tbl.Text.Trim();

                SqlParameter p2 = new SqlParameter("@vnum", SqlDbType.VarChar);
                cmd.Parameters.Add(p2).Value = advnum_tbl.Text.Trim();

                SqlParameter p3 = new SqlParameter("@vbrand", SqlDbType.VarChar);
                cmd.Parameters.Add(p3).Value = advbrand_tbl.Text.Trim(); 


                SqlParameter p4 = new SqlParameter("@vmodel", SqlDbType.VarChar);
                cmd.Parameters.Add(p4).Value = advmodel_tbl.Text.Trim();
                int a = (cmd.ExecuteNonQuery());

                if (a > 0)
                {
                    MessageBox.Show("Employee Details Added");
                    Viewvehicle vv = new Viewvehicle();
                    vv.Show();
                    this.Hide();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("!!Failed!!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            advname_tbl.Clear();
            advnum_tbl.Clear();
            advbrand_tbl.Clear();
            advmodel_tbl.Clear();
        }
    }
}
