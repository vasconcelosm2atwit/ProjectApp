using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;

namespace ConferenceProjectWPF
{
    class SessionsDatabaseManager
    {
        string connectionString = @"Server=mydb.c6botwup9amq.us-east-2.rds.amazonaws.com;Database=projectconference;Uid=root;Pwd=password123;convert zero datetime=True";
        
        //############################################### ADD ###############################################
        public void addSession(Session new_session)
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
        public List<Session> retrieveSessions()
        {
            List<Session> sessionsList = new List<Session>();
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
                        Session allSessions = new Session();
                        allSessions.Title = dt.Rows[i]["title"].ToString();
                        allSessions.Timeslot_1 = dt.Rows[i]["time_slots"].ToString();
                        allSessions.Speaker_1 = dt.Rows[i]["name"].ToString();
                        allSessions.Room_1 = dt.Rows[i]["room_name"].ToString();
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
        public void updateSessions(Session sessionsToUpdate)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
             
                MySqlCommand mySqlCmdNewRooom = new MySqlCommand("update_session", mysqlCon);
                mySqlCmdNewRooom.CommandType = CommandType.StoredProcedure;
                mySqlCmdNewRooom.Parameters.AddWithValue("_title ", sessionsToUpdate.Title);
                mySqlCmdNewRooom.Parameters.AddWithValue("_time_slots_id", sessionsToUpdate.TimeSlots);
                mySqlCmdNewRooom.Parameters.AddWithValue("_speaker_id", sessionsToUpdate.Speaker);
                mySqlCmdNewRooom.Parameters.AddWithValue("_room_id", sessionsToUpdate.Room);
                mySqlCmdNewRooom.Parameters.AddWithValue("_date", sessionsToUpdate.Date);
                mySqlCmdNewRooom.Parameters.AddWithValue("_id", sessionsToUpdate.Id);

                mySqlCmdNewRooom.ExecuteNonQuery();
                mysqlCon.Close();

            }
        }

        //############################################### DELETE ###############################################
        public void deleteSession(Session sessionToDelete)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
               
                MySqlCommand mySqlCmdNewRooom = new MySqlCommand("delete_session", mysqlCon);
                mySqlCmdNewRooom.CommandType = CommandType.StoredProcedure;
                mySqlCmdNewRooom.Parameters.AddWithValue("_title ", sessionToDelete.Title);
                mySqlCmdNewRooom.Parameters.AddWithValue("_time_slots_id", sessionToDelete.TimeSlots);
                mySqlCmdNewRooom.Parameters.AddWithValue("_speaker_id", sessionToDelete.Speaker);
                mySqlCmdNewRooom.Parameters.AddWithValue("_room_id", sessionToDelete.Room);
                mySqlCmdNewRooom.Parameters.AddWithValue("_date", sessionToDelete.Date);
                mySqlCmdNewRooom.Parameters.AddWithValue("_id", sessionToDelete.Id);


                mySqlCmdNewRooom.ExecuteNonQuery();
                mysqlCon.Close();

            }
        }
    }
}
