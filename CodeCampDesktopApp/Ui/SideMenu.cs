using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CodeCampApp
{

    public partial class SideMenu : Form
    {
        private Form activeForm;
        Boolean activeF = false;
        //string connectionString = @"Server=192.168.1.161;Database=projectconference;Uid=root;Pwd=SqlAdmin;convert zero datetime=True";
        string connectionString = @"Server=mydb.c6botwup9amq.us-east-2.rds.amazonaws.com;Database=projectconference;Uid=root;Pwd=password123;convert zero datetime=True";
        Timer t = new Timer();
        public SideMenu()
        {
            InitializeComponent();
            //BottomPanel.Visible = false;
            openChildForm(new HomePage());


        }


        private void Form1_Load(object sender, EventArgs e)
        {
       

        }


        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Session());
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            //label2.Text = "Sessions";
            // comboBox.Text = "Sessions";
            //  BottomPanel.Visible = false;
            openChildForm(new HomePage());

        }

        private void RoomBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new RoomPage());
        }

        private void SpeakerBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new SpeakerPage());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new TimeSlotPage());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
