using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using MySqlConnector;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Login_Page_Design_UI
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost; username=root;password=;database=smarthome");
        public Form1()
        {
            InitializeComponent();

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select * from Users where username = '" + guna2TextBox1.Text + "' AND password = '" + guna2TextBox2.Text + "'", conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                   
                    this.Hide();
                    Dashboard p = new Dashboard();
                    p.Show();
                }
                else
                {
                    MessageBox.Show("username or password incorrect. please try again !", "Oups !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            reader.Close();
            cmd.Dispose();
            conn.Close();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
