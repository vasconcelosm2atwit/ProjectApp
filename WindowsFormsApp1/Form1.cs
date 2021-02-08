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

namespace WindowsFormsApp1
{
   
    public partial class Form1 : Form
    {
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
            GridFill();

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
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

        private void btnNewConference_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
        }

        private void btnIconHome_Click(object sender, EventArgs e)
        {
            //k
            if(activeForm != null)
            {
                activeForm.Close();
            }
            GridFill();
        }
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void GridFill()
        {
           //string connectionString = @"Server=192.168.1.161;Database=projectconference;Uid=root;Pwd=SqlAdmin;convert zero datetime=True";
           string connectionString = @"Server=mydb.c6botwup9amq.us-east-2.rds.amazonaws.com;Database=projectconference;Uid=root;Pwd=password123;convert zero datetime=True";

            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                //MySqlDataAdapter sqlDa = new MySqlDataAdapter("view_all", mysqlCon);
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("sort_by_session", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblData = new DataTable();
                sqlDa.Fill(dtblData);
                allDataGrid.DataSource = dtblData;

                mysqlCon.Close();
            }
            
        }

       
    }
}
