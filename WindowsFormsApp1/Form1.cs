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
        Boolean activeF = false;
        //string connectionString = @"Server=192.168.1.161;Database=projectconference;Uid=root;Pwd=SqlAdmin;convert zero datetime=True";
        string connectionString = @"Server=mydb.c6botwup9amq.us-east-2.rds.amazonaws.com;Database=projectconference;Uid=root;Pwd=password123;convert zero datetime=True";
        Timer t = new Timer();
        public Form1()
        {
            InitializeComponent();
            BottomPanel.Visible = false;
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
        
            comboBox.Items.Add("Session 1");
            comboBox.Items.Add("Session 2");
            comboBox.Items.Add("Session 3");
            comboBox.Items.Add("Session 4");
            comboBox.Items.Add("Session 5");
            comboBox.Items.Add("Session 6");
            comboBox.Items.Add("Session 7");

        }
        private void t_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";
            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";
            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            //label1.Text = time;

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
            if (activeForm != null)
            {
                activeForm.Close();
            }
            label2.Text = "Sessions";
            comboBox.Text = "Sessions";
            BottomPanel.Visible = false;

            GridFill();
        }
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3()); ///asasa

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //bottomChildForm(new Form4());
            if(activeF)
                BottomPanel.Visible = true;


            lblBottomRoom.Text = allDataGrid.CurrentRow.Cells[0].Value.ToString();
            
            lblBottomSpeaker.Text = allDataGrid.CurrentRow.Cells[2].Value.ToString();
            lblBottomId.Text = allDataGrid.CurrentRow.Cells[3].Value.ToString();
            lblBottomId.Visible = false;
            label6.Visible = false;


        }

        void GridFill()
        {
            activeF = false;

            //string connectionString = @"Server=192.168.1.161;Database=projectconference;Uid=root;Pwd=SqlAdmin;convert zero datetime=True";
            //string connectionString = @"Server=mydb.c6botwup9amq.us-east-2.rds.amazonaws.com;Database=projectconference;Uid=root;Pwd=password123;convert zero datetime=True";

            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                //MySqlDataAdapter sqlDa = new MySqlDataAdapter("view_all", mysqlCon);
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("view_all", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblData = new DataTable();
                sqlDa.Fill(dtblData);
                allDataGrid.DataSource = dtblData;

                int j = dtblData.Rows.Count + 30;

                foreach(DataGridViewRow dr in allDataGrid.Rows)
                {
                    j += dr.Height;
                }

                allDataGrid.Height = j;
                mysqlCon.Close();
            }

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            GridFill2();
        
        }
        
        void GridFill2()
         {
            activeF = true;

                  string dateString = comboBox.SelectedItem.ToString();

                     label2.Text = dateString;

            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                  {
                      mysqlCon.Open();

                      MySqlDataAdapter sqlDa = new MySqlDataAdapter("sessions", mysqlCon);
                      sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                      sqlDa.SelectCommand.Parameters.AddWithValue("_session", dateString);

             
                    DataTable dtblData = new DataTable();


                      sqlDa.Fill(dtblData);
                      allDataGrid.DataSource = dtblData;
                int j = dtblData.Rows.Count + 30;

                foreach (DataGridViewRow dr in allDataGrid.Rows)
                {
                    j += dr.Height;
                }

                allDataGrid.Height = j;
                mysqlCon.Close();

                allDataGrid.Columns[3].Visible = false;

                allDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            }

              }

        private void BottomPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void bottomChildForm(Form childForm)
        {
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            BottomPanel.Controls.Add(childForm);
            BottomPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void BottonSubmit_Click(object sender, EventArgs e)
        {
            int conf_id = Int16.Parse(lblBottomId.Text.Trim());
            int beg_count = Int16.Parse(count_box.Text.Trim());


            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();

                MySqlCommand mySqlCmd = new MySqlCommand("add_count_beg", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_beg", beg_count);
                mySqlCmd.Parameters.AddWithValue("_id", conf_id);

                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Account added to id: " + conf_id);
                mysqlCon.Close();

            }
        }

        private void addDataToDatabase(string data)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                //MySqlDataAdapter sqlDa = new MySqlDataAdapter("view_all", mysqlCon);
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("sort_by_session", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblData = new DataTable();
                sqlDa.Fill(dtblData);
                allDataGrid.DataSource = dtblData;

                int j = dtblData.Rows.Count + 30;

                foreach (DataGridViewRow dr in allDataGrid.Rows)
                {
                    j += dr.Height;
                }

                allDataGrid.Height = j;
                mysqlCon.Close();
            }
        }
    }
}
