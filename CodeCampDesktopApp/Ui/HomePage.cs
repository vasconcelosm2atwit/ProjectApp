using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CodeCampApp
{
    public partial class HomePage : Form
    {
        string connectionString = @"Server=mydb.c6botwup9amq.us-east-2.rds.amazonaws.com;Database=projectconference;Uid=root;Pwd=password123;convert zero datetime=True";
        public HomePage()
        {
            InitializeComponent();
            
            GridFill();
        }

        void GridFill()
        {

            //string connectionString = @"Server=192.168.1.161;Database=projectconference;Uid=root;Pwd=SqlAdmin;convert zero datetime=True";
            //string connectionString = @"Server=mydb.c6botwup9amq.us-east-2.rds.amazonaws.com;Database=projectconference;Uid=root;Pwd=password123;convert zero datetime=True";

            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                //MySqlDataAdapter sqlDa = new MySqlDataAdapter("view_all", mysqlCon);
                /* MySqlDataAdapter sqlDa = new MySqlDataAdapter("testProcedure_show_all_rooms", mysqlCon);
                 sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                 DataTable dtblData = new DataTable();
                 sqlDa.Fill(dtblData);

                 Debug.WriteLine(sqlDa);
                  */
                mysqlCon.Close();
            }

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        private void allRoomsTestLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
