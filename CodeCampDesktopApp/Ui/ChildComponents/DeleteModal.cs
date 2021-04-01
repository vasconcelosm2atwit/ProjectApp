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
        private string _tablename;
        private string _idname;
        public DeleteModal(DataGridView datagrid, DataGridViewCellEventArgs e, string table_name, string id_name)
        {
            _datagrid = datagrid;
            _e = e;
            InitializeComponent();
            _tablename = table_name;
            _idname = id_name;
           
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
                var stm = string.Format("delete from {0} where {1} = @{2}", _tablename, _idname, _idname);
                var cmd = new MySqlCommand(stm, mysqlCon);
                cmd.Parameters.AddWithValue(_idname, Int32.Parse(_datagrid[0, _e.RowIndex].Value.ToString()));
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
