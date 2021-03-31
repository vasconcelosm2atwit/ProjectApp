using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampApp
{
    class SessionsDatabaseManager
    {
        string connectionString = @"Server=mydb.c6botwup9amq.us-east-2.rds.amazonaws.com;Database=projectconference;Uid=root;Pwd=password123;convert zero datetime=True";
        
        //############################################### ADD ###############################################
        public void addSession(Sessions new_session)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();

                MySqlCommand mySqlCmdNewRooom = new MySqlCommand("add_session", mysqlCon);
                mySqlCmdNewRooom.CommandType = CommandType.StoredProcedure;
                mySqlCmdNewRooom.Parameters.AddWithValue("_title ", new_session.Title);
                mySqlCmdNewRooom.Parameters.AddWithValue("_time_slots_id", new_session.TimeSlots);
                mySqlCmdNewRooom.Parameters.AddWithValue("_speaker_id", new_session.Speaker);
                mySqlCmdNewRooom.Parameters.AddWithValue("_room_id", new_session.Room);
                mySqlCmdNewRooom.Parameters.AddWithValue("_date", new_session.Date);


                mySqlCmdNewRooom.ExecuteNonQuery();
                mysqlCon.Close();
            }
        }

        //############################################### RETRIEVE ###############################################
        public List<Sessions> retrieveSessions()
        {
            List<Sessions> sessionsList = new List<Sessions>();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                mysqlCon.Open();
                MySqlCommand mySqlCmdNewRooom = new MySqlCommand("retrieve_sessions", mysqlCon);
                mySqlCmdNewRooom.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter da = new MySqlDataAdapter(mySqlCmdNewRooom);

                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Sessions allSessions = new Sessions();
                        allSessions.Title = dt.Rows[i]["title"].ToString();
                        allSessions.TimeSlots = Int16.Parse(dt.Rows[i]["time_slot_id"].ToString());
                        allSessions.Speaker = Int16.Parse(dt.Rows[i]["speaker_id"].ToString());
                        allSessions.Room = Int16.Parse(dt.Rows[i]["room_id"].ToString());
                        allSessions.Date = dt.Rows[i]["session_date"].ToString();

                        sessionsList.Add(allSessions);
                    }
                }
                mySqlCmdNewRooom.ExecuteNonQuery();
                mysqlCon.Close();


            }
            return sessionsList;
        }

        //############################################### UPDATE ###############################################
        public void updateSessions(Sessions sessionsToUpdate)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                //IF NOT THEN USE
                /* MySqlCommand mySqlCmdNewRooom = new MySqlCommand("update_sessionTEST", mysqlCon);
                */

                MySqlCommand mySqlCmdNewRooom = new MySqlCommand("update_session", mysqlCon);
                mySqlCmdNewRooom.CommandType = CommandType.StoredProcedure;
                mySqlCmdNewRooom.Parameters.AddWithValue("_title ", sessionsToUpdate.Title);
                mySqlCmdNewRooom.Parameters.AddWithValue("_time_slots_id", sessionsToUpdate.TimeSlots);
                mySqlCmdNewRooom.Parameters.AddWithValue("_speaker_id", sessionsToUpdate.Speaker);
                mySqlCmdNewRooom.Parameters.AddWithValue("_room_id", sessionsToUpdate.Room);
                mySqlCmdNewRooom.Parameters.AddWithValue("_date", sessionsToUpdate.Date);

                mySqlCmdNewRooom.ExecuteNonQuery();
                mysqlCon.Close();

            }
        }

        //############################################### DELETE ###############################################
        public void deleteSession(Sessions sessionToDelete)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                //IF NOT THEN USE
                /*MySqlCommand mySqlCmdNewRooom = new MySqlCommand("delete_session", mysqlCon);
                 mySqlCmdNewRooom.CommandType = CommandType.StoredProcedure;
                mySqlCmdNewRooom.Parameters.AddWithValue("_title ", sessionToDelete.Title);
                mySqlCmdNewRooom.Parameters.AddWithValue("_time_slots_id", sessionToDelete.TimeSlots);
                mySqlCmdNewRooom.Parameters.AddWithValue("_speaker_id", sessionToDelete.Speaker);
                mySqlCmdNewRooom.Parameters.AddWithValue("_room_id", sessionToDelete.Room);
                mySqlCmdNewRooom.Parameters.AddWithValue("_date", sessionToDelete.Date);
                */

                MySqlCommand mySqlCmdNewRooom = new MySqlCommand("delete_sessionTEST", mysqlCon);
                mySqlCmdNewRooom.CommandType = CommandType.StoredProcedure;
                mySqlCmdNewRooom.Parameters.AddWithValue("_title ", sessionToDelete.Title);

                mySqlCmdNewRooom.ExecuteNonQuery();
                mysqlCon.Close();

            }
        }
    }
}
