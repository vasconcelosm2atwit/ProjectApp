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

        // TRYING OUT A CHANGE
        private void btnSubmitForm_Click(object sender, EventArgs e)
        {
            using(MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {

                int roomNumber = Int16.Parse(roomNumberTxt.Text.Trim());
                int sectionNumber = Int16.Parse(sectionText.Text.Trim());
                string speakerString = speakerText.Text.Trim();

                // dateTimePicker1.Format = DateTimePickerFormat.Custom;
                //dateTimePicker1.CustomFormat = "yyyy-mm-dd";

                string dateString = dateTimePicker1.Value.Date.ToString("yyyy-mm-dd");

                mysqlCon.Open();
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
                mysqlCon.Close();
            }

        }

        private void roomNumberTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void roomNumberTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void sectionText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
