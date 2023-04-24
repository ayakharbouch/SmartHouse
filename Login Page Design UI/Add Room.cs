using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MySqlConnector;

namespace Login_Page_Design_UI
{
    public partial class Add_Room : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost; username=root;password=;database=smarthome");
        public Add_Room()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
           ((PictureBox)sender).DoDragDrop(((PictureBox)sender).Image, DragDropEffects.Copy);   
        }

        private void guna2PictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            guna2PictureBox2.Image = getPicture;
        }

        private void guna2PictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void Add_Room_Load(object sender, EventArgs e)
        {
            guna2PictureBox2.AllowDrop = true;
            guna2PictureBox4.AllowDrop = true;
            guna2PictureBox10.AllowDrop = true;
            guna2PictureBox8.AllowDrop = true;
            guna2PictureBox11.AllowDrop = true;
            guna2PictureBox12.AllowDrop = true;
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox4_DragDrop(object sender, DragEventArgs e)
        {
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            guna2PictureBox4.Image = getPicture;
        }

        private void guna2PictureBox4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void guna2PictureBox10_DragDrop(object sender, DragEventArgs e)
        {
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            guna2PictureBox10.Image = getPicture;
        }

        private void guna2PictureBox10_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void guna2PictureBox8_DragDrop(object sender, DragEventArgs e)
        {
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            guna2PictureBox8.Image = getPicture;
        }

        private void guna2PictureBox8_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void guna2PictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox11_DragDrop(object sender, DragEventArgs e)
        {
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            guna2PictureBox11.Image = getPicture;
        }

        private void guna2PictureBox11_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void guna2PictureBox12_DragDrop(object sender, DragEventArgs e)
        {
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            guna2PictureBox12.Image = getPicture;
        }

        private void guna2PictureBox12_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Home home= new Home();
            home.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO room (room,picture) VALUES('" + guna2TextBox4.Text +"','" + guna2PictureBox2 + "')";
            conn.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, conn);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Room Ajouté Avec Succès");
                    guna2TextBox4.Clear();
                   
                }
                else
                {
                    MessageBox.Show(" Room non ajouté");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            conn.Close();
        }
    }
    }

