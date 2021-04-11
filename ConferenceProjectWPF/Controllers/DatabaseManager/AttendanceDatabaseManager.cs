using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceProjectWPF
{
    class AttendanceDatabaseManager
    {
        string connectionString = @"Server=mydb.c6botwup9amq.us-east-2.rds.amazonaws.com;Database=projectconference;Uid=root;Pwd=password123;convert zero datetime=True";

        //############################################### ADD ###############################################
        public void addCount(Attendance count)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();

                MySqlCommand mySqlCmdNewRooom = new MySqlCommand("add_count", mysqlCon);
                mySqlCmdNewRooom.CommandType = CommandType.StoredProcedure;
                mySqlCmdNewRooom.Parameters.AddWithValue("_count_beg", count.Count_beg);
                mySqlCmdNewRooom.Parameters.AddWithValue("_count_mid", count.Count_mid);
                mySqlCmdNewRooom.Parameters.AddWithValue("_count_end", count.Count_end);
                mySqlCmdNewRooom.Parameters.AddWithValue("_session_id", count.Session_id);

                mySqlCmdNewRooom.ExecuteNonQuery();
                mysqlCon.Close();

            }
        }

        //############################################### RETRIEVE ###############################################
        public List<Attendance> RetrieveCount()
        {
            List<Attendance> countList = new List<Attendance>();

            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                mysqlCon.Open();
                MySqlCommand mySqlCmdNewRooom = new MySqlCommand("retrieve_count", mysqlCon);
                mySqlCmdNewRooom.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter da = new MySqlDataAdapter(mySqlCmdNewRooom);

                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Attendance count = new Attendance();
                        count.Id = Int16.Parse(dt.Rows[i]["count_id"].ToString());
                        count.Count_beg = Int16.Parse(dt.Rows[i]["count_beg"].ToString());
                        count.Count_mid = Int16.Parse(dt.Rows[i]["count_mid"].ToString());
                        count.Count_end = Int16.Parse(dt.Rows[i]["count_end"].ToString());
                        count.Session_id = Int16.Parse(dt.Rows[i]["session_id"].ToString());

                        SessionsDatabaseManager sdb = new SessionsDatabaseManager();
                        //Console.WriteLine("running here");
                        Session session = sdb.get_session_by_id(count.Session_id);
                        RoomsDatabaseManager rdb = new RoomsDatabaseManager();
                        Room room = rdb.get_room_by_id(session.Room);
                        SpeakerDatabaseManager spdb = new SpeakerDatabaseManager();
                        Speaker speaker = spdb.get_speaker_by_id(session.Speaker);

                        TimeSlotsDatabaseManager tdb = new TimeSlotsDatabaseManager();
                        TimeSlot timeslot = tdb.get_timeslot_by_id(session.TimeSlots);

                       
                        count.Session_title = session.Title;
                        count.Session_room = room.Name;
                        count.Session_speaker = speaker.Name;
                        count.Timeslot = timeslot.ConcatTimeSlot;
                        //Console.WriteLine(count.Timeslot);
                        count.Date = session.Date;

                        countList.Add(count);
                    }

                    

                }
                mySqlCmdNewRooom.ExecuteNonQuery();
                mysqlCon.Close();


                return countList;
            }
        }

        //############################################### UPDATE ###############################################
        public void updateCount(Attendance count)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                //IF NOT THEN USE
                /*MySqlCommand mySqlCmdNewRooom = new MySqlCommand("update_roomTEST", mysqlCon);
                */

                MySqlCommand mySqlCmdNewRooom = new MySqlCommand("update_count", mysqlCon);
                mySqlCmdNewRooom.CommandType = CommandType.StoredProcedure;
                mySqlCmdNewRooom.Parameters.AddWithValue("_id",count.Id);
                mySqlCmdNewRooom.Parameters.AddWithValue("_count_beg", count.Count_beg);
                mySqlCmdNewRooom.Parameters.AddWithValue("_count_mid", count.Count_mid);
                mySqlCmdNewRooom.Parameters.AddWithValue("_count_end", count.Count_end);
                

                mySqlCmdNewRooom.ExecuteNonQuery();
                mysqlCon.Close();

            }
        }

        //############################################### DELETE ###############################################
        
    }
}
