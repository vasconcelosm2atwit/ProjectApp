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
    public partial class RoomPage : Form
    {
        //string connectionString = @"Server=192.168.1.161;Database=projectconference;Uid=root;Pwd=SqlAdmin;";
        string connectionString = @"Server=mydb.c6botwup9amq.us-east-2.rds.amazonaws.com;Database=projectconference;Uid=root;Pwd=password123;convert zero datetime=True";
        public RoomPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // TRYING OUT A CHANGE
        private void btnSubmitForm_Click(object sender, EventArgs e)
        {
           

        }

        private void roomNumberTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void roomNumberTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void sectionText_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                string roomName = roomNumberTxt.Text.Trim();
                int capacityNumber = 0;
                if(sectionText.Text.Length != 0)
                {
                    capacityNumber = Int16.Parse(sectionText.Text.Trim());
                }

                mysqlCon.Open();
                MySqlCommand mySqlCmdNewRoom = new MySqlCommand("add_new_room", mysqlCon);

                mySqlCmdNewRoom.CommandType = CommandType.StoredProcedure;
                mySqlCmdNewRoom.Parameters.AddWithValue("_room", roomName);
                mySqlCmdNewRoom.Parameters.AddWithValue("_capacity", capacityNumber);

                mySqlCmdNewRoom.ExecuteNonQuery();
                MessageBox.Show("Submitted Sucessfully");
                mysqlCon.Close();
            }
        }
    }
}
