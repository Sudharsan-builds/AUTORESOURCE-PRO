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
    public partial class Viewvehicle : Form
    {
        public Viewvehicle()
        {
            InitializeComponent();
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

        private void display_btn_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["AutomotiveResourceManagement"].ConnectionString;
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_disvechicle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter SD = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            SD.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            con.Close();
        }
    }
}
