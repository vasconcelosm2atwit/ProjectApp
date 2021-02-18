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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            GridFill();
        }

        private void Form3_Load(object sender, EventArgs e)
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
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("view_all", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblData = new DataTable();
                sqlDa.Fill(dtblData);
                allDataGrid.DataSource = dtblData;

                mysqlCon.Close(); // closing app
            }

        }
        // ADDED THE GRIND FIND
        void GridFind(string pros, string room)
        {
            //string connectionString = @"Server=192.168.1.161;Database=projectconference;Uid=root;Pwd=SqlAdmin;convert zero datetime=True";
            string connectionString = @"Server=mydb.c6botwup9amq.us-east-2.rds.amazonaws.com;Database=projectconference;Uid=root;Pwd=password123;convert zero datetime=True";

            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                //MySqlDataAdapter sqlDa = new MySqlDataAdapter("view_all", mysqlCon);
                MySqlDataAdapter sqlDa = new MySqlDataAdapter(pros, mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_find_room", room);
                DataTable dtblData = new DataTable();
                sqlDa.Fill(dtblData);
                allDataGrid.DataSource = dtblData;

                mysqlCon.Close();
            }

        }

        private void allDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // ADDED BUTTON
        private void iconButton1_Click(object sender, EventArgs e)
        {
            // BOX NAME IS SEARCHTEXTBOX
            string roomName = searchTextBox.Text;

            GridFind("find_room",roomName);
        }
    }
}
