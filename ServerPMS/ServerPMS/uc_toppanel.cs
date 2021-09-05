using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using ServerPMS.Properties;

namespace ServerPMS
{
    public enum EventType
    {
        MealTime,  //Время обеда
        Incoming,  //Время заселений
        Outcoming, //Время выселений
        Birthday,  //День рождения
        RepairingTime, //Время ремонта
        CleaningTime, //Время уборок
        Reserved, //Зарезервировано
        DebtTime //Время взыскивать долги
    }


    public partial class uc_toppanel : UserControl
    {

        string uc_ev1_descr = "";
        string uc_ev2_descr = "";
        string uc_ev3_descr = "";

        DateTime dt_ev1 = DateTime.Now;
        DateTime dt_ev2 = DateTime.Now;
        DateTime dt_ev3 = DateTime.Now;

        int id1 = 0;
        int id2 = 0;
        int id3 = 0;

        ToolTip tT = new ToolTip();


        public uc_toppanel()
        {
            InitializeComponent();
        }

        private void bBookingList_Click(object sender, EventArgs e)
        {

            if (Program.bl.isShown)
            {
                Program.bl.WindowState = FormWindowState.Normal;
                Program.bl.Visible = true;
                Program.bl.Focus();
                Program.bl.BringToFront();
            }
            else
            {
                Program.bl.Show();
            }
        }

        private void bReports_Click(object sender, EventArgs e)
        {

        }

        private void bBookingList_Click_1(object sender, EventArgs e)
        {

        }

        private void bReports_Click_1(object sender, EventArgs e)
        {
            if (Program.db.isShown)
            {
                Program.db.WindowState = FormWindowState.Normal;
                Program.db.Visible = true;
                Program.db.Focus();
                Program.bl.ClearRowsClear();
                Program.db.ClearRowsClear();
            }
            else
            {
                Program.bl.ClearRowsClear();
                Program.db.ClearRowsClear();

                Program.db.Show();
            }
        }

        private void bNewBooking_Click(object sender, EventArgs e)
        {
            if (Program.anb.isShown)
            {
                Program.anb.ModeChanger(0);
                Program.anb.WindowState = FormWindowState.Normal;
                Program.anb.Visible = true;
                Program.anb.Focus();
                Program.anb.BringToFront();
            }
            else
            {
                Program.anb.ModeChanger(0);
                Program.anb.Show();
            }
        }

        private void bRoomsList_Click(object sender, EventArgs e)
        {
            if (Program.hl.isShown)
            {
                Program.hl.WindowState = FormWindowState.Normal;
                Program.hl.Visible = true;
                Program.hl.Focus();
                Program.hl.BringToFront();

                Program.bl.ClearRowsClear();
                Program.db.ClearRowsClear();
            }
            else
            {
                Program.bl.ClearRowsClear();
                Program.db.ClearRowsClear();

                Program.hl.Show();
            }
        }

        private void bClients_Click(object sender, EventArgs e)
        {
            //AddEvent(1, EventType.Birthday, DateTime.Parse("22.01.2003 12:32"), DateTime.Now,  "коммент №1");
            //AddEvent(2, EventType.Reserved, DateTime.Parse("28.02.2005 15:32"), DateTime.Now,  "коммент №2");
            //AddEvent(3, EventType.MealTime, DateTime.Parse("20.05.2012 15:32"), DateTime.Now,  "коммент №3");
        }

        public void LoadResource(PictureBox pb, EventType et)
        {
            switch (et)
            {
                case EventType.Birthday:
                    pb.BackgroundImage = Resources.uc_ev_birthday75px;
                    break;
                case EventType.CleaningTime:
                    pb.BackgroundImage = Resources.uc_ev_cleaning75px;
                    break;
                case EventType.DebtTime:
                    pb.BackgroundImage = Resources.uc_ev_debt75px;
                    break;
                case EventType.Incoming:
                    pb.BackgroundImage = Resources.uc_ev_incoming75px;
                    break;
                case EventType.MealTime:
                    pb.BackgroundImage = Resources.uc_ev_mealtime_75px;
                    break;
                case EventType.Outcoming:
                    pb.BackgroundImage = Resources.uc_ev_outcoming75px;
                    break;
                case EventType.RepairingTime:
                    pb.BackgroundImage = Resources.uc_ev_repairing75px;
                    break;
                case EventType.Reserved:
                    pb.BackgroundImage = Resources.uc_ev_reserved75px;
                    break;
            }
        }
        public void FillerWork_Ev1_Add()
        {

        }

        private void bSettings_Click(object sender, EventArgs e)
        {

        }

        private void bNewBooking_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void bNewBooking_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void picEv1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void picEv1_MouseHover(object sender, EventArgs e)
        {
            if (uc_ev1_descr != "") tT.SetToolTip(picEv1, uc_ev1_descr);
        }

        private void picEv2_MouseHover(object sender, EventArgs e)
        {
            if (uc_ev2_descr != "") tT.SetToolTip(picEv2, uc_ev2_descr);
        }

        private void picEv3_MouseHover(object sender, EventArgs e)
        {
            if (uc_ev3_descr != "") tT.SetToolTip(picEv3, uc_ev3_descr);
        }

        public void tmrEvHandler()
        {
            if (uc_ev1_descr != "")
            {
                picEv1.Visible = true;
                txtEvHdr1.Visible = true;
                NearestText.Visible = true;
                txtEvWhen1.Visible = true;
                Remaning1Text.Visible = true;
                txtRemaning1.Visible = true;
            }
            else
            {
                picEv1.Visible = false;
                txtEvHdr1.Visible = false;
                NearestText.Visible = false;
                txtEvWhen1.Visible = false;
                Remaning1Text.Visible = false;
                txtRemaning1.Visible = false;
            }

            if (uc_ev2_descr != "")
            {
                picEv2.Visible = true;
                txtEvHdr2.Visible = true;
                LaterText.Visible = true;
                txtEvWhen2.Visible = true;
                Remaning2Text.Visible = true;
                txtRemaning2.Visible = true;
            }
            else
            {
                picEv2.Visible = false;
                txtEvHdr2.Visible = false;
                LaterText.Visible = false;
                txtEvWhen2.Visible = false;
                Remaning2Text.Visible = false;
                txtRemaning2.Visible = false;
            }

            if (uc_ev3_descr != "")
            {
                picEv3.Visible = true;
                txtEvHdr3.Visible = true;
                txtEvWhen3.Visible = true;
                Remaning3Text.Visible = true;
                txtRemaning3.Visible = true;
            }
            else
            {
                picEv3.Visible = false;
                txtEvHdr3.Visible = false;
                txtEvWhen3.Visible = false;
                Remaning3Text.Visible = false;
                txtRemaning3.Visible = false;
            }


        }

        private void tWork_Tick(object sender, EventArgs e)
        {
            tmrEvHandler();
            if (id1 != 0)
            {
                txtRemaning1.Text = RemaningToStringConverter(dt_ev1, DateTime.Now);
            }
            if (id2 != 0)
            {
                txtRemaning2.Text = RemaningToStringConverter(dt_ev2, DateTime.Now);
            }
            if (id3 != 0)
            {
                txtRemaning3.Text = RemaningToStringConverter(dt_ev3, DateTime.Now);
            }
        }

        public string EventTypeToStringConverter(EventType evtype)
        {
            switch (evtype)
            {
                case EventType.MealTime:
                    return "Приём пищи";
                    break;
                case EventType.Incoming:
                    return "Заезд";
                          break;
                case EventType.Outcoming:
                    return "Выезд";
                          break;
                case EventType.Birthday:
                    return "День рождения";
                          break;
                case EventType.RepairingTime:
                    return "Ремонт номеров";
                          break;
                case EventType.CleaningTime:
                    return "Уборка";
                          break;
                case EventType.Reserved:
                    return "Резерв";
                          break;
                case EventType.DebtTime:
                    return "Выплата долга";
                          break;
            }
            return "";
        }

        public string DateTimeToStringConverter(DateTime in_date)
        {
            return txtEvWhen1.Text = in_date.ToString("MM.dd.yyyy HH:mm");
        }

        public string RemaningToStringConverter(DateTime dt_st, DateTime dt_end)
        {
            DateTime dt = dt_end;
            TimeSpan diff_rem = dt.Subtract(dt_st);
            return diff_rem.ToString("h'h 'm'm 's's'");
        }

        public int AddEvent(int id, EventType ev_type, DateTime ev_when, DateTime ev_when_end, string comment)
        {
            if (uc_ev1_descr == "")
            {
                uc_ev1_descr = comment;
                id1 = id;
                txtEvHdr1.Text = EventTypeToStringConverter(ev_type);
                txtEvWhen1.Text = DateTimeToStringConverter(ev_when);
                dt_ev1 = ev_when;
                txtRemaning1.Text = RemaningToStringConverter(ev_when, ev_when_end);
                LoadResource(picEv1, ev_type);
                return 1;
            }
            else if (uc_ev2_descr == "")
            {
                uc_ev2_descr = comment;
                id2 = id;
                txtEvHdr2.Text = EventTypeToStringConverter(ev_type);
                txtEvWhen2.Text = DateTimeToStringConverter(ev_when);
                dt_ev2 = ev_when;
                txtRemaning2.Text = RemaningToStringConverter(ev_when, ev_when_end);
                LoadResource(picEv2, ev_type);
                return 2;
            }
            else if (uc_ev3_descr == "")
            {
                uc_ev3_descr = comment;
                id3 = id;
                txtEvHdr3.Text = EventTypeToStringConverter(ev_type);
                txtEvWhen3.Text = DateTimeToStringConverter(ev_when);
                dt_ev3 = ev_when;
                txtRemaning3.Text = RemaningToStringConverter(ev_when, ev_when_end);
                LoadResource(picEv3, ev_type);
                return 3;
            }
            return 0;
        }

    }
}
