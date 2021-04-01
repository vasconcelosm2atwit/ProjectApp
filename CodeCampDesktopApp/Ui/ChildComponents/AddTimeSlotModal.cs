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
    public partial class AddTimeSlotModal : Form
    {
        private DataGridView _datagrid;
        private string _startTime;
        private string _endTime;
        private DataTable _dt;
        public AddTimeSlotModal(DataGridView datagrid, DataTable dt)
        {
            _datagrid = datagrid;
            _dt = dt;
            InitializeComponent();
            dateTimePicker1.ValueChanged += new EventHandler(dateTimePicker1_ValueChanged);
            dateTimePicker2.ValueChanged += new EventHandler(dateTimePicker2_ValueChanged);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "hh:mm tt"; // Only use hours and minutes
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "hh:mm tt"; // Only use hours and minutes
            dateTimePicker2.ShowUpDown = true;
            _endTime = dateTimePicker2.Value.ToString();
            _startTime = dateTimePicker1.Value.ToString();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            _startTime = dateTimePicker1.Value.ToString("hh:mm tt");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            _endTime = dateTimePicker2.Value.ToString("hh:mm tt");
        }

        private void add_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=mydb.c6botwup9amq.us-east-2.rds.amazonaws.com;Database=projectconference;Uid=root;Pwd=password123;convert zero datetime=True";
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                var stm = "insert into time_slots (start_time, end_time) values (@start_time, @end_time)";
                var cmd = new MySqlCommand(stm, mysqlCon);
                cmd.Parameters.AddWithValue("start_time", _startTime);
                cmd.Parameters.AddWithValue("end_time", _endTime);
                cmd.ExecuteNonQuery();
                /*var id = "select time_slots_id from time_slots";
                var idcmd = new MySqlCommand(id, mysqlCon);
                var reader = idcmd.ExecuteReader();
                var newID = 0;
                while (reader.Read())
                {
                    newID = reader.GetInt32(0);
                }
                newID = newID + 1;
                DataRow row = _dt.NewRow();
                row["id"] = newID;
                row["start_time"] = _startTime;
                    row["end_time"] = _endTime;
                    row["edit"] = "1";
                    row["delete"] = "1";
                    row["save"] = "1";
                    row["cancel"] = "1";
                    _dt.Rows.Add(row);
                */
                mysqlCon.Close();
            }
           // _datagrid.Rows.Add();
            this.Dispose();
        }
    }
}
