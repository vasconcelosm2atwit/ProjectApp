using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;

namespace ConferenceProjectWPF
{
    /// <summary>
    /// HANDLES DATABASE CONNECTION FOR SESSION TABLE AND ENTITY
    /// </summary>
    class SessionsDatabaseManager
    {
        string connectionString = @"Server=mydb.c6botwup9amq.us-east-2.rds.amazonaws.com;Database=projectconference;Uid=root;Pwd=password123;convert zero datetime=True";
        
        //############################################### ADD ###############################################
        public void addSession(Session new_session)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();

                new_session.RealDate = DateTime.Parse(new_session.Date);

                MySqlCommand mySqlCmdNewRooom = new MySqlCommand("add_session", mysqlCon);
                mySqlCmdNewRooom.CommandType = CommandType.StoredProcedure;
                mySqlCmdNewRooom.Parameters.AddWithValue("_title ", new_session.Title);
                mySqlCmdNewRooom.Parameters.AddWithValue("_time_slots_id", new_session.TimeSlots);
                mySqlCmdNewRooom.Parameters.AddWithValue("_speaker_id", new_session.Speaker);
                mySqlCmdNewRooom.Parameters.AddWithValue("_room_id", new_session.Room);
                mySqlCmdNewRooom.Parameters.AddWithValue("_date", new_session.RealDate);

                try
                {
                    mySqlCmdNewRooom.ExecuteNonQuery();
                }catch(Exception e)
                {
                    Console.WriteLine(e);
                }
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

                MySqlCommand mySqlCmdNewRoom2 = new MySqlCommand("retrieve_sessions", mysqlCon);
                mySqlCmdNewRooom.CommandType = CommandType.StoredProcedure;

                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Session allSessions = new Session();
                        DateTime dateTime = new DateTime();
                        allSessions.Title = dt.Rows[i]["title"].ToString();
                        allSessions.Timeslot_1 = dt.Rows[i]["time_slots"].ToString();
                        allSessions.Speaker_1 = dt.Rows[i]["name"].ToString();
                        allSessions.Room_1 = dt.Rows[i]["room_name"].ToString();
                        dateTime = (DateTime)dt.Rows[i]["session_date"];
                        //String.Format("{0:M/d/yyyy}", dateTime);
                        allSessions.Date = dateTime.ToString("MM/dd/yyyy");
                        allSessions.Id = Int16.Parse(dt.Rows[i]["session_id"].ToString());



                        sessionsList.Add(allSessions);
                    }
                }
                mySqlCmdNewRooom.ExecuteNonQuery();
                mysqlCon.Close();


            }
            return sessionsList;
        }

        /// <summary>
        /// ALL SESSIONS FROM SESSION TABLE
        /// </summary>
        /// <returns></returns>
        public List<Session> getSessions()
        {
            List<Session> sessionList = new List<Session>();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                mysqlCon.Open();
                MySqlCommand mySqlCmdNewRooom = new MySqlCommand("view_sessions", mysqlCon);
                mySqlCmdNewRooom.CommandType = CommandType.StoredProcedure;
                MySqlDataReader da = mySqlCmdNewRooom.ExecuteReader();

                while (da.Read())
                {
                    Session session = new Session();
                    session.Id = Convert.ToInt32(da["session_id"]);
                    session.Room = Convert.ToInt32(da["room_id"]);
                    session.Speaker = Convert.ToInt32(da["speaker_id"]);
                    session.TimeSlots = Convert.ToInt32(da["time_slots_id"]);
                    DateTime dateTime = new DateTime();
                    dateTime = (DateTime) da["session_date"];

                    session.Date = dateTime.ToString("MM/dd/yyyy");
                    session.Title = Convert.ToString(da["title"]);

                    RoomsDatabaseManager rdb = new RoomsDatabaseManager();
                    Room room = rdb.get_room_by_id(session.Room);
                    SpeakerDatabaseManager spdb = new SpeakerDatabaseManager();
                    Speaker speaker = spdb.get_speaker_by_id(session.Speaker);
                    TimeSlotsDatabaseManager tdb = new TimeSlotsDatabaseManager();
                    TimeSlot timeslot = tdb.get_timeslot_by_id(session.TimeSlots);

                    session.Timeslot_1 = timeslot.ConcatTimeSlot;
                    //Console.WriteLine(timeslot.ConcatTimeSlot);
                    session.Room_1 = room.Name;
                    session.Speaker_1 = speaker.Name;

                    sessionList.Add(session);
                }

                // mySqlCmdNewRooom.ExecuteNonQuery();
                mysqlCon.Close();
            }

            return sessionList;

        }

        /// <summary>
        /// ALL AVAILABLE TIME SLOTS
        /// </summary>
        /// <returns></returns>
        public List<TimeSlot> getAvailableTimeSlots()
        {
            List<TimeSlot> timeslotList = new List<TimeSlot>();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                mysqlCon.Open();
                MySqlCommand mySqlCmdNewRooom = new MySqlCommand("view_timeslots", mysqlCon);
                mySqlCmdNewRooom.CommandType = CommandType.StoredProcedure;
                MySqlDataReader da = mySqlCmdNewRooom.ExecuteReader();

                while (da.Read())
                {
                    TimeSlot timeSlot = new TimeSlot();
                    timeSlot.Id = Convert.ToInt32(da["time_slots_id"]);
                    timeSlot.ConcatTimeSlot = Convert.ToString(da["time_slots"]);
                    timeslotList.Add(timeSlot);
                }
                
               // mySqlCmdNewRooom.ExecuteNonQuery();
                mysqlCon.Close();
            }

            return timeslotList;

        }

        public Session get_session_by_id(int id)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                mysqlCon.Open();
                MySqlCommand mySqlCmdNewRooom = new MySqlCommand("get_session_by_id", mysqlCon);
                mySqlCmdNewRooom.CommandType = CommandType.StoredProcedure;
                mySqlCmdNewRooom.Parameters.AddWithValue("_id ", id);
                MySqlDataReader da = mySqlCmdNewRooom.ExecuteReader();
                Session session = new Session();
                while (da.Read()) { 
                    
                    session.Id = Convert.ToInt32(da["session_id"]);
                    session.Room = Convert.ToInt32(da["room_id"]);
                    session.Title = Convert.ToString(da["title"]);
                    session.Speaker = Convert.ToInt32(da["speaker_id"]);
                    session.TimeSlots = Convert.ToInt32(da["time_slots_id"]);
                }

                // mySqlCmdNewRooom.ExecuteNonQuery();
                mysqlCon.Close();

                return session;
            }
        }

        /// <summary>
        /// ACCESS ALL SPEAKERS FROM SPEAKER TABLE
        /// </summary>
        /// <returns></returns>
        public List<Speaker> getAllSpeakers()
        {
            List<Speaker> speakerList = new List<Speaker>();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                mysqlCon.Open();
                MySqlCommand mySqlCmdNewRooom = new MySqlCommand("view_speakers", mysqlCon);
                mySqlCmdNewRooom.CommandType = CommandType.StoredProcedure;
                MySqlDataReader da = mySqlCmdNewRooom.ExecuteReader();

                while (da.Read())
                {
                    Speaker speaker = new Speaker();
                    speaker.Id = Convert.ToInt32(da["speaker_id"]);
                    speaker.Name = Convert.ToString(da["name"]);
                    speakerList.Add(speaker);
                }

                // mySqlCmdNewRooom.ExecuteNonQuery();
                mysqlCon.Close();
            }

            return speakerList;

        }

        public List<Room> getAllRooms()
        {
            List<Room> roomList = new List<Room>();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                mysqlCon.Open();
                MySqlCommand mySqlCmdNewRooom = new MySqlCommand("view_rooms", mysqlCon);
                mySqlCmdNewRooom.CommandType = CommandType.StoredProcedure;
                MySqlDataReader da = mySqlCmdNewRooom.ExecuteReader();

                while (da.Read())
                {
                    Room room = new Room();
                    room.Id = Convert.ToInt32(da["room_id"]);
                    room.Name = Convert.ToString(da["room_name"]);
                    roomList.Add(room);
                }

                // mySqlCmdNewRooom.ExecuteNonQuery();
                mysqlCon.Close();
            }

            return roomList;

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

                sessionsToUpdate.RealDate = DateTime.Parse(sessionsToUpdate.Date);
                mySqlCmdNewRooom.Parameters.AddWithValue("_date", sessionsToUpdate.RealDate);
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
               
                MySqlCommand mySqlCmdNewRooom = new MySqlCommand("delete_sessions", mysqlCon);
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
