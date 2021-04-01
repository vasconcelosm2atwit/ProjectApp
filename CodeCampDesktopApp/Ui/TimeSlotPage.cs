using CodeCampApp.Ui.ChildComponents;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CodeCampApp
{
    public partial class TimeSlotPage : Form
    {
        private DataTable _dt;
        string connectionString = @"Server=mydb.c6botwup9amq.us-east-2.rds.amazonaws.com;Database=projectconference;Uid=root;Pwd=password123;convert zero datetime=True";
        public TimeSlotPage()
        {
            InitializeComponent();
            updateData();
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
        }
        public void updateData()
        {
            dataGridView1.Rows.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();

                var stm = "select * from time_slots";
                /// To Add paramters to query
                /// string query = "select * from timeslots where time_slot_id = @<param-placeholder-name>
                /// command.Parameters.AddWithValue("@<param-placeholder-name>", "<valuetolookfor>")
                var cmd = new MySqlCommand(stm, mysqlCon);

                MySqlDataReader rdr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                _dt = dt;
                dt.Columns.Add("id", typeof(int));
                dt.Columns.Add("start_time", typeof(string));
                dt.Columns.Add("end_time", typeof(string));
                dt.Columns.Add("edit", typeof(string));
                dt.Columns.Add("delete", typeof(string));
                dt.Columns.Add("save", typeof(string));
                dt.Columns.Add("cancel", typeof(string));

                while (rdr.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr["id"] = rdr.GetInt32(0);
                    dr["start_time"] = rdr.GetString(1);
                    dr["end_time"] = rdr.GetString(2);
                    dr["edit"] = "1";
                    dr["delete"] = "1";
                    dr["save"] = "1";
                    dr["cancel"] = "1";
                    dt.Rows.Add(dr);
                }
                dataGridView1.Columns.Add("id", "ID");
                dataGridView1.Columns.Add("start_time", "Start Time");
                dataGridView1.Columns.Add("end_time", "End Time");
                dataGridView1.Columns.Add("edit", "Edit");
                dataGridView1.Columns.Add("delete", "Delete");
                dataGridView1.Columns.Add("save", "Save");
                dataGridView1.Columns.Add("cancel", "Cancel");
                dataGridView1.Columns["start_time"].ReadOnly = true;
                dataGridView1.Columns["end_time"].ReadOnly = true;
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.Columns["save"].Visible = false;
                dataGridView1.Columns["cancel"].Visible = false;
                dataGridView1.AllowUserToAddRows = false;
                string[] lst_dados = new string[3];

                foreach (DataRow dr1 in dt.Rows)
                {
                    lst_dados[0] = dr1["id"].ToString();
                    var start_time = DateTime.Parse((dr1["start_time"].ToString()));
                    var end_time = DateTime.Parse((dr1["end_time"].ToString()));
                    lst_dados[1] = start_time.ToString("hh:mm tt");
                    lst_dados[2] = end_time.ToString("hh:mm tt");
                    this.dataGridView1.Rows.Add(lst_dados);

                    if (dr1["edit"].ToString() == "1")
                    {
                        DataGridViewButtonCell btn = new DataGridViewButtonCell();
                        btn.Value = "Edit";
                        btn.UseColumnTextForButtonValue = true;
                        this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells["edit"] = btn;
                    }
                    if (dr1["delete"].ToString() == "1")
                    {
                        DataGridViewButtonCell btn = new DataGridViewButtonCell();
                        btn.Value = "Delete";
                        btn.UseColumnTextForButtonValue = true;
                        this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells["delete"] = btn;
                    }
                    if (dr1["save"].ToString() == "1")
                    {
                        DataGridViewButtonCell btn = new DataGridViewButtonCell();
                        btn.Value = "Save";
                        btn.UseColumnTextForButtonValue = true;
                        this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells["save"] = btn;
                    }
                    if (dr1["cancel"].ToString() == "1")
                    {
                        DataGridViewButtonCell btn = new DataGridViewButtonCell();
                        btn.Value = "Cancel";
                        btn.UseColumnTextForButtonValue = true;
                        this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells["cancel"] = btn;
                    }

                }

                mysqlCon.Close();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Hello");
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            handleButtonClick(sender, e, "edit");
            handleButtonClick(sender, e, "delete");
            handleButtonClick(sender, e, "save");
            handleButtonClick(sender, e, "cancel");

        }

        private void handleButtonClick(object sender, DataGridViewCellEventArgs e, string buttonName)
        {
            if (e.ColumnIndex == this.dataGridView1.Columns[buttonName].Index)
            {
                if (buttonName == "edit")
                {
                    dataGridView1.Columns[3].HeaderCell.Value = "Save";
                    dataGridView1.Columns[4].HeaderCell.Value = "Cancel";
                    dataGridView1.Columns["start_time"].ReadOnly = false;
                    dataGridView1.Columns["end_time"].ReadOnly = false;
                    dataGridView1.Columns["edit"].Visible = false;
                    dataGridView1.Columns["delete"].Visible = false;
                    dataGridView1.Columns["save"].Visible = true;
                    dataGridView1.Columns["cancel"].Visible = true;
                }
                if (buttonName == "delete")
                {
                    DeleteModal popup = new DeleteModal(this.dataGridView1, e, "time_slots", "time_slots_id");
                    popup.ShowDialog(this);
                }
                if (buttonName == "save")
                {
                    dataGridView1.Columns[3].HeaderCell.Value = "Edit";
                    dataGridView1.Columns[4].HeaderCell.Value = "Delete";
                    dataGridView1.Columns["start_time"].ReadOnly = true;
                    dataGridView1.Columns["end_time"].ReadOnly = true;
                    dataGridView1.Columns["edit"].Visible = true;
                    dataGridView1.Columns["delete"].Visible = true;
                    dataGridView1.Columns["save"].Visible = false;
                    dataGridView1.Columns["cancel"].Visible = false;

                    // Query Database

                    using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                    {
                        mysqlCon.Open();

                        var stm = "update time_slots set start_time = @newStartTime, end_time = @newEndTime where time_slots_id = @id";
                        /// To Add paramters to query

                        /// command.Parameters.AddWithValue("@<param-placeholder-name>", "<valuetolookfor>")
                        var cmd = new MySqlCommand(stm, mysqlCon);
                        cmd.Parameters.AddWithValue("@newStartTime", this.dataGridView1[1, e.RowIndex].Value.ToString());
                        cmd.Parameters.AddWithValue("@newEndTime", this.dataGridView1[2, e.RowIndex].Value.ToString());
                        cmd.Parameters.AddWithValue("@id", Int32.Parse(this.dataGridView1[0, e.RowIndex].Value.ToString()));
                        cmd.ExecuteNonQuery();

                        mysqlCon.Close();
                    }

                    if (buttonName == "cancel")
                    {

                        dataGridView1.Columns[3].HeaderCell.Value = "Edit";
                        dataGridView1.Columns[4].HeaderCell.Value = "Delete";
                        dataGridView1.Columns["start_time"].ReadOnly = true;
                        dataGridView1.Columns["end_time"].ReadOnly = true;
                        dataGridView1.Columns["edit"].Visible = true;
                        dataGridView1.Columns["delete"].Visible = true;
                        dataGridView1.Columns["save"].Visible = false;
                        dataGridView1.Columns["cancel"].Visible = false;
                    }
                }
            }
        }

        private void createNewTimeSlot_Click(object sender, EventArgs e)
        {
            AddTimeSlotModal add = new AddTimeSlotModal(this.dataGridView1, _dt);
            add.ShowDialog(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
