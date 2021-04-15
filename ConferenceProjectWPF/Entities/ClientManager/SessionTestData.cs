using System.Collections.Generic;

namespace ConferenceProjectWPF
{
    class SessionTestData
    {
        /// <summary>
        /// DATA USED FOR TESTING SESSIONS
        /// 
        /// USED FOR DUMMY DATA SO WE DONT HAVE TO CONSTANTLY ACCESS THE DATABASE ON TESTING PHRASE
        /// 
        ///  DONT NOT DELETE IT ITS USED FOR TESTING
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Session> dataFill()
        {

            List<Session> testData = new List<Session>();

            Session session1 = new Session();
            session1.Timeslot_1 = "9:00 AM - 10:00 AM";
            session1.Title = "How to Code";
            session1.Room_1 = "Wentworth";
            session1.Speaker_1 = "Jane Doe";
            testData.Add(session1);
            
            Session session2 = new Session();
            session2.Timeslot_1 = "10:00 AM - 11:00 AM";
            session2.Title = "How to Code in C#";
            session2.Room_1 = "Wentworth South";
            session2.Speaker_1 = "Jose A";
            testData.Add(session2);

            Session session3 = new Session();
            session3.Timeslot_1 = "11:00 AM - 12:00 AM";
            session3.Title = "How to Code in C++";
            session3.Room_1 = "Wentworth EAST";
            session3.Speaker_1 = "Maria Maria";
            testData.Add(session3);

            Session session4 = new Session();
            session4.Timeslot_1 = "12:00 PM - 1:00 PM";
            session4.Title = "How to Code in Java: This is a begginer tutorial course in Java to people who never programmed before.";
            session4.Room_1 = "Wentworth NORTH";
            session4.Speaker_1 = "James Dontknow";
            testData.Add(session4);

            Session session5 = new Session();
            session5.Timeslot_1 = "12:00 PM - 1:00 PM";
            session5.Title = "How to Code in Java: This is a begginer tutorial course in Java to people who never programmed before.";
            session5.Room_1 = "Wentworth NORTH";
            session5.Speaker_1 = "James Dontknow";
            testData.Add(session5);

            Session session6 = new Session();
            session6.Timeslot_1 = "12:00 PM - 1:00 PM";
            session6.Title = "How to Code in Java: This is a begginer tutorial course in Java to people who never programmed before.";
            session6.Room_1 = "Wentworth NORTH";
            session6.Speaker_1 = "James Dontknow";
            testData.Add(session6);

            Session session7 = new Session();
            session7.Timeslot_1 = "12:00 PM - 1:00 PM";
            session7.Title = "How to Code in Java: This is a begginer tutorial course in Java to people who never programmed before.";
            session7.Room_1 = "Wentworth NORTH";
            session7.Speaker_1 = "James Dontknow";
            testData.Add(session7);


            return testData;


        }
    }
}
