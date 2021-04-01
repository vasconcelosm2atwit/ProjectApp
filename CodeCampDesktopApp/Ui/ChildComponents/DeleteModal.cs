using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeCampApp.Ui.ChildComponents
{
    public partial class DeleteModal : Form
    {
        private DataGridView _datagrid;
        private DataGridViewCellEventArgs _e;
        public DeleteModal(DataGridView datagrid, DataGridViewCellEventArgs e)
        {
            _datagrid = datagrid;
            _e = e;
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=mydb.c6botwup9amq.us-east-2.rds.amazonaws.com;Database=projectconference;Uid=root;Pwd=password123;convert zero datetime=True";
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                var stm = "delete from time_slots where time_slots_id = @timeslotid";
                var cmd = new MySqlCommand(stm, mysqlCon);
                cmd.Parameters.AddWithValue("timeslotid", Int32.Parse(_datagrid[0, _e.RowIndex].Value.ToString()));
                cmd.ExecuteNonQuery();
                mysqlCon.Close();
            }
            _datagrid.Rows.RemoveAt(_e.RowIndex);
            this.Dispose();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
