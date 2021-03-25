using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace CodeCampApp
{
    class RoomsDatabaseManager
    {
        string connectionString = @"Server=mydb.c6botwup9amq.us-east-2.rds.amazonaws.com;Database=projectconference;Uid=root;Pwd=password123;convert zero datetime=True";

        //############################################### ADD ###############################################
        public void addRoom(Room new_room)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();

                MySqlCommand mySqlCmdNewRooom = new MySqlCommand("add_room", mysqlCon);
                mySqlCmdNewRooom.CommandType = CommandType.StoredProcedure;
                mySqlCmdNewRooom.Parameters.AddWithValue("_room", new_room.Name);
                mySqlCmdNewRooom.Parameters.AddWithValue("_capacity", new_room.Capacity);

                mySqlCmdNewRooom.ExecuteNonQuery();
                mysqlCon.Close();

            }
        }

        //############################################### RETRIEVE ###############################################
        public List<Room> RetrieveRooms()
        {
            List<Room> roomsList = new List<Room>();

            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                mysqlCon.Open();
                MySqlCommand mySqlCmdNewRooom = new MySqlCommand("retrieve_rooms", mysqlCon);
                mySqlCmdNewRooom.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter da = new MySqlDataAdapter(mySqlCmdNewRooom);

                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Room allRooms = new Room();
                        allRooms.Id = Int16.Parse(dt.Rows[i]["room_id"].ToString());
                        allRooms.Name = dt.Rows[i]["room_name"].ToString();
                        allRooms.Capacity = Int16.Parse(dt.Rows[i]["capacity"].ToString());
                        roomsList.Add(allRooms);
                    }

                }
                mySqlCmdNewRooom.ExecuteNonQuery();
                mysqlCon.Close();


                return roomsList;
            }
        }

        //############################################### UPDATE ###############################################
        public void updateRoom(Room roomToUpdate)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                //IF NOT THEN USE
                /*MySqlCommand mySqlCmdNewRooom = new MySqlCommand("update_roomTEST", mysqlCon);
                */

                MySqlCommand mySqlCmdNewRooom = new MySqlCommand("update_room", mysqlCon);
                mySqlCmdNewRooom.CommandType = CommandType.StoredProcedure;
                mySqlCmdNewRooom.Parameters.AddWithValue("_room", roomToUpdate.Name);
                mySqlCmdNewRooom.Parameters.AddWithValue("_capacity", roomToUpdate.Capacity);

                mySqlCmdNewRooom.ExecuteNonQuery();
                mysqlCon.Close();

            }
        }

        //############################################### DELETE ###############################################
        public void deleteRoom(Room roomToDelete)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                //IF NOT THEN USE
                /*MySqlCommand mySqlCmdNewRooom = new MySqlCommand("delete_roomTEST", mysqlCon);
                 mySqlCmdNewRooom.CommandType = CommandType.StoredProcedure;
                mySqlCmdNewRooom.Parameters.AddWithValue("_room", roomToDelete.Name);
                mySqlCmdNewRooom.Parameters.AddWithValue("_capacity", roomToDelete.Capacity);
                */

                MySqlCommand mySqlCmdNewRooom = new MySqlCommand("delete_roomTEST", mysqlCon);
                mySqlCmdNewRooom.CommandType = CommandType.StoredProcedure;
                mySqlCmdNewRooom.Parameters.AddWithValue("_room", roomToDelete.Name);

                mySqlCmdNewRooom.ExecuteNonQuery();
                mysqlCon.Close();

            }
        }

    }
}
