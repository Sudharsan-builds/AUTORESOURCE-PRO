using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automotive_Resource_Management
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            DialogResult check = MessageBox.Show("are you sure want to exit", "Confiramation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Addvechicle av = new Addvechicle();
            av.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Viewvehicle vv = new Viewvehicle(); 
            vv.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employees ee  = new Employees();
            ee.Show();
            this.Hide();    
        }
    }
}
