using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerPMS
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            loading_lock = true;
            InitializeComponent();
        }

        bool gen_lock = false;
        bool loading_lock = true;
        List<string> Days = new List<string>();

        Color ColorValsEmptyBackColor = Color.White;
        Color ColorValsEmptyForeColor = Color.Black;
        Color ColorValsIncomingBackColor = Color.DeepPink;
        Color ColorValsIncomingForeColor = Color.White;

        Color ColorValsLivingBackColor = Color.DarkGreen;
        Color ColorValsLivingForeColor = Color.White;
        Color ColorValsOutcomingBackColor = Color.Pink;
        Color ColorValsOutcomingForeColor = Color.White;

        Color ColorValsOverbookingBackColor = Color.Black;
        Color ColorValsOverbookingForeColor = Color.White;
        Color ColorValsRestorationBackColor = Color.OrangeRed;
        Color ColorValsRestorationForeColor = Color.White;

        Color ColorValsUnusedBackColor = Color.Gray;
        Color ColorValsUnusedForeColor = Color.Black;

        Color ColorValsTodayMarker = Color.DarkRed;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public enum ColorVals
        {
            Empty,
            Incoming,
            Living,
            Outcoming,
            Overbooking,
            Restoration,
            Unused
        }

        #region BookingListDatesWizard
        public void BookingListDatesInitializator()
        {
            int hmanyd = 0;

            int dy_begin = Int16.Parse(Days[0]);
            int dy_end = Int16.Parse(Days[Days.Count - 1]);

            int dgvbr = 0;

            for (int i = 0; i < Program.bl.dgvBooking.Rows.Count; i++)
            {
                if (Program.bl.dgvBooking["dbblIDRoom", i].Value != null)
                {

                    for (int z = 0; z < dgv.Rows.Count; z++)
                    {
                        if (dgv["nullClmn", z].Value != null)
                        {
                            if (dgv["nullClmn", z].Value.ToString() == Program.bl.dgvBooking["dbblIDRoom", i].Value.ToString())
                            {
                                dgvbr = z;
                                break;
                            }

                        }

                    }

                    DateTime dy_i = DateTime.Parse(Program.bl.dgvBooking["dbblDateIncoming", i].Value.ToString());
                    DateTime dy_o = DateTime.Parse(Program.bl.dgvBooking["ddblDateOutComing", i].Value.ToString());

                    switch (cmbVisPeriod.SelectedIndex)
                    {
                        case 0:
                            hmanyd = 30;
                            break;
                        case 1:
                            hmanyd = 14;
                            break;
                        case 2:
                            hmanyd = 7;
                            break;
                        case 4:
                            hmanyd = 60;
                            break;
                        case 5:
                            hmanyd = 90;
                            break;
                    }

                    //  if (dy_i.DayOfYear >= dy_begin && dy_o.DayOfYear <= dy_end)
                    //  {
                    for (int a = 1; a <= hmanyd; a++)
                    {
                        if (dgv["col" + a, dgvbr].Value != null)
                        {
                            if (dgv["col" + a, dgvbr].Value.ToString() != "")
                            {
                                int day_y = Int16.Parse(dgv["col" + a, 3].Value.ToString());
                                if (day_y == dy_i.DayOfYear)
                                {
                                    if (getOverbookingStatus("col" + a, dgvbr))
                                    {
                                        painterCellsRooms("col" + a, dgvbr, ColorVals.Overbooking);
                                    }
                                    else
                                    {
                                        painterCellsRooms("col" + a, dgvbr, ColorVals.Incoming);
                                    }

                                }
                                else if (day_y == dy_o.DayOfYear)
                                {
                                    if (getOverbookingStatus("col" + a, dgvbr))
                                    {
                                        painterCellsRooms("col" + a, dgvbr, ColorVals.Overbooking);
                                    }
                                    else
                                    {
                                        painterCellsRooms("col" + a, dgvbr, ColorVals.Outcoming);
                                    }
                                }
                                else if (day_y > dy_i.DayOfYear && day_y < dy_o.DayOfYear)
                                {
                                    if (getOverbookingStatus("col" + a, dgvbr))
                                    {
                                        painterCellsRooms("col" + a, dgvbr, ColorVals.Overbooking);
                                    }
                                    else
                                    {
                                        painterCellsRooms("col" + a, dgvbr, ColorVals.Living);
                                    }
                                }
                                //else
                                //{
                                //    //painterCellsRooms("col" + a, dgvbr, ColorVals.Empty);
                                //}
                            }
                        }
                    }
                    //}
                    //else if (dy_i.DayOfYear < dy_begin && dy_o.DayOfYear <)
                }
            }
        }

        #region DDM
        public void DDM_Filling_Info(string ddm_name, string ddm_name_num_adults, DateTime ddm_incoming, DateTime ddm_outcoming, int ddm_number_of_days, string ddm_status, int ddm_adultsnum, int ddm_paying, int ddm_debt, string ddm_source, string ddm_meal, string ddm_comment, DateTime ddm_dateofcreating, string ddmid)
        {
            lkDDMName.Text = ddm_name + " + " + ddm_name_num_adults;
            txtDDMInComing.Text = ddm_incoming.ToString();
            txtDDMOutComing.Text = ddm_outcoming.ToString();
            txtDDMNumberOfDays.Text = "суток: " + ddm_name_num_adults;
            txtDDMStatus.Text = "статус: " + ddm_status;
            txtDDMAdultsNum.Text = "мест: " + ddm_adultsnum;
            txtDDMPaying.Text = "оплачено: " + ddm_paying + " руб";

            txtDDMDebt.Text = "долг: " + ddm_debt + " руб";
            txtDDMSource.Text = "источник: " + ddm_source;
            txtDDMMeal.Text = "тип питания: " + ddm_meal;
            txtDDMComment.Text = "комментарий: " + ddm_comment;
            txtDDMDateOfCreating.Text = "дата создания: " + ddm_dateofcreating.Date.ToString();
            txtDDMID.Text = "ID брони: " + ddmid;
        }

        public void DDM_Relocate(int x, int y)
        {
            pnlDDM.Visible = false;
            pnlDDM.Location = new Point(x, y);
            pnlDDM.Visible = true;
        }

        public void ODDM_Relocate(int x, int y)
        {
            pnlOverbooking.Visible = false;
            pnlOverbooking.Location = new Point(x, y);
            pnlOverbooking.Visible = true;
        }

        public void ODDM_Detector(int c, int r)
        {
            string id = "";

            if (dgv["nullClmn", r].Value != null)
            {
                if (dgv["nullClmn", r].Value.ToString() != "")
                {
                    id = dgv["nullClmn", r].Value.ToString();
                }
            }

            int dy_d = Int16.Parse(dgv[c, 3].Value.ToString());


            if (ODDM_byDatabaseSearcher(id, dy_d))
            {
                ODDM_LoadBooking(id);
            }
        }

        public void ODDM_LoadBooking(string identificator)
        {
            Program.anb.Starter();
            foreach (DataGridViewRow dgvr in Program.bl.dgvBooking.Rows)
            {
                if (Program.bl.dgvBooking["dbblIDRoom", dgvr.Index].Value != null)
                {
                    if (Program.bl.dgvBooking["dbblIDRoom", dgvr.Index].Value.ToString() != "")
                    {
                        if (Program.bl.dgvBooking["dbblIDRoom", dgvr.Index].Value.ToString() == identificator.ToString())
                        {
                            lkDDMName.Text = Program.bl.dgvBooking["dbblName", dgvr.Index].Value.ToString() + " + " + Program.bl.dgvBooking["dbblNumPlaces", dgvr.Index].Value.ToString();

                            DateTime c_incoming = DateTime.Parse(Program.bl.dgvBooking["dbblDateIncoming", dgvr.Index].Value.ToString());
                            DateTime c_outcoming = DateTime.Parse(Program.bl.dgvBooking["ddblDateOutComing", dgvr.Index].Value.ToString());

                            string cout_incoming = c_incoming.ToString("dd-MM-yyyy") + " " + Program.bl.dgvBooking["dbblCheckInTime", dgvr.Index].Value.ToString();
                            string cout_outcoming = c_outcoming.ToString("dd-MM-yyyy") + " " + Program.bl.dgvBooking["dbblCheckOutTime", dgvr.Index].Value.ToString();

                            txtDDMInComing.Text = "заезд: " + cout_incoming;
                            txtDDMOutComing.Text = "выезд: " + cout_outcoming;

                            int nod_calc1 = DateTime.Parse(Program.bl.dgvBooking["dbblDateIncoming", dgvr.Index].Value.ToString()).DayOfYear;
                            int nod_calc2 = DateTime.Parse(Program.bl.dgvBooking["ddblDateOutComing", dgvr.Index].Value.ToString()).DayOfYear;

                            nod_calc2 -= nod_calc1;

                            txtDDMNumberOfDays.Text = "суток: " + nod_calc2.ToString();
                            txtDDMStatus.Text = Program.bl.ViewConverterBookingType(Program.bl.dgvBooking["dbblBookingStatus", dgvr.Index].Value.ToString());
                            txtDDMAdultsNum.Text = "мест: " + Program.bl.dgvBooking["dbblAdultPlaces", dgvr.Index].Value.ToString();
                            txtDDMPaying.Text = "оплачено: " + Program.bl.dgvBooking["dbblPayed", dgvr.Index].Value.ToString() + " руб";
                            txtDDMDebt.Text = "долг: " + Program.bl.dgvBooking["dbblDept", dgvr.Index].Value.ToString() + " руб";
                            txtDDMSource.Text = "источник: " + Program.bl.ViewConverterBookingSource(Program.bl.dgvBooking["dbblBookingSource", dgvr.Index].Value.ToString());
                            txtDDMMeal.Text = "тип питания: " + Program.bl.ViewConverterMealType(Program.bl.dgvBooking["dbblMealType", dgvr.Index].Value.ToString());
                            txtDDMComment.Text = Program.bl.dgvBooking["dbblComment", dgvr.Index].Value.ToString();
                            txtDDMDateOfCreating.Text = "дата создания: " + DateTime.Parse(Program.bl.dgvBooking["dbblCreatingDate", dgvr.Index].Value.ToString()).ToString("dd-MM-yyyy");
                            txtDDMID.Text = "ID брони:" + Program.bl.ViewConveterBookingID( Program.bl.dgvBooking["dbblID", dgvr.Index].Value.ToString());

                            Program.anb.txtID.Text = "ID бронирования: " + Program.bl.ViewConveterBookingID(Program.bl.dgvBooking["dbblID", dgvr.Index].Value.ToString());
                            
                            Program.anb.cmbRoomDatabaseSelector.SelectedIndex = Program.bl.ComboBoxToInt(Program.anb.cmbRoomDatabaseSelector, Program.bl.dgvBooking["dbblIDRoom", dgvr.Index].Value.ToString());

                            Program.anb.txtname.Text = Program.bl.dgvBooking["dbblName", dgvr.Index].Value.ToString();
                            Program.anb.dtpCheckin.Value = c_incoming;
                            Program.anb.nudHour.Value = Program.bl.HourParser(Program.bl.dgvBooking["dbblCheckInTime", dgvr.Index].Value.ToString());
                            Program.anb.nudMinute.Value = Program.bl.MinuteParser(Program.bl.dgvBooking["dbblCheckInTime", dgvr.Index].Value.ToString());
                            Program.anb.dtpOutcome.Value = c_outcoming;
                            Program.anb.nudOutcomeHour.Value = Program.bl.HourParser(Program.bl.dgvBooking["dbblCheckOutTime", dgvr.Index].Value.ToString()); ;
                            Program.anb.nudOutcomeMinute.Value = Program.bl.MinuteParser(Program.bl.dgvBooking["dbblCheckOutTime", dgvr.Index].Value.ToString()); ;
                            Program.anb.cmbBookingStatus.SelectedIndex = Program.bl.ComboBoxToInt(Program.anb.cmbBookingStatus, Program.bl.dgvBooking["dbblBookingStatus", dgvr.Index].Value.ToString());

                            Program.anb.nudAdults.Value = Int16.Parse(Program.bl.dgvBooking["dbblAdultPlaces", dgvr.Index].Value.ToString());

                            int n_a = Int16.Parse(Program.bl.dgvBooking["dbblAdultPlaces", dgvr.Index].Value.ToString());
                            int n_t = Int16.Parse(Program.bl.dgvBooking["dbblNumPlaces", dgvr.Index].Value.ToString());
                            int n_c = 0;

                            n_c = n_t - n_a;

                            Program.anb.nudChildren.Value = n_c;
                            Program.anb.cmbBookingSource.SelectedIndex = Program.bl.ComboBoxToInt(Program.anb.cmbBookingSource, Program.bl.dgvBooking["dbblBookingSource", dgvr.Index].Value.ToString());

                            Program.anb.txtToday.Text = "Дата создания: " + DateTime.Parse(Program.bl.dgvBooking["dbblCreatingDate", dgvr.Index].Value.ToString()).ToString("dd.MM.yyyy");

                            Program.anb.txtCodeU1.Text = Program.bl.dgvBooking["dbblUnitCodeU1", dgvr.Index].Value.ToString();
                            Program.anb.txtCodeU2.Text = Program.bl.dgvBooking["dbblUnitCodeU2", dgvr.Index].Value.ToString();
                            Program.anb.txtWhomItWasGiven.Text = Program.bl.dgvBooking["dbblPassportWhomitwasgiven", dgvr.Index].Value.ToString(); ;
                            Program.anb.txtSN.Text = Program.bl.dgvBooking["dbblPassportSeries", dgvr.Index].Value.ToString();
                            Program.anb.txtNum.Text = Program.bl.dgvBooking["dbblPassportNumber", dgvr.Index].Value.ToString(); ;
                            Program.anb.dtpDateOfOutcome.Value = DateTime.Parse(Program.bl.dgvBooking["dbblPassportOutcomeDate", dgvr.Index].Value.ToString());
                            Program.anb.dtpBirthday.Value = DateTime.Parse(Program.bl.dgvBooking["dbblBirthday", dgvr.Index].Value.ToString());

                            Program.anb.rtfComment.Text = Program.bl.dgvBooking["dbblComment", dgvr.Index].Value.ToString();
                            Program.anb.cmbMealType.SelectedIndex = Program.bl.ComboBoxToInt(Program.anb.cmbMealType, Program.bl.dgvBooking["dbblMealType", dgvr.Index].Value.ToString());
                            Program.anb.txtmoney.Text = Program.bl.dgvBooking["dbblPayingCost", dgvr.Index].Value.ToString();
                            Program.anb.txtPayed.Text = Program.bl.dgvBooking["dbblPayed", dgvr.Index].Value.ToString();

                        }
                    }
                }
            }
            return;
        }

        public bool ODDM_byDatabaseSearcher(string identificator, int dayofyear_d)
        {
            foreach (DataGridViewRow dgvr in Program.bl.dgvBooking.Rows)
            {
                if (Program.bl.dgvBooking["dbblIDRoom", dgvr.Index].Value != null)
                {
                    if (Program.bl.dgvBooking["dbblIDRoom", dgvr.Index].Value.ToString() != "")
                    {
                        if (Program.bl.dgvBooking["dbblIDRoom", dgvr.Index].Value.ToString() == identificator.ToString())
                        {
                            DateTime dt_dbbl_incoming = DateTime.Parse(Program.bl.dgvBooking["dbblDateIncoming", dgvr.Index].Value.ToString());
                            DateTime dt_dbbl_outcoming = DateTime.Parse(Program.bl.dgvBooking["ddblDateOutComing", dgvr.Index].Value.ToString());
                            //    DateTime dt_dbbl_cur = DateTime.Parse(identificator);

                            int dy_dbbl_incoming = dt_dbbl_incoming.DayOfYear;
                            int dy_dbbl_outcoming = dt_dbbl_outcoming.DayOfYear;
                            int dy_dbbl_cur = dayofyear_d;

                            if (dy_dbbl_cur >= dy_dbbl_incoming && dy_dbbl_cur <= dy_dbbl_outcoming)
                            {
                                return true;
                            }

                        }
                    }
                }
            }
            return false;
        }

        #endregion 
        public bool getOverbookingStatus(string colname, int row_num)
        {
            Color crnt_color = dgv[colname, row_num].Style.BackColor;
            if (crnt_color == ColorValsEmptyBackColor)
            {
                return false;
            }
            else
            {
                return true;
            }
            return false;
        }

        #endregion
        public string getIDRowByNames(string searching_name)
        {
            int num = 0;
            for (int i = 0; i < Program.db.dgvDatabase.Rows.Count; i++)
            {
                if (Program.db.dgvDatabase["databaseNames", i].Value != null)
                {
                    if (Program.db.dgvDatabase["databaseNames", i].Value.ToString() == searching_name)
                    {
                        return Program.db.dgvDatabase["databaseID", i].Value.ToString();
                    }
                }
            }
            return "";
        }

        public void painterWizardCells()
        {
            int row_v = 0;
            int row_grbn = -1;
            int hmanyd = 0;

            for (int p = 0; p < dgv.Rows.Count; p++)
            {
                if (dgv["firstClmn", p].Value != null)
                {
                    if (dgv["firstClmn", p].Value.ToString() != "")
                    {
                        row_grbn = getRowsByNames(dgv["firstClmn", p].Value.ToString());
                        if (row_grbn != 0)
                        {
                            switch (cmbVisPeriod.SelectedIndex)
                            {
                                case 0:
                                    hmanyd = 30;
                                    break;
                                case 1:
                                    hmanyd = 14;
                                    break;
                                case 2:
                                    hmanyd = 7;
                                    break;
                                case 4:
                                    hmanyd = 60;
                                    break;
                                case 5:
                                    hmanyd = 90;
                                    break;
                            }

                            for (int a = 0; a < hmanyd; a++)
                            {
                                if (dgv["col" + a, row_grbn].Value != null)
                                {
                                    if (dgv["col" + a, row_grbn].Value.ToString() != "")
                                    {
                                        //painterAnalyzer(dgv["col" + a, row_grbn].Value.ToString(),,hmanyd);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public int getrowbyid(string b_id)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {

            }
            return 0;
        }

        public int getRowsByNames(string grbnms)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (dgv["firstClmn", i].Value != null)
                {
                    if (dgv["firstClmn", i].Value.ToString() == grbnms)
                    {
                        return i;
                    }
                }
            }
            return 0;
        }


        public void painterAnalyzer(string in_data_dy, string booking_id, int cols_count)
        {
            //DateTime d_inc = DateTime.Parse(Program.db.dgvDatabase["dbblDateIncoming",getrowbyid(booking_id)].Value.ToString());
            //DateTime d_outc = DateTime.Parse(Program.db.dgvDatabase["dbblDateOutComing", getrowbyid(booking_id)].Value.ToString());

            //int d_inc_dy = d_inc.DayOfYear;
            //int d_outc_dy = d_outc.DayOfYear;
            //int int_data_dy = Int16.Parse(in_data_dy);

            //if (d_inc_dy == int_data_dy)
            //{
            //    for (int i = 0; i< cols_count;i++)
            //    {
            //        painterCellsRooms(i, getrowbyid(booking_id), ColorVals.Incoming);
            //    }
            //}
            //else if (d_outc_dy == int_data_dy)
            //{
            //    for (int i = 0; i < cols_count; i++)
            //    {
            //        painterCellsRooms(i, getrowbyid(booking_id), ColorVals.Outcoming);
            //    }

            //}
            //else if (int_data_dy > d_inc_dy && int_data_dy < d_outc_dy )
            //{
            //    for (int i = 0; i < cols_count; i++)
            //    {
            //        painterCellsRooms(i, getrowbyid(booking_id), ColorVals.Living);
            //    }
            //}
            //else
            //{
            //    for (int i = 0; i < cols_count; i++)
            //    {
            //        painterCellsRooms(i, getrowbyid(booking_id), ColorVals.Empty);
            //    }
            //}
            ////Program.db.dgvDatabase[]
        }

        public void painterCellsRooms(string c, int r, ColorVals cv)
        {
            switch (cv)
            {
                case ColorVals.Empty:
                    //dgv[c, r].Style.BackColor = Color.White;
                    //dgv[c, r].Style.ForeColor = Color.Black;

                    dgv[c, r].Style.BackColor = ColorValsEmptyBackColor;
                    dgv[c, r].Style.ForeColor = ColorValsEmptyForeColor;
                    break;
                case ColorVals.Incoming:
                    //dgv[c, r].Style.BackColor = Color.DeepPink;
                    //dgv[c, r].Style.ForeColor = Color.White;

                    dgv[c, r].Style.BackColor = ColorValsIncomingBackColor;
                    dgv[c, r].Style.ForeColor = ColorValsIncomingForeColor;
                    break;
                case ColorVals.Living:
                    //dgv[c, r].Style.BackColor = Color.DarkGreen;
                    //dgv[c, r].Style.ForeColor = Color.White;

                    dgv[c, r].Style.BackColor = ColorValsLivingBackColor;
                    dgv[c, r].Style.ForeColor = ColorValsLivingForeColor;
                    break;
                case ColorVals.Outcoming:
                    //dgv[c, r].Style.BackColor = Color.Pink;
                    //dgv[c, r].Style.ForeColor = Color.White;

                    dgv[c, r].Style.BackColor = ColorValsOutcomingBackColor;
                    dgv[c, r].Style.ForeColor = ColorValsOutcomingForeColor;
                    break;
                case ColorVals.Overbooking:
                    //dgv[c, r].Style.BackColor = Color.Black;
                    //dgv[c, r].Style.ForeColor = Color.White;

                    dgv[c, r].Style.BackColor = ColorValsOverbookingBackColor;
                    dgv[c, r].Style.ForeColor = ColorValsOverbookingForeColor;
                    break;
                case ColorVals.Restoration:
                    //dgv[c, r].Style.BackColor = Color.OrangeRed;
                    //dgv[c, r].Style.ForeColor = Color.White;

                    dgv[c, r].Style.BackColor = ColorValsRestorationBackColor;
                    dgv[c, r].Style.ForeColor = ColorValsRestorationForeColor;
                    break;
                case ColorVals.Unused:
                    //dgv[c, r].Style.BackColor = Color.Gray;
                    //dgv[c, r].Style.ForeColor = Color.Black;

                    dgv[c, r].Style.BackColor = ColorValsEmptyBackColor;
                    dgv[c, r].Style.ForeColor = ColorValsEmptyForeColor;
                    break;
            }
        }

        public void locateToday()
        {
            foreach (DataGridViewColumn dgvc in dgv.Columns)
            {
                if (dgvc.DataGridView.Rows[3].Cells[dgvc.Index].Value != null)
                {
                    if (dgvc.DataGridView.Rows[3].Cells[dgvc.Index].Value.ToString() == DateTime.Today.DayOfYear.ToString())
                    {
                        foreach (DataGridViewRow dgvr in dgv.Rows)
                        {
                            dgv[dgvc.Index, dgvr.Index].Style.BackColor = Color.DarkRed;
                            dgv[dgvc.Index, dgvr.Index].Style.ForeColor = Color.White;
                        }

                    }

                }
            }
        }

        //public void locateToday()
        //{
        //    foreach (DataGridViewColumn dgvc in dgv.Columns)
        //    {
        //        if (dgvc.DataGridView.Rows[3].Cells[dgvc.Index].Value != null)
        //        {
        //            if (dgvc.DataGridView.Rows[3].Cells[dgvc.Index].Value.ToString() == DateTime.Today.DayOfYear.ToString())
        //            {

        //            }
        //            else
        //            {

        //            }
        //        }
        //    }
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv.AutoGenerateColumns = false;

            Days.Add("null");

            ColNullNamer();

            cmbVisPeriod.SelectedIndex = 0;
            dtp.Value = dtp.Value.AddDays(1);
            dtp.Value = dtp.Value.AddDays(-1);

            Program.db.Database_LoadXSD();
            Program.bl.BookingList_LoadXSD();
            Program.db.ClearRowsClear();
            Program.bl.ClearRowsClear();
            //dgv.Columns["col1"].DefaultCellStyle.ForeColor = Color.Red;

            OneDayPreprocessor_Birthdays();
            OneDayPreprocessor_Incomings();
            OneDayPreprocessor_Outcomings();
            OneDayPreprocessor_AllPlaces();
            OneDayPreprocessor_AllRooms();

            int occup = 0;
            int non_occup = 0;
            int dlive = 0;

            List<string> dt_from = Program.bl.getAllCheckInDates();
            List<string> dt_to = Program.bl.getAllCheckOutDates();

            for (int i = 0; i < dt_from.Count; i++)
            {
                if (isDateInBounds(DateTime.Parse(dt_from[i]).Date, DateTime.Parse(dt_to[i]).Date, DateTime.Today.Date, false))
                {
                    dlive++;
                }
                if (isDateInBounds(DateTime.Parse(dt_from[i]).Date, DateTime.Parse(dt_to[i]).Date, DateTime.Today.Date, true))
                {
                    occup++;
                }
                non_occup++;
            }

            Set_1DayLiving(dlive);
            Set_1DayOccupatedRooms(occup);
            Set_1DayAvaliableRooms(non_occup - occup);

            double occupation = 1;

            occupation = (double)occup / (non_occup) / 1.0;

            Set_1DayOccupation((int)(occupation * 100));

            Calendar_LoadAllHotel();
            loading_lock = false;
          

            SetAllTableEmpty();

            dtp.Value.AddDays(1);
            dtp.Value.AddDays(-1);
            cmbVisPeriod.SelectedIndex = 1;
            cmbVisPeriod.SelectedIndex = 0;
            BookingListDatesInitializator();
        }

        public void Calendar_LoadAllHotel()
        {
            int cnt = 0;
            for (int i = 0; i < Program.db.dgvDatabase.Rows.Count; i++)
            {
                if (Program.db.dgvDatabase.Rows[i].Cells[0].Value != null)
                {
                    cnt++;
                }
            }

            for (int i = 0; i < cnt; i++)
            {
                if (Program.db.dgvDatabase.Rows[i].Cells[0].Value != null)
                {
                    dgv.Rows.Add(Program.db.dgvDatabase.Rows[i].Cells[0].Value.ToString(), Program.db.dgvDatabase.Rows[i].Cells[1].Value.ToString());
                    //dgv.Rows[Program.db.dgvDatabase.Rows.Count].Cells["lastClmn"].Value = Program.db.dgvDatabase.Rows[i].Cells[0].Value.ToString();
                }
            }
        }

        public int GetAll1Day_Exchange()
        {
            List<string> dt_from = Program.bl.getAllCheckInDates();
            List<string> dt_to = Program.bl.getAllCheckOutDates();

            List<string> str;

            int num = 0;

            for (int i = 0; i < dt_from.Count; i++)
            {

            }
            return num;
        }

        public bool isDateInBounds(DateTime firstRangeDate, DateTime secondRangeDate, DateTime checkingTime, bool include_borders)
        {
            if (include_borders)
            {
                return checkingTime >= firstRangeDate && checkingTime <= secondRangeDate;
            }
            else
            {
                return checkingTime > firstRangeDate && checkingTime < secondRangeDate;
            }
        }

        public void RowsExtender()
        {
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                for (int j = 0; j < dgv.Rows.Count; j++)
                {
                    if (j > 4 && i > 1)
                    {
                        dgv[i, j].Value = dgv[i, 2].Value;
                    }
                }
            }
        }

        public void GenerateCalendar()
        {
            int clmn_count = ColVisNum();

            Days.Clear();
            foreach (DataGridViewRow dgvc in dgv.Rows)
            {
                dgvc.DataGridView.Rows.Clear();
            }
            for (int i = 0; i < 5; i++)
            {
                dgv.Rows.Add();
            }
            DateTime dt_now = dtp.Value;
            DateTime cur_month = DateTime.MinValue;

            int t_a = dgv.Rows.Count;
            int t_c = Program.db.DatabaseRowsCounter();

            for (int j = 0; j < Program.db.DatabaseRowsCounter(); j++)
            {
                dgv.Rows.Add();
                dgv["firstClmn", j + 5].Value = Program.db.dgvDatabase[1, j].Value;
                dgv["nullClmn", j + 5].Value = Program.db.dgvDatabase[0, j].Value;
            }

            for (int i = 0; i < ColVisNum(); i++)
            {
                if (cur_month.Month != dt_now.Month) dgv["col" + (i + 1).ToString(), 0].Value = VisualAdapterMonth(dt_now.Month.ToString()) + " " + dt_now.Year;
                cur_month = dt_now;
                // if (dt_now.Day.ToString() == "1") dgv["col" + (i + 1).ToString(), 0].Value = VisualAdapterMonth(dt_now.Month.ToString()) + " " + dt_now.Year;
                dgv["col" + (i + 1).ToString(), 1].Value = VisualAdapterWeek(dt_now.DayOfWeek.ToString());
                dgv["col" + (i + 1).ToString(), 2].Value = dt_now.Day.ToString();
                dgv["col" + (i + 1).ToString(), 3].Value = dt_now.DayOfYear.ToString();
                dt_now = dt_now.AddDays(1);
            }
            RowsExtender();

            for (int i = 0; i < 3; i++)
            {
                dgv.Rows.Add();
            }

            dt_now = dtp.Value;
            cur_month = DateTime.MinValue;

            for (int i = 0; i < ColVisNum(); i++)
            {
                if (cur_month.Month != dt_now.Month) dgv["col" + (i + 1).ToString(), 0].Value = VisualAdapterMonth(dt_now.Month.ToString()) + " " + dt_now.Year;
                cur_month = dt_now;
                // if (dt_now.Day.ToString() == "1") dgv["col" + (i + 1).ToString(), 0].Value = VisualAdapterMonth(dt_now.Month.ToString()) + " " + dt_now.Year;
                dgv["col" + (i + 1).ToString(), dgv.Rows.Count - 1].Value = VisualAdapterWeek(dt_now.DayOfWeek.ToString());
                dgv["col" + (i + 1).ToString(), dgv.Rows.Count - 2].Value = dt_now.Day.ToString();
                dgv["col" + (i + 1).ToString(), dgv.Rows.Count - 3].Value = dt_now.DayOfYear.ToString();
                Days.Add(dt_now.DayOfYear.ToString());
                dt_now = dt_now.AddDays(1);
            }
            locateToday();
        }

        /* Backup
         * 
         *   public void GenerateCalendar()
         {
             int clmn_count = ColVisNum();
             foreach (DataGridViewRow dgvc in dgv.Rows)
             {
                 dgvc.DataGridView.Rows.Clear();
             }

             for (int i = 0; i < 10; i++)
             {
                 dgv.Rows.Add();
             }



             DateTime dt_now = dtp.Value;
             DateTime cur_month = DateTime.MinValue;

             for (int i = 0; i < ColVisNum(); i++)
             {
                 if (cur_month.Month != dt_now.Month) dgv["col" + (i + 1).ToString(), 0].Value = VisualAdapterMonth(dt_now.Month.ToString()) + " " + dt_now.Year;
                 cur_month = dt_now;
                 // if (dt_now.Day.ToString() == "1") dgv["col" + (i + 1).ToString(), 0].Value = VisualAdapterMonth(dt_now.Month.ToString()) + " " + dt_now.Year;
                 dgv["col" + (i + 1).ToString(), 1].Value = VisualAdapterWeek(dt_now.DayOfWeek.ToString());
                 dgv["col" + (i + 1).ToString(), 2].Value = dt_now.Day.ToString();
                 dgv["col" + (i + 1).ToString(), 3].Value = dt_now.DayOfYear.ToString();
                 dt_now = dt_now.AddDays(1);
             }



         }
         * 
         * 
         */

        public void MakeItWeekend()
        {
            foreach (DataGridViewColumn dgvc in dgv.Columns)
            {
                if (dgvc.DataGridView.Rows[1].Cells[dgvc.Index].Value != null)
                {
                    if (dgvc.DataGridView.Rows[1].Cells[dgvc.Index].Value.ToString() == "Сб")
                    {
                        foreach (DataGridViewRow dgvr in dgv.Rows)
                        {
                            dgv[dgvc.Index, dgvr.Index].Style.ForeColor = Color.Red;

                        }
                    }
                    else if (dgvc.DataGridView.Rows[1].Cells[dgvc.Index].Value.ToString() == "Вс")
                    {
                        foreach (DataGridViewRow dgvr in dgv.Rows)
                        {
                            dgv[dgvc.Index, dgvr.Index].Style.ForeColor = Color.Red;

                        }
                    }
                    else
                    {
                        foreach (DataGridViewRow dgvr in dgv.Rows)
                        {
                            dgv[dgvc.Index, dgvr.Index].Style.ForeColor = Color.Black;

                        }
                    }
                }
            }
        }

        bool IsTheSameCellValue(int column, int row)
        {
            DataGridViewCell cell1 = dgv[column, row];
            DataGridViewCell cell2 = dgv[column - 1, row];
            if (cell1.Value == null || cell2.Value == null)
            {
                return false;
            }
            return cell1.Value.ToString() == cell2.Value.ToString();
        }
        public string VisualAdapterMonth(string month_raw)
        {
            switch (month_raw)
            {
                case "1": return "Январь";
                case "2": return "Февраль";
                case "3": return "Март";
                case "4": return "Апрель";
                case "5": return "Май";
                case "6": return "Июнь";
                case "7": return "Июль";
                case "8": return "Август";
                case "9": return "Сентябрь";
                case "10": return "Октябрь";
                case "11": return "Ноябрь";
                case "12": return "Декабрь";
                default: return "underfined";

            }
            return "underfined";
        }

        public string VisualAdapterWeek(string week_raw)
        {
            switch (week_raw)
            {
                case "Monday": return "Пн";
                case "Tuesday": return "Вт";
                case "Wednesday": return "Ср";
                case "Thursday": return "Чт";
                case "Friday": return "Пт";
                case "Saturday": return "Сб";
                case "Sunday": return "Вс";
                default: return "underfined";

            }
            return "underfined";
        }
        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ColNullNamer()
        {
            foreach (DataGridViewColumn dgvc in dgv.Columns)
            {
                if (dgvc.Name != "firstClmn") dgvc.HeaderText = "";
            }
        }

        public int ColVisNum()
        {
            int DGV_VisibleColumns = 0;
            foreach (DataGridViewColumn dgvc in dgv.Columns)
            {
                if (dgvc.Visible)
                {
                    DGV_VisibleColumns++;
                }
            }

            if (DGV_VisibleColumns > 93) return 93;
            return DGV_VisibleColumns;

        }

        #region ViewFormats

        void DGV_View_by_1Day()
        {

            for (int i = 0; i < 24; i++)
            {
                dgv.Columns["colh" + i.ToString()].Visible = true;
            }

            for (int i = 1; i < 94; i++)
            {
                dgv.Columns["col" + i.ToString()].Visible = false;
            }


        }

        void DGV_View_by_14Days()
        {
            for (int i = 0; i < 24; i++)
            {
                dgv.Columns["colh" + i.ToString()].Visible = false;
            }

            for (int i = 1; i < 15; i++)
            {
                dgv.Columns["col" + i.ToString()].Visible = true;
            }

            for (int i = 15; i < 94; i++)
            {
                dgv.Columns["col" + i.ToString()].Visible = false;
            }

        }

        void DGV_View_by_Days(int num_days)
        {
            for (int i = 0; i < 24; i++)
            {
                dgv.Columns["colh" + i.ToString()].Visible = false;
            }

            for (int i = 1; i < num_days + 1; i++)
            {
                dgv.Columns["col" + i.ToString()].Visible = true;
            }

            for (int i = num_days + 1; i < 94; i++)
            {
                dgv.Columns["col" + i.ToString()].Visible = false;
            }
        }

        #endregion

        #region ShiftViewWindow

        public void ShiftLeftOneStep()
        {
            ColVisNum();
            for (int i = 0; i < ColVisNum(); i++)
            {
                if (isRowMustBeShifted(i))
                {
                    DGV_Row_Clear(dgv.Columns["col1"]);
                    DGV_Row_Move(dgv.Columns["col" + i.ToString()], dgv.Columns["col" + (i + 1).ToString()]);
                    DGV_Row_AppendRight();
                }
            }
        }

        public void ShiftRightOneStep()
        {
            ColVisNum();
            for (int i = 0; i < ColVisNum(); i++)
            {
                if (isRowMustBeShifted(i))
                {
                    DGV_Row_Clear(dgv.Columns["col" + ColVisNum().ToString()]);
                    DGV_Row_Move(dgv.Columns["col" + (i + 1).ToString()], dgv.Columns["col" + i.ToString()]);
                    DGV_Row_AppendLeft();
                }
            }
        }

        public void ShiftLeftSteps(int step_c)
        {
            for (int i = 0; i < step_c; i++)
            {
                ShiftLeftOneStep();
            }
        }

        public void ShiftRightSteps(int step_c)
        {
            for (int i = 0; i < step_c; i++)
            {
                ShiftRightOneStep();
            }
        }
        #endregion

        private void button16_Click(object sender, EventArgs e)
        {
            GenerateCalendar();
            MakeItWeekend();
            HideDublesMonth();
        }


        #region PROTOTYPES

        void DGV_Row_AppendLeft()
        {
        }

        void DGV_Row_AppendRight()
        {

        }
        void DGV_Row_Clear(DataGridViewColumn dgvc)
        {

        }

        void DGV_Row_Move(DataGridViewColumn dgvc1, DataGridViewColumn dgvc2)
        {

        }

        bool isRowMustBeShifted(int dmp)
        {
            return false;
        }
        #endregion

        private void dgv_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {

        }

        private void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            //if (e.RowIndex != 0 || e.ColumnIndex < 2)
            //    return;
            //if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            //{
            //    e.AdvancedBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            //}
            //else
            //{
            //    e.AdvancedBorderStyle.Left = dgv.AdvancedCellBorderStyle.Top;
            //}
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (e.RowIndex != 0 || e.ColumnIndex < 2)
            //    return;
            //if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            //{
            //    e.Value = "";
            //    e.FormattingApplied = true;
            //}
        }

        public void HideDublesMonth()
        {
            //  dgv.Rows[2].DataGridView.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
        }

        private void cmbVisPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!loading_lock)
            {
                switch (cmbVisPeriod.Text)
                {
                    case "30 дней":
                        DGV_View_by_Days(30);
                        break;
                    case "14 дней":
                        DGV_View_by_14Days();
                        break;
                    case "7 дней":
                        DGV_View_by_Days(7);
                        break;
                    case "1 день":
                        DGV_View_by_1Day();
                        break;
                    case "60 дней":
                        DGV_View_by_Days(60);
                        break;
                    case "90 дней":
                        DGV_View_by_Days(90);
                        break;
                    default:
                        MessageBox.Show("underfined");
                        break;
                }
                GenerateCalendar();
                MakeItWeekend();
                HideDublesMonth();

                string col_n = GetColumnName(dtp.Value.DayOfYear, dtp.Value.Day, dtp.Value.Year);
                int col_x = GetColumnNumByName(col_n);
                int col_y = dgv.Location.Y + dgv.Rows[0].Height;
                int col_height = 0;
                if (dgv.Rows.Count < 2)
                {
                    col_height = 0;
                }
                else
                {
                    col_height = (dgv.Rows.Count - 2) * dgv.Rows[0].Height;
                }

                //locatePicLine(col_x, col_y, col_height, col_n);

            }
        }

        private void bSetToday_Click(object sender, EventArgs e)
        {
            dtp.Value = DateTime.Today;
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            if (!loading_lock)
            {
                GenerateCalendar();

                HideDublesMonth();

                string col_n = GetColumnName(dtp.Value.DayOfYear, dtp.Value.Day, dtp.Value.Year);
                int col_x = GetColumnNumByName(col_n);
                int col_y = dgv.Location.Y + dgv.Rows[0].Height;
                int col_height = 0;
                if (dgv.Rows.Count < 2)
                {
                    col_height = 0;
                }
                else
                {
                    col_height = (dgv.Rows.Count - 2) * dgv.Rows[0].Height;
                }

                //locatePicLine(col_x, col_y, col_height, col_n);
                SetAllTableEmpty();
                BookingListDatesInitializator();
                MakeItWeekend();
                locateToday();
            }
        }

        public void SetAllTableEmpty()
        {
            foreach (DataGridViewColumn dgvc in dgv.Columns)
            {
                foreach (DataGridViewRow dgvr in dgv.Rows)
                {
                    painterCellsRooms(dgvc.Name, dgvr.Index, ColorVals.Empty);
                }
            }
        }
        string GetColumnName(int d_y, int d, int y)
        {
            for (int i = 0; i < ColVisNum(); i++)
            {
                if (dgv.Rows[3].Cells[i].Value != null)
                {
                    if (dgv.Rows[3].Cells[i].Value.ToString() == d_y.ToString())
                    {
                        if (dgv.Rows[2].Cells[i].Value.ToString() == d.ToString())
                        {
                            //    if (YearRefiner(dgv.Rows[0].Cells[i].Value.ToString()) == y)
                            //{
                            return ("col" + i).ToString();
                            //}

                        }
                    }
                }
                break;
            }
            return null;
        }

        int YearRefiner(string input)
        {
            int year = 0;
            int.TryParse(string.Join("", input.Where(c => char.IsDigit(c))), out year);
            return year;
        }

        int GetColumnNumByName(string dtp_in)
        {
            ////// int num = YearRefiner(dtp_in);
            int num = 1;
            int res = dgv.Location.X + (dgv.Columns[0].Width / 2 + dgv.Columns[0].Width * num);
            return res;
            return Int32.MinValue;
        }

        private void bDTP7DaysPast_Click(object sender, EventArgs e)
        {
            dtp.Value = dtp.Value.AddDays(7);
        }

        private void bDTP7DaysBefore_Click(object sender, EventArgs e)
        {
            dtp.Value = dtp.Value.AddDays(-7);
        }

        private void bDTP30DaysBefore_Click(object sender, EventArgs e)
        {
            dtp.Value = dtp.Value.AddDays(-30);
        }

        private void bDTP30DaysAfter_Click(object sender, EventArgs e)
        {
            dtp.Value = dtp.Value.AddDays(+30);
        }

        private void bPrevDay_Click(object sender, EventArgs e)
        {
            dtp.Value = dtp.Value.AddDays(-1);
        }

        private void bNextDay_Click(object sender, EventArgs e)
        {
            dtp.Value = dtp.Value.AddDays(+1);
        }

        private void tRP_Tick(object sender, EventArgs e)
        {
            txtRPToday.Text = "Сейчас: " + DateTime.Now;
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (Program.onsc.isShown)
            //{
            //    Program.onsc.Visible = true;
            //    Program.onsc.Focus();
            //}
            //else
            //{
            //    Program.onsc.Show();
            //    Program.onsc.isShown = true;

            //}
            OnlineStatusCountdown onsc = new OnlineStatusCountdown();
            onsc.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //if (Program.bl.isShown)
            //{
            //    Program.bl.Visible = true;
            //    Program.bl.Focus();
            //}
            //else
            //{
            //    Program.bl.Show();
            //    Program.bl.isShown = true;

            //}
            //BookingList bl = new BookingList();
            //bl.Show();

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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #region 1DayUpdating

        public void Set_1DayIncoming(int input)
        {
            txt1DayIncoming.Text = "Заезды: " + input;
        }

        public void Set_1DayOutcoming(int input)
        {
            txt1DayOutcoming.Text = "Выезды: " + input;
        }

        public void Set_1DayLiving(int input)
        {
            txt1DayLiving.Text = "Проживание: " + input;
        }

        public void Set_1DayBirthdays(int input)
        {
            txt1DayBirthdays.Text = "Дни рождения: " + input;
        }

        public void Set_1DayTotalRooms(int input)
        {
            txt1DayTotalRooms.Text = "Всего номеров: " + input;
        }

        public void Set_1DayTotalPlaces(string input)
        {
            txt1DayTotalPlaces.Text = "Всего мест: " + input;
        }

        public void Set_1DayAvaliableRooms(int input)
        {
            txt1DayAvaliableRooms.Text = "Свободно номеров: " + input;
        }

        public void Set_1DayOccupatedRooms(int input)
        {
            txt1DayOccupatedRooms.Text = "Занято номеров: " + input;
        }

        public void Set_1DayOccupation(int input)
        {
            txt1DayOccupation.Text = "Загрузка: " + input + "%";
        }

        #endregion

        #region 1DayPreprocessor
        public void OneDayPreprocessor_Birthdays()
        {
            int data = 0;
            List<string> lst = Program.bl.getAllBirthdays();
            DateTime for_parsing = DateTime.Today;

            for (int i = 0; i < lst.Count; i++)
            {
                for_parsing = DateTime.Parse(lst[i]);
                if (for_parsing.Date == DateTime.Now.Date)
                {
                    data++;
                }
            }
            Set_1DayBirthdays(data);
        }

        public void OneDayPreprocessor_Incomings()
        {
            int data = 0;
            List<string> lst = Program.bl.getAllCheckInDates();
            DateTime for_parsing = DateTime.Today;

            for (int i = 0; i < lst.Count; i++)
            {
                for_parsing = DateTime.Parse(lst[i]);
                if (for_parsing.Date == DateTime.Now.Date)
                {
                    data++;
                }
            }
            Set_1DayIncoming(data);
        }

        public void OneDayPreprocessor_Outcomings()
        {
            int data = 0;
            List<string> lst = Program.bl.getAllCheckOutDates();
            DateTime for_parsing = DateTime.Today;

            for (int i = 0; i < lst.Count; i++)
            {
                for_parsing = DateTime.Parse(lst[i]);
                if (for_parsing.Date == DateTime.Now.Date)
                {
                    data++;
                }
            }
            Set_1DayOutcoming(data);
        }

        public void OneDayPreprocessor_AllRooms()
        {
            int data = 0;
            List<string> lst = Program.bl.getAllCheckInDates();
            Set_1DayTotalRooms(lst.Count);
        }

        public void OneDayPreprocessor_AllPlaces()
        {
            Set_1DayTotalPlaces(Program.db.getAllPlaces());
        }

        #endregion

        private void button4_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlDDM.Visible = false;
            pnlDDM.Location = new Point(1, 1);

            int x = dgv.SelectedCells[0].ColumnIndex;
            int y = dgv.SelectedCells[0].RowIndex;

            int x_size = dgv.SelectedCells[0].Size.Width;
            int y_size = dgv.SelectedCells[0].Size.Height;

            int p_calc = dgv.Location.Y + y * y_size + y_size * 2 + pnlDDM.Size.Height + pnlDDM.Location.Y;

            int pnl_x = dgv.Location.X + dgv["nullClmn", 0].Size.Width;

            for (int i = 1; i<x; i++)
            {
                pnl_x += dgv["col" + i, 0].Size.Width;
            }

            int pnl_y = dgv.Location.Y + dgv["nullClmn", 0].Size.Height;

            for (int i = 1; i < y; i++)
            {
                pnl_y += dgv["col1", y].Size.Height;
            }

            Point pnt;

            if (StyleAllowForAnalyze(dgv[x, y].Style.BackColor, dgv[x, y].Style.ForeColor))
            {
                //if (dgv.Location.Y + y * y_size + y_size * 2 + pnlDDM.Size.Height + pnlDDM.Location.Y>= this.Size.Height - 75)
                //if (pnl_y + pnlDDM.Height >= this.Size.Height)
                //if (pnl_y + pnlDDM.Height >= this.Size.Height)
                if (true)
                {
                    //pnt = new Point(dgv.Location.X + x * x_size, dgv.Location.Y + y * y_size + y_size - pnlDDM.Size.Height);
                    pnt = new Point(pnl_x, pnl_y - pnlDDM.Size.Height / 2 + 65);
                    pnlDDM.BringToFront();
                }
                else
                {
                    //pnt = new Point(dgv.Location.X + x * x_size, dgv.Location.Y + y * y_size + y_size * 2);
                    pnt = new Point(pnl_x, pnl_y + pnlDDM.Size.Height / 2+ 25);
                    pnlDDM.BringToFront();
                }

                pnlDDM.Location = pnt;

                ODDM_Detector(x, y);

                pnlDDM.Visible = true;
                pnlDDM.BringToFront();
            }


        }

        public bool StyleAllowForAnalyze(Color backcolor, Color forecolor)
        {
            if (backcolor == ColorValsEmptyBackColor)
            {
                return false;
            }
            else if (backcolor == ColorValsOverbookingBackColor)
            {
                return false;
            }
            else if (backcolor == ColorValsTodayMarker)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void bDDMShow_Click(object sender, EventArgs e)
        {
            if (Program.anb.isShown)
            {
                /* 
                 * mode: 0 - создание брони
                 * mode: 1 - просмотр уже существующих броней
                 * mode: 2 - редактирование уже существующих броней
                */
                
                Program.anb.ModeChanger(1);

                Program.anb.WindowState = FormWindowState.Normal;
                Program.anb.Visible = true;
                Program.anb.Focus();
                Program.anb.BringToFront();
            }
            else
            {
                Program.anb.ModeChanger(1);
                Program.anb.Show();
            }
        }

        private void bDDMEdit_Click(object sender, EventArgs e)
        {
            if (Program.anb.isShown)
            {
                /* 
                 * mode: 0 - создание брони
                 * mode: 1 - просмотр уже существующих броней
                 * mode: 2 - редактирование уже существующих броней
                */

                Program.anb.ModeChanger(2);

                Program.anb.WindowState = FormWindowState.Normal;
                Program.anb.Visible = true;
                Program.anb.Focus();
                Program.anb.BringToFront();
            }
            else
            {
                Program.anb.ModeChanger(2);
                Program.anb.Show();
            }
        }

        private void bDDMMove_Click(object sender, EventArgs e)
        {

        }

        private void bDDMCopy_Click(object sender, EventArgs e)
        {

        }
    }
}
