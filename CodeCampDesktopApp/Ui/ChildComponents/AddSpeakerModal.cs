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
    public partial class AddSpeakerModal : Form
    {
        private DataGridView _datagrid;
        private string _name;
        private string _email;
        private string _phone;
        private DataTable _dt;
        public AddSpeakerModal(DataGridView datagrid, DataTable dt)
        {
            _datagrid = datagrid;
            _dt = dt;
            InitializeComponent();

        }

        private void add_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=mydb.c6botwup9amq.us-east-2.rds.amazonaws.com;Database=projectconference;Uid=root;Pwd=password123;convert zero datetime=True";
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                _name = textBox1.Text;
                _email = textBox2.Text;
                _phone = textBox3.Text;
                mysqlCon.Open();
                var stm = "insert into speaker (name, email, phone_number) values (@name, @email, @phone)";
                var cmd = new MySqlCommand(stm, mysqlCon);
                cmd.Parameters.AddWithValue("name", _name);
                cmd.Parameters.AddWithValue("email", _email);
                cmd.Parameters.AddWithValue("phone", _phone);
                cmd.ExecuteNonQuery();
                var id = "select speaker_id from speaker";
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
                row["name"] = _name;
                row["email"] = _email;
                row["phone_number"] = _phone;
                row["edit"] = "1";
                row["delete"] = "1";
                row["save"] = "1";
                row["cancel"] = "1";
                _dt.Rows.Add(row);
                
                mysqlCon.Close();
            }
            this.Dispose();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
