using CodeCampApp.Ui.ChildComponents;
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

namespace CodeCampApp
{
    public partial class SpeakerPage : Form
    {
        private DataTable _dt;
        string connectionString = @"Server=mydb.c6botwup9amq.us-east-2.rds.amazonaws.com;Database=projectconference;Uid=root;Pwd=password123;convert zero datetime=True";
        public SpeakerPage()
        {
            InitializeComponent();

            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();

                var stm = "select * from speaker";
                var cmd = new MySqlCommand(stm, mysqlCon);

                MySqlDataReader rdr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                _dt = dt;
                dt.Columns.Add("id", typeof(int));
                dt.Columns.Add("name", typeof(string));
                dt.Columns.Add("email", typeof(string));
                dt.Columns.Add("phone_number", typeof(string));
                dt.Columns.Add("edit", typeof(string));
                dt.Columns.Add("delete", typeof(string));
                dt.Columns.Add("save", typeof(string));
                dt.Columns.Add("cancel", typeof(string));

                while (rdr.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr["id"] = rdr.GetInt32(0);
                    dr["name"] = rdr.GetString(1);
                    dr["email"] = rdr.GetString(2);
                    dr["phone_number"] = rdr.GetString(3);
                    dr["edit"] = "1";
                    dr["delete"] = "1";
                    dr["save"] = "1";
                    dr["cancel"] = "1";
                    dt.Rows.Add(dr);
                }
                dataGridView1.Columns.Add("id", "ID");
                dataGridView1.Columns.Add("name", "Name");
                dataGridView1.Columns.Add("email", "Email");
                dataGridView1.Columns.Add("phone_number", "Phone Number");
                dataGridView1.Columns.Add("edit", "Edit");
                dataGridView1.Columns.Add("delete", "Delete");
                dataGridView1.Columns.Add("save", "Save");
                dataGridView1.Columns.Add("cancel", "Cancel");
                dataGridView1.Columns["name"].ReadOnly = true;
                dataGridView1.Columns["email"].ReadOnly = true;
                dataGridView1.Columns["phone_number"].ReadOnly = true;
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.Columns["save"].Visible = false;
                dataGridView1.Columns["cancel"].Visible = false;
                dataGridView1.AllowUserToAddRows = false;
                string[] lst_dados = new string[4];

                foreach (DataRow dr1 in dt.Rows)
                {
                    lst_dados[0] = dr1["id"].ToString();
                    lst_dados[1] = dr1["name"].ToString();
                    lst_dados[2] = dr1["email"].ToString();
                    lst_dados[3] = dr1["phone_number"].ToString();
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
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Hello");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    dataGridView1.Columns[4].HeaderCell.Value = "Save";
                    dataGridView1.Columns[5].HeaderCell.Value = "Cancel";
                    dataGridView1.Columns["name"].ReadOnly = false;
                    dataGridView1.Columns["email"].ReadOnly = false;
                    dataGridView1.Columns["phone_number"].ReadOnly = false;
                    dataGridView1.Columns["edit"].Visible = false;
                    dataGridView1.Columns["delete"].Visible = false;
                    dataGridView1.Columns["save"].Visible = true;
                    dataGridView1.Columns["cancel"].Visible = true;
                }

                if (buttonName == "delete")
                {
                    DeleteModal popup = new DeleteModal(this.dataGridView1, e);
                    popup.ShowDialog(this);
                }

                if (buttonName == "save")
                {
                    dataGridView1.Columns[4].HeaderCell.Value = "Edit";
                    dataGridView1.Columns[5].HeaderCell.Value = "Delete";
                    dataGridView1.Columns["name"].ReadOnly = true;
                    dataGridView1.Columns["email"].ReadOnly = true;
                    dataGridView1.Columns["phone_number"].ReadOnly = true;
                    dataGridView1.Columns["edit"].Visible = true;
                    dataGridView1.Columns["delete"].Visible = true;
                    dataGridView1.Columns["save"].Visible = false;
                    dataGridView1.Columns["cancel"].Visible = false;

                    // Query Database

                    using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                    {
                        mysqlCon.Open();

                        var stm = "update speaker set name = @newName, email = @newEmail, phone_number = @newPhoneNumber where speaker_id = @id";

                        var cmd = new MySqlCommand(stm, mysqlCon);
                        cmd.Parameters.AddWithValue("@newName", this.dataGridView1[1, e.RowIndex].Value.ToString());
                        cmd.Parameters.AddWithValue("@newEmail", this.dataGridView1[2, e.RowIndex].Value.ToString());
                        cmd.Parameters.AddWithValue("@newPhoneNumber", this.dataGridView1[3, e.RowIndex].Value.ToString());
                        cmd.Parameters.AddWithValue("@id", Int32.Parse(this.dataGridView1[0, e.RowIndex].Value.ToString()));
                        cmd.ExecuteNonQuery();

                        mysqlCon.Close();
                    }
                }

                if (buttonName == "cancel")
                {

                     dataGridView1.Columns[4].HeaderCell.Value = "Edit";
                     dataGridView1.Columns[5].HeaderCell.Value = "Delete";
                     dataGridView1.Columns["name"].ReadOnly = true;
                     dataGridView1.Columns["email"].ReadOnly = true;
                     dataGridView1.Columns["phone_number"].ReadOnly = true;
                     dataGridView1.Columns["edit"].Visible = true;
                     dataGridView1.Columns["delete"].Visible = true;
                     dataGridView1.Columns["save"].Visible = false;
                     dataGridView1.Columns["cancel"].Visible = false;
                }
            }
        }
        private void addNewSpeaker_Click(object sender, EventArgs e)
        {
            AddSpeakerModal add = new AddSpeakerModal(this.dataGridView1, _dt);
            add.ShowDialog(this);
            this.Refresh();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
