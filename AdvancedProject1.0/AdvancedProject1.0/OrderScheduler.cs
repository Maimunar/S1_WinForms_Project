﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdvancedProject1._0
{
    class OrderScheduler
    {
        private HouseUnit unit;
        private string currentID_common;
        private string currentID_kitchen;
        private string currentID_bathroom;
        private string currentID_garbage;
        private string currentID_groceries;

        public string CurrentIDCommon
        {
            get { return this.currentID_common; }
            private set { this.currentID_common = value; }
        }

        public string CurrentIDKitchen
        {
            get { return this.currentID_kitchen; }
            private set { this.currentID_kitchen = value; }
        }

        public string CurrentIDBathroom
        {
            get { return this.currentID_bathroom; }
            private set { this.currentID_bathroom = value; }
        }

        public string CurrentIDGarbage
        {
            get { return this.currentID_garbage; }
            private set { this.currentID_garbage = value; }
        }
        public string CurrentIDGroceries
        {
            get { return this.currentID_groceries; }
            private set { this.currentID_groceries = value; }
        }


        public OrderScheduler(HouseUnit newUnit)
        {
            this.unit = newUnit;
            bool newOrder = false;
            bool newDate = false;

            SqlConnection con = SqlConnectionHandler.GetSqlConnection();
            using (SqlCommand cmd = new SqlCommand($"SELECT * FROM SchedulerOrder WHERE unitID=@Id", con))
            {
                cmd.Parameters.AddWithValue("@Id", newUnit.UnitID);
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    User targetUser = new User(newUnit.Tenants[0].UserID);
                    this.CurrentIDCommon = dataReader[1] as string ?? targetUser.UserID;
                    this.CurrentIDKitchen = dataReader[2] as string ?? targetUser.UserID;
                    this.CurrentIDBathroom = dataReader[3] as string ?? targetUser.UserID;
                    this.CurrentIDGarbage = dataReader[4] as string ?? targetUser.UserID;
                    this.CurrentIDGroceries = dataReader[5] as string ?? targetUser.UserID;
                }
                else newOrder = true;
                dataReader.Close();
                cmd.Dispose();
            }

            using (SqlCommand cmd = new SqlCommand($"SELECT * FROM LastOrderDates WHERE unitID=@Id", con))
            {
                cmd.Parameters.AddWithValue("@Id", newUnit.UnitID);
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (!dataReader.Read()) newDate = true;
                dataReader.Close();
                cmd.Dispose();
            }

            if (newOrder)
            {
                using (SqlCommand cmd = new SqlCommand($"INSERT INTO SchedulerOrder (unitID) VALUES (@unitID)", con))
                {
                    cmd.Parameters.AddWithValue("@unitID", newUnit.UnitID);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
            }
            if (newDate)
            {
                using (SqlCommand cmd = new SqlCommand($"INSERT INTO LastOrderDates (unitID) VALUES (@unitID)", con))
                {
                    cmd.Parameters.AddWithValue("@unitID", newUnit.UnitID);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
            }
            con.Close();
        }

        //If method is not used -> Delete in the future
        public void AddToDatabase()
        {
            SqlConnection con = SqlConnectionHandler.GetSqlConnection();
            using (SqlCommand cmd = new SqlCommand($"INSERT INTO SchedulerOrder (cmCurrentID, kitchenCurrentID, bathroomCurrentID, garbageCurrentID, groceriesCurrentID) VALUES (@two, @three, @four, @five, @six) WHERE unitID=@one", con))
            {
                cmd.Parameters.AddWithValue("@one", this.unit.UnitID);
                cmd.Parameters.AddWithValue("@two", this.currentID_common);
                cmd.Parameters.AddWithValue("@three", this.currentID_kitchen);
                cmd.Parameters.AddWithValue("@four", this.currentID_bathroom);
                cmd.Parameters.AddWithValue("@five", this.currentID_garbage);
                cmd.Parameters.AddWithValue("@six", this.currentID_groceries);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            con.Close();
        }

        public void AddToDatabase(string uID, string commonID, string kitchenID, string bathID, string garbID, string grocerID)
        {
            SqlConnection con = SqlConnectionHandler.GetSqlConnection();
            using (SqlCommand cmd = new SqlCommand($"INSERT INTO SchedulerOrder (unitID, cmCurrentID, kitchenCurrentID, bathroomCurrentID, garbageCurrentID, groceriesCurrentID) VALUES (@one, @two, @three, @four, @five, @six)", con))
            {
                cmd.Parameters.AddWithValue("@one", uID);
                cmd.Parameters.AddWithValue("@two", commonID);
                cmd.Parameters.AddWithValue("@three", kitchenID);
                cmd.Parameters.AddWithValue("@four", bathID);
                cmd.Parameters.AddWithValue("@five", garbID);
                cmd.Parameters.AddWithValue("@six", grocerID);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            con.Close();
        }

        public User GetNextUser(EventType type)
        {
            User returnUser = null;
            if (unit.Tenants.Count > 0)
            {
                List<User> users = unit.Tenants;
                int index = -1;
                bool newOrder = false;
                switch (type)
                {
                    case EventType.CommonRoom:
                        if (this.CurrentIDCommon != null) index = users.FindIndex(user => user.UserID == this.CurrentIDCommon);
                        else newOrder = true;
                        break;
                    case EventType.Kitchen:
                        if (this.CurrentIDKitchen != null) index = users.FindIndex(user => user.UserID == this.CurrentIDKitchen);
                        else newOrder = true;
                        break;
                    case EventType.Garbage:
                        if (this.CurrentIDGarbage != null) index = users.FindIndex(user => user.UserID == this.CurrentIDGarbage);
                        else newOrder = true;
                        break;
                    case EventType.Groceries:
                        if (this.CurrentIDGroceries != null) index = users.FindIndex(user => user.UserID == this.CurrentIDGroceries);
                        else newOrder = true;
                        break;
                    case EventType.Bathroom:
                        if (this.CurrentIDBathroom != null) index = users.FindIndex(user => user.UserID == this.CurrentIDBathroom);
                        else newOrder = true;
                        break;
                }
                if(newOrder) returnUser = users[0];
                else
                {
                    if (index >= 0)
                    {
                        if (index == users.Count - 1) returnUser = users[0];
                        else returnUser = users[++index];
                    }
                }
                this.UpdateToDB(type, returnUser);
            }
            return returnUser;
        }

        public User ShowNextUser(EventType type)
        {
            User returnUser = null;
            if (unit.Tenants.Count > 0)
            {
                List<User> users = unit.Tenants;
                int index = -1;
                bool newOrder = false;
                switch (type)
                {
                    case EventType.CommonRoom:
                        if (this.CurrentIDCommon != null) index = users.FindIndex(user => user.UserID == this.CurrentIDCommon);
                        else newOrder = true;
                        break;
                    case EventType.Kitchen:
                        if (this.CurrentIDKitchen != null) index = users.FindIndex(user => user.UserID == this.CurrentIDKitchen);
                        else newOrder = true;
                        break;
                    case EventType.Garbage:
                        if (this.CurrentIDGarbage != null) index = users.FindIndex(user => user.UserID == this.CurrentIDGarbage);
                        else newOrder = true;
                        break;
                    case EventType.Groceries:
                        if (this.CurrentIDGroceries != null) index = users.FindIndex(user => user.UserID == this.CurrentIDGroceries);
                        else newOrder = true;
                        break;
                    case EventType.Bathroom:
                        if (this.CurrentIDBathroom != null) index = users.FindIndex(user => user.UserID == this.CurrentIDBathroom);
                        else newOrder = true;
                        break;
                }
                if (newOrder) returnUser = users[0];
                else
                {
                    if (index >= 0)
                    {
                        if (index == users.Count - 1) returnUser = users[0];
                        else returnUser = users[++index];
                    }
                    else returnUser = users[0];
                }
            }
            return returnUser;
        }

        private void UpdateToDB(EventType type, User targetUser)
        {
            string column = null;
            switch (type)
            {
                case EventType.CommonRoom:
                    this.CurrentIDCommon = targetUser.UserID;
                    column = "cmCurrentID";
                    break;
                case EventType.Kitchen:
                    this.CurrentIDKitchen = targetUser.UserID;
                    column = "kitchenCurrentID";
                    break;
                case EventType.Garbage:
                    this.CurrentIDGarbage = targetUser.UserID;
                    column = "garbageCurrentID";
                    break;
                case EventType.Groceries:
                    this.CurrentIDGroceries = targetUser.UserID;
                    column = "groceriesCurrentID";
                    break;
                case EventType.Bathroom:
                    this.CurrentIDBathroom = targetUser.UserID;
                    column = "bathroomCurrentID";
                    break;
            }
            if(column != null)
            {
                SqlConnection con = SqlConnectionHandler.GetSqlConnection();
                using (SqlCommand cmd = new SqlCommand($"UPDATE SchedulerOrder SET "+column+"=@newValue WHERE unitID=@ID", con))
                {
                    cmd.Parameters.AddWithValue("@newValue", targetUser.UserID);
                    cmd.Parameters.AddWithValue("@ID", this.unit.UnitID);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                con.Close();
            } 
        }

        public DateTime GetLastDate(EventType type)
        {
            DateTime returnDate = SchedulePopup.GetNextWeekday(DateTime.Today, DayOfWeek.Monday);
            string column = null;
            switch (type)
            {
                case EventType.CommonRoom: column = "commonDate"; break;
                case EventType.Kitchen: column = "kitchenDate"; break;
                case EventType.Garbage: column = "garbageDate"; break;
                case EventType.Groceries: column = "groceriesDate"; break;
                case EventType.Bathroom: column = "bathroomDate"; break;
            }
            if (column != null)
            {
                SqlConnection con = SqlConnectionHandler.GetSqlConnection();
                using (SqlCommand cmd = new SqlCommand($"SELECT "+column+" FROM LastOrderDates WHERE unitID=@Id", con))
                {
                    cmd.Parameters.AddWithValue("@ID", this.unit.UnitID);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if(dataReader.Read())
                    {
                        if (!dataReader.IsDBNull(0)) returnDate = dataReader.GetDateTime(0);
                    }
                    dataReader.Close();
                    cmd.Dispose();
                }
                con.Close();
            }
            return returnDate;
        }

        public void SetLastDate(EventType type, DateTime date)
        {
            string column = null;
            switch (type)
            {
                case EventType.CommonRoom: column = "commonDate"; break;
                case EventType.Kitchen: column = "kitchenDate"; break;
                case EventType.Garbage: column = "garbageDate"; break;
                case EventType.Groceries: column = "groceriesDate"; break;
                case EventType.Bathroom: column = "bathroomDate"; break;
            }
            if (column != null)
            {
                SqlConnection con = SqlConnectionHandler.GetSqlConnection();
                using (SqlCommand cmd = new SqlCommand($"UPDATE LastOrderDates SET " + column + "=@newDate WHERE unitID=@ID", con))
                {
                    cmd.Parameters.AddWithValue("@newDate", date);
                    cmd.Parameters.AddWithValue("@ID", this.unit.UnitID);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                con.Close();
            }
        }
    }
}
