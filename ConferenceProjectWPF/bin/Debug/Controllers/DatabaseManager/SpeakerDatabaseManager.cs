
using ConferenceProjectWPF;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;

namespace ConferenceProjectWPF
{
    class SpeakerDatabaseManager
    {
        string connectionString = @"Server=mydb.c6botwup9amq.us-east-2.rds.amazonaws.com;Database=projectconference;Uid=root;Pwd=password123;convert zero datetime=True";
        
        //############################################### ADD ###############################################
        public void addSpeaker(Speaker new_speaker)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();

                MySqlCommand mySqlCmdNewRooom = new MySqlCommand("add_speaker", mysqlCon);
                mySqlCmdNewRooom.CommandType = CommandType.StoredProcedure;
                mySqlCmdNewRooom.Parameters.AddWithValue("_speaker_name", new_speaker.Name);
                mySqlCmdNewRooom.Parameters.AddWithValue("_email", new_speaker.Email);
                mySqlCmdNewRooom.Parameters.AddWithValue("_phone_number", new_speaker.PhoneNumber);

                mySqlCmdNewRooom.ExecuteNonQuery();
                mysqlCon.Close();

            }
        }

        //############################################### RETRIEVE ###############################################
        public List<Speaker> retrieveSpeakers()
        {
            List<Speaker> speakerList = new List<Speaker>();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                mysqlCon.Open();
                MySqlCommand mySqlCmdNewRooom = new MySqlCommand("retrieve_speakers", mysqlCon);
                mySqlCmdNewRooom.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter da = new MySqlDataAdapter(mySqlCmdNewRooom);

                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Speaker allSpeakers = new Speaker();
                        allSpeakers.Id = Int16.Parse(dt.Rows[i]["speaker_id"].ToString());
                        allSpeakers.Name = dt.Rows[i]["name"].ToString();
                        allSpeakers.Email = dt.Rows[i]["email"].ToString();
                        allSpeakers.PhoneNumber = dt.Rows[i]["phone_number"].ToString();
                        speakerList.Add(allSpeakers);
                    }
                }
                mySqlCmdNewRooom.ExecuteNonQuery();
                mysqlCon.Close();

                return speakerList;
            }
        }

        //############################################### UPDATE ###############################################
            public void updateSpeaker(Speaker speakerToUpdate)
            {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                //IF NOT THEN USE
                /*MySqlCommand mySqlCmdNewRooom = new MySqlCommand("update_speakerTEST", mysqlCon);
                */

                MySqlCommand mySqlCmdNewRooom = new MySqlCommand("update_speaker", mysqlCon);
                mySqlCmdNewRooom.CommandType = CommandType.StoredProcedure;
                mySqlCmdNewRooom.Parameters.AddWithValue("_speaker_name", speakerToUpdate.Name);
                mySqlCmdNewRooom.Parameters.AddWithValue("_email", speakerToUpdate.Email);
                mySqlCmdNewRooom.Parameters.AddWithValue("_phone_number", speakerToUpdate.PhoneNumber);

                mySqlCmdNewRooom.ExecuteNonQuery();
                mysqlCon.Close();

            }
        }

        //############################################### DELETE ###############################################
        //when room is deleted it has to check if session has that room and delete the session as well
        public void deleteSpeaker(Speaker speakerToDelete)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                //IF NOT THEN USE
                /*MySqlCommand mySqlCmdNewRooom = new MySqlCommand("delete_speaker", mysqlCon);
                 mySqlCmdNewRooom.CommandType = CommandType.StoredProcedure;
                 mySqlCmdNewRooom.Parameters.AddWithValue("_speaker_name", speakerToDelete.Name);
                mySqlCmdNewRooom.Parameters.AddWithValue("_email", speakerToDelete.Email);
                mySqlCmdNewRooom.Parameters.AddWithValue("_phone_number", speakerToDelete.PhoneNumber);
                */

                MySqlCommand mySqlCmdNewRooom = new MySqlCommand("delete_speakerTEST", mysqlCon);
                mySqlCmdNewRooom.CommandType = CommandType.StoredProcedure;
                mySqlCmdNewRooom.Parameters.AddWithValue("_speaker_name", speakerToDelete.Name);
                
                mySqlCmdNewRooom.ExecuteNonQuery();
                mysqlCon.Close();

            }
        }
    }
}
