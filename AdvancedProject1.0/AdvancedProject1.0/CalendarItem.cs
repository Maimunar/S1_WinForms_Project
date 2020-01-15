﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdvancedProject1._0
{
    public partial class CalendarItem : UserControl
    {
        public CalendarItem()
        {
            InitializeComponent();
            this.todayIndicator.Visible = false;
            this.CalendarItem_SizeChanged(this, EventArgs.Empty);
            this.Disposed += OnDispose;
        }

        private static User loggedInUser = new User(formLogin.userKey);
        private string _date;
        private DateTime _rawdate;
        private string _dayofweek;
        public static int unitID;

        public string Date
        {
            get { return _date; }
            set { _date = value; lblDate.Text = _date; }
        }

        public DateTime RawDate
        {
            get { return _rawdate; }
            set
            { 
                _rawdate = value.Date;
                if (value.DayOfWeek == DayOfWeek.Saturday || value.DayOfWeek == DayOfWeek.Sunday)
                {
                    this.lblDate.ForeColor = SystemColors.HotTrack;
                    this.lblWeekDay.ForeColor = SystemColors.HotTrack;
                    this.eventTablePanel.BackColor = SystemColors.Menu;
                    this.WeekDayPanel.BackColor = SystemColors.Menu;
                    this.calendarDateBackground.BackColor = SystemColors.Menu;
                    this.calendarEventList.BackColor = SystemColors.Menu;
                }
                else
                {
                    this.lblDate.ForeColor = SystemColors.ControlText;
                    this.lblWeekDay.ForeColor = SystemColors.ControlText;
                }
                if (value.Month != DateTime.Today.Month)
                {
                    this.lblWeekDay.ForeColor = SystemColors.GrayText;
                    this.lblDate.ForeColor = SystemColors.GrayText;
                    this.eventTablePanel.BackColor = SystemColors.ScrollBar;
                    this.WeekDayPanel.BackColor = SystemColors.ScrollBar;
                    this.calendarDateBackground.BackColor = SystemColors.ScrollBar;
                    this.calendarEventList.BackColor = SystemColors.ScrollBar;
                }
            }
        }

        public string WeekDay
        {
            get { return _dayofweek; }
            set { _dayofweek = value; lblWeekDay.Text = _dayofweek; }
        }

        public static byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        public static void SystemAddEvent(DateTime date, Color eventColor, Color titleColor, string title, string description, Image img)
        {
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            using (SqlCommand cmd = new SqlCommand($"INSERT INTO CalendarEvents (date, eventColor, eventTitle, titleColor, houseUnit, description, completed, image, createdBy) VALUES (@date, @color, @title, @tcolor, @unit, @desc, @comp, @img, @created)", con))
            {
                cmd.Parameters.AddWithValue("@date", date.Date);
                cmd.Parameters.AddWithValue("@color", ColorTranslator.ToHtml(eventColor));
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@tcolor", ColorTranslator.ToHtml(titleColor));
                cmd.Parameters.AddWithValue("@unit", unitID);
                cmd.Parameters.AddWithValue("@desc", description);
                cmd.Parameters.AddWithValue("@comp", false);
                cmd.Parameters.AddWithValue("@img", ImageToByteArray(img));
                cmd.Parameters.AddWithValue("@created", "system");
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            con.Close();
        }

        public static void AddEventToDB(DateTime date, Color eventColor, Color titleColor, string title, string description, Image img)
        {
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            using (SqlCommand cmd = new SqlCommand($"INSERT INTO CalendarEvents (date, eventColor, eventTitle, titleColor, houseUnit, description, completed, image, createdBy) VALUES (@date, @color, @title, @tcolor, @unit, @desc, @comp, @img, @created)", con))
            {
                cmd.Parameters.AddWithValue("@date", date.Date);
                cmd.Parameters.AddWithValue("@color", ColorTranslator.ToHtml(eventColor));
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@tcolor", ColorTranslator.ToHtml(titleColor));
                cmd.Parameters.AddWithValue("@unit", unitID);
                cmd.Parameters.AddWithValue("@desc", description);
                cmd.Parameters.AddWithValue("@comp", false);
                cmd.Parameters.AddWithValue("@img", ImageToByteArray(img));
                cmd.Parameters.AddWithValue("@created", loggedInUser.GetUserID());
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            con.Close();
        }

        private void AddEventToDB(DateTime date, Color eventColor, Color titleColor, string title, string description)
        {
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            using (SqlCommand cmd = new SqlCommand($"INSERT INTO CalendarEvents (date, eventColor, eventTitle, titleColor, houseUnit, description, completed, createdBy) VALUES (@date, @color, @title, @tcolor, @unit, @desc, @comp, @created)", con))
            {
                cmd.Parameters.AddWithValue("@date", date.Date);
                cmd.Parameters.AddWithValue("@color", ColorTranslator.ToHtml(eventColor));
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@tcolor", ColorTranslator.ToHtml(titleColor));
                cmd.Parameters.AddWithValue("@unit", unitID);
                cmd.Parameters.AddWithValue("@desc", description);
                cmd.Parameters.AddWithValue("@comp", false);
                cmd.Parameters.AddWithValue("@created", loggedInUser.GetUserID());
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            con.Close();
        }

        private void AddEventToDB(DateTime date, Color eventColor, Color titleColor, string title)
        {
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            using (SqlCommand cmd = new SqlCommand($"INSERT INTO CalendarEvents (date, eventColor, eventTitle, titleColor, houseUnit, completed, createdBy) VALUES (@date, @color, @title, @tcolor, @unit, @comp, @created)", con))
            {
                cmd.Parameters.AddWithValue("@date", date.Date);
                cmd.Parameters.AddWithValue("@color", ColorTranslator.ToHtml(eventColor));
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@tcolor", ColorTranslator.ToHtml(titleColor));
                cmd.Parameters.AddWithValue("@unit", unitID);
                cmd.Parameters.AddWithValue("@comp", false);
                cmd.Parameters.AddWithValue("@created", loggedInUser.GetUserID());
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            con.Close();
        }

        private string ReturnCurrentID()
        {
            string return_id;
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            using (SqlCommand cmd = new SqlCommand($"SELECT IDENT_CURRENT('CalendarEvents')", con))
            {
                return_id = (Convert.ToInt32(cmd.ExecuteScalar())+1).ToString();
                cmd.Dispose();
            }
            con.Close();

            return return_id;
        }

        public void AddEvent(string title, Color eventColor, Color textColor, string description, Image img)
        {
            calendarEventItem newEvent = new calendarEventItem(calendarEventList);
            newEvent.Title = title;
            newEvent.Color = eventColor;
            newEvent.TextColor = textColor;
            newEvent.Id = ReturnCurrentID();
            newEvent.Description = description;
            newEvent.Image = img;
            calendarEventList.Controls.Add(newEvent);
            AddEventToDB(this._rawdate, eventColor, textColor, title, description, img);
        }

        public void AddEvent(string title, Color eventColor, Color textColor, string description)
        {
            calendarEventItem newEvent = new calendarEventItem(calendarEventList);
            newEvent.Title = title;
            newEvent.Color = eventColor;
            newEvent.TextColor = textColor;
            newEvent.Id = ReturnCurrentID();
            newEvent.Description = description;
            calendarEventList.Controls.Add(newEvent);
            AddEventToDB(this._rawdate, eventColor, textColor, title, description);
        }

        public void AddEvent(string title, Color eventColor, Color textColor)
        {
            calendarEventItem newEvent = new calendarEventItem(calendarEventList);
            newEvent.Title = title;
            newEvent.Color = eventColor;
            newEvent.TextColor = textColor;
            newEvent.Id = ReturnCurrentID();
            calendarEventList.Controls.Add(newEvent);
            AddEventToDB(this._rawdate, eventColor, textColor, title);
        }

        public void AddEvent(string title, Color eventColor)
        {
            calendarEventItem newEvent = new calendarEventItem(calendarEventList);
            newEvent.Title = title;
            newEvent.Color = eventColor;
            newEvent.Id = ReturnCurrentID();
            MessageBox.Show($"{newEvent.Id}");
            calendarEventList.Controls.Add(newEvent);
            AddEventToDB(this._rawdate, eventColor, Color.Black, title);
        }

        public void HideHeader(bool flag)
        {
            if (flag) calendarDateBackground.Visible = false;
            else calendarDateBackground.Visible = true;
        }
        
        public void IsToday()
        {
            calendarDateBackground.BackColor = Color.BlueViolet;
            eventTablePanel.BackColor = SystemColors.ControlLight;
            WeekDayPanel.BackColor = SystemColors.ControlLight;
            calendarEventList.BackColor = SystemColors.ControlLight;
            todayIndicator.Visible = true;
        }

        public void IsToday(Color barColor)
        {
            calendarDateBackground.BackColor = barColor;
            eventTablePanel.BackColor = SystemColors.ControlLight;
            calendarEventList.BackColor = SystemColors.ControlLight;
            WeekDayPanel.BackColor = SystemColors.ControlLight;
            todayIndicator.Visible = true;
        }

        public void IsToday(Color barColor, Color backColor)
        {
            calendarDateBackground.BackColor = barColor;
            eventTablePanel.BackColor = backColor;
            calendarEventList.BackColor = backColor;
            WeekDayPanel.BackColor = backColor;
            todayIndicator.Visible = true;
        }

        private void calendarEventList_ControlRemoved(object sender, ControlEventArgs e)
        {
            //Resetting scrollbar on control(control) removal
            //eventTablePanel.VerticalScroll.Value = eventTablePanel.VerticalScroll.Maximum;
            //eventTablePanel.PerformLayout();
            //Not working properly = To be fixed()
        }

        public void LoadEvents()
        {
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd;
            SqlDataReader dataReader;

            cmd = new SqlCommand($"SELECT date, eventColor, eventTitle, titleColor, Id, completed, description, image FROM CalendarEvents WHERE date=@samedate AND houseUnit=@unit", con);
            cmd.Parameters.AddWithValue("@samedate", this._rawdate.Date);
            cmd.Parameters.AddWithValue("@unit", unitID);
            dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                while(dataReader.Read())
                {
                    calendarEventItem newEvent = new calendarEventItem(calendarEventList);
                    newEvent.TextColor = ColorTranslator.FromHtml(dataReader.GetString(3));
                    newEvent.Color = ColorTranslator.FromHtml(dataReader.GetString(1));
                    newEvent.Title = dataReader.GetString(2);
                    newEvent.Id = dataReader.GetInt32(4).ToString();
                    newEvent.Completed = dataReader.GetBoolean(5);
                    if (!dataReader.IsDBNull(6)) newEvent.Description = dataReader.GetString(6);
                    if (!dataReader.IsDBNull(7))
                    {
                        byte[] img_bytes = (byte[])dataReader["image"];
                        if (img_bytes == null) newEvent.Image = null;
                        else newEvent.Image = Image.FromStream(new MemoryStream(img_bytes));
                    }
                    calendarEventList.Controls.Add(newEvent);
                }
            }
            con.Close();
        }

        private void CalendarItem_SizeChanged(object sender, EventArgs e)
        {
            //To either be used or removed in the future
        }

        private void OnDispose(object sender, EventArgs e)
        {
            while (calendarEventList.Controls.Count > 0) calendarEventList.Controls[0].Dispose();
        }
    }
}
