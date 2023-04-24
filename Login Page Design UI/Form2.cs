using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Login_Page_Design_UI
{
    public partial class Form2 : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost; username=root;password=;database=smarthome");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        
        string insertQuery = "INSERT INTO Users (username,age,email,password) VALUES('" + guna2TextBox4.Text + "','" + guna2TextBox3.Text + "','" + guna2TextBox1.Text + "' ,'" + guna2TextBox2.Text + "')";

        conn.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, conn);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Utilisateur Ajouté Avec Succès");
                    guna2TextBox4.Clear();
                    guna2TextBox3.Clear();
                    guna2TextBox1.Clear();
                    guna2TextBox2.Clear();





                }
                else
                {
                    MessageBox.Show(" utilisateur non ajouté");
                }
            
            }
            catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}


conn.Close();
    }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

