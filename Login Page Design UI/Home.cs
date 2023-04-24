using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Page_Design_UI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
           uc_kitchen1.BringToFront();
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uc_home1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void uc_livingroom11_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            uc_home1.BringToFront();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            uc_bedroom1.BringToFront();
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            uc_kidsroom1.BringToFront();
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            uc_livingroom11.BringToFront();
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            uc_guestroom1.BringToFront();
        }

        private void uc_home1_Load_1(object sender, EventArgs e)
        {
            Add_Room add_Room = new Add_Room();
            add_Room.Show(); 
            this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Add_Room add_Room1 = new Add_Room();
            add_Room1.Show();
            this.Hide();
        }
    }
}
