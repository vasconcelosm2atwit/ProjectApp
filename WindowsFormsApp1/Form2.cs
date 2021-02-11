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
    public partial class Form2 : Form
    {
        //string connectionString = @"Server=192.168.1.161;Database=projectconference;Uid=root;Pwd=SqlAdmin;";
        string connectionString = @"Server=mydb.c6botwup9amq.us-east-2.rds.amazonaws.com;Database=projectconference;Uid=root;Pwd=password123;convert zero datetime=True";
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmitForm_Click(object sender, EventArgs e)
        {
            using(MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {

                string roomNumber = roomNumberTxt.Text.Trim();
                string sectionNumber = sectionText.Text.Trim();
                string speakerString = speakerText.Text.Trim();

                // dateTimePicker1.Format = DateTimePickerFormat.Custom;
                //dateTimePicker1.CustomFormat = "yyyy-mm-dd";

                string dateString = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");

                //changing this
                /*mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("new_conference",mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_room", roomNumber);
                mySqlCmd.Parameters.AddWithValue("_section", sectionNumber);
                mySqlCmd.Parameters.AddWithValue("_speaker", speakerString);
                mySqlCmd.Parameters.AddWithValue("_date", dateString);
                Console.WriteLine(dateString);
                // mySqlCmd.Parameters.Add("_date", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Sucessfully");
                mysqlCon.Close();*/

                /*mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("new_conference",mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_room", roomNumber);
                mySqlCmd.Parameters.AddWithValue("_section", sectionNumber);
                mySqlCmd.Parameters.AddWithValue("_speaker", speakerString);
                mySqlCmd.Parameters.AddWithValue("_date", dateString);
                Console.WriteLine(dateString);
                // mySqlCmd.Parameters.Add("_date", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Sucessfully");
                mysqlCon.Close();*/
                int newRoom = 8;
                int newSession = 7;

                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("new_conference1",mysqlCon);
                MySqlCommand mySqlCmdNewRooom = new MySqlCommand("add_new_room", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_date", dateString);

                roomNumber.ToLower();
                switch(roomNumber)
                {
                    case "adams":
                        mySqlCmd.Parameters.AddWithValue("_room", 1);
                        break;
                    case "washington":
                        mySqlCmd.Parameters.AddWithValue("_room", 2);
                        break;
                    case "jefferson":
                        mySqlCmd.Parameters.AddWithValue("_room", 3);
                        break;
                    case "monroe":
                        mySqlCmd.Parameters.AddWithValue("_room", 4);
                        break;
                    case "breton":
                    case "brentton woods":
                        mySqlCmd.Parameters.AddWithValue("_room", 5);
                        break;
                    case "cranmore":
                        mySqlCmd.Parameters.AddWithValue("_room", 6);
                        break;
                    case "jay":
                    case "jay peak":
                        mySqlCmd.Parameters.AddWithValue("_room", 7);
                        break;
                    case "cannon":
                        mySqlCmd.Parameters.AddWithValue("_room", 8);
                        break;
                    default:
                        mySqlCmd.Parameters.AddWithValue("_room",newRoom++);
                        break;
                }
                
                /*if (speakerString == "test")
                {

                    mySqlCmd.Parameters.AddWithValue("_speaker", 1);
                }*/

                switch(sectionNumber)
                {
                    case "09:00":
                        mySqlCmd.Parameters.AddWithValue("_session", 1);
                        break;
                    case "10:15":
                        mySqlCmd.Parameters.AddWithValue("_session", 2);
                        break;
                    case "11:30":
                        mySqlCmd.Parameters.AddWithValue("_session", 3);
                        break;
                    case "1:00":
                        mySqlCmd.Parameters.AddWithValue("_session", 4);
                        break;
                    case "1:45":
                        mySqlCmd.Parameters.AddWithValue("_session", 5);
                        break;
                    case "3:00":
                        mySqlCmd.Parameters.AddWithValue("_session", 6);
                        break;
                    case "4:15":
                        mySqlCmd.Parameters.AddWithValue("_session", 7);
                        break;
                    default:
                        mySqlCmd.Parameters.AddWithValue("_session", newSession++);
                        break;
                }
                
           
                
                Console.WriteLine(dateString);
                // mySqlCmd.Parameters.Add("_date", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Sucessfully");
                mysqlCon.Close();
}

}

private void roomNumberTxt_TextChanged(object sender, EventArgs e)
{

}

private void roomNumberTxt_KeyPress(object sender, KeyPressEventArgs e)
{
/*f (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
{
e.Handled = true;
}

// If you want, you can allow decimal (float) numbers
if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
{
e.Handled = true;
} */
}

private void sectionText_KeyPress(object sender, KeyPressEventArgs e)
{
/* (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
{
e.Handled = true;
}

// If you want, you can allow decimal (float) numbers
if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
{
e.Handled = true;
}*/
}
}
}
