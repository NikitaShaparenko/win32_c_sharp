using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerPMS
{

    public enum MealType
    {
        //OB (Без питания)  - только размещение в гостинице.  //RO - room only - без питания, 
        //BB(Завтрак) - режим питания, предполагающий завтраки в отеле проживания.Это может быть шведский стол или континентальный завтрак.
        //HB (Полупансион) - режим 2-разового питания в отеле. Обычно это завтрак и ужин, но в некоторых отелях может быть завтрак и обед.Напитки за обедом и ужином обычно в стоимость не входят.
        //FB (Полный пансион) - режим 3-разового питания в отеле (завтрак + обед + ужин). Напитки за обедом и ужином обычно в стоимость не входят.
        //Al, All inclusive (Все включено) - режим, включающий не только 3-разовое питание, но и дополнительные услуги, такие как легкий завтрак, закуски, легкий ужин. Напитки входят в стоимость. Иногда это могут быть только напитки местного производства, а иностранные продаются за доп.плату

        //BB  bed & breakfast     завтраки, только завтрак в отеле
        //HB  half board  полупансион (завтрак + ужин)
        //FB full board полный пансион(завтрак, обед, ужин)
        //AI all inclusive 	- "всё включено" (полный пансион, включая напитки местного производства) - система “все включено” в отеле, как минимум трехразовое питание, как минимум с напитками местного производства в том числе и алкогольными
        //UAI ultra all inclusive 	- "всё включено" (полный пансион, включая напитки иностранного производства) - система “ультра все включено” в отеле, как минимум трехразовое питание, как минимум с напитками местного и импортного производства, в том числе и алкогольными, это система в каждом отеле может иметь, как правило, свое название. Иногда встречается следующие виды пансионов
        //НВ+ 	half board plus завтрак и ужин в отеле, напитки во время ужина включены, алкогольные (местного производства) и безалкогольные.Перечень напитков и количество (1 бокал или 2 бутылки и т.д.) зависит от отеля
        //FB+ 	full board plus завтрак, обед и ужин в отеле.Во время обеда и ужина включены алкогольные (местного производства) и безалкогольные напитки.

        OB,
        BB,
        HB,
        FB,
        AI,
        UAI,
        HBPlus,
        FBPlus,
    }

    public enum BookingType
    {
        confirmed,
        non_confirmed,
        accommodation,
        overbooking,
        dening,
    }

    public enum BookingSource
    {
        reception,
        travel_agency,     
    }
    public partial class BookingList : Form
    {

        public bool isShown = false;
        public BookingList()
        {
            InitializeComponent();
        }

        public string ViewConverterBookingSource(string input)
        {
            switch(input)
            {
                case "reception":
                    return "Стойка рецепции";
                case "travel_agency":
                    return "Туристическое агенство";
                default:
                    return "Неизвестно";
            }
        }

        public string ViewConverterBookingType(string input)
        {
            switch (input)
            {
                case "confirmed":
                    return "Бронь подтверждена";
                case "non_confirmed":
                    return "Бронь новая (требует проверки)";
                case "accommodation":
                    return "Проживание";
                case "overbooking":
                    return "Овербукинг";
                case "dening":
                    return "Бронь отменена";

                default:
                    return "Неизвестно";
            }
        }

        public string ViewConverterMealType(string input)
        {
            switch (input)
            {
                case "OB":
                    return "OB (Без питания)";
                case "BB":
                    return "BB (Завтрак)";
                case "HB":
                    return "HB (Полупансион)";
                case "FB":
                    return "FB (Полный пансион)";
                case "AI":
                    return "Al, All inclusive (Все включено)";
                case "UAI":
                    return "Ultra all inclusive (Всё включено)";
                case "HBPlus":
                    return "НВ+ (Завтрак и ужин в отеле)";
                case "FBPlus":
                    return "FB+ (Завтрак, обед и ужин в отеле)";
                default:
                    return "Неизвестно";
            }
        }

        public string ViewConveterBookingID(string input)
        {
            string res = "";
            for(int i =0; i<input.Length;i++)
            {
                switch(input[i])
                {
                    case '0':
                        res += '0';
                        break;
                    case '1':
                        res += '1';
                        break;
                    case '2':
                        res += '2';
                        break;
                    case '3':
                        res += '3';
                        break;
                    case '4':
                        res += '4';
                        break;
                    case '5':
                        res += '5';
                        break;
                    case '6':
                        res += '6';
                        break;
                    case '7':
                        res += '7';
                        break;
                    case '8':
                        res += '8';
                        break;
                    case '9':
                        res += '9';
                        break;

                }
            }
            return res;
        }

        public int ComboBoxToInt(ComboBox cmb, string str)
        {
            for (int c = 0; c<cmb.Items.Count; c++)
            {
                if (cmb.Items[c].ToString() == str)
                {
                    return c;
                }
            }
            return 0;
        }

        public int HourParser(string input_string)
        {
            int hour = 0;
            string s_hour = "";
            bool stop_reading = false;

            for (int i = 0; i<input_string.Length;i++)
            {
                if (input_string[i] == ':')
                {
                    stop_reading = true;
                }
                if (!stop_reading)
                {
                    if (input_string[i] != ':')
                    {
                        s_hour += input_string[i];
                    }
                  
                }

               
            }

            return Int16.Parse(s_hour);
        }

        public int MinuteParser(string input_string)
        {
            int hour = 0;
            string s_hour = "";
            bool stop_reading = true;

            for (int i = 0; i < input_string.Length; i++)
            {
                if (input_string[i] == ':')
                {
                    stop_reading = false;
                }
                if (!stop_reading)
                {
                    if (input_string[i] != ':')
                    {
                        s_hour += input_string[i];
                    }
                }
               
            }
            return Int16.Parse(s_hour);
        }

        public string CodeU1Parser(string input_string)
        {
            string a = "";
            bool stop_reading = false;

            for (int i = 0; i< input_string.Length;i++)
            {
                if (input_string[i] == '-')
                {
                    stop_reading = true;
                    break;
                }
                if (!stop_reading)
                {
                    a += input_string[i];
                }
               
            }
            return a;
        }

        public string CodeU2Parser(string input_string)
        {
            string a = "";
            bool stop_reading = true;

            for (int i = 0; i < input_string.Length; i++)
            {
                if (input_string[i] == '-')
                {
                    stop_reading = false;
                    break;
                }
                if (!stop_reading)
                {
                    a += input_string[i];
                }
               
            }
            return a;
        }

        public void AddBookingToDatabase(string id_booking, string room_id, string name, int number_of_all_places, string time_checking, string date_of_incoming, string time_of_checkout, string date_of_outcoming, BookingType booking_type, int adults, int sum, int payed, BookingSource source, MealType type_of_meal, string comment, DateTime date_of_creating, DateTime Birthday,string passport_series, string passport_code, DateTime passport_outcome_date, string passport_u1, string passport_u2, string passport_whom_given)
        {
            dgvBooking.Rows.Add(id_booking.ToString(), room_id.ToString(), name.ToString(), number_of_all_places.ToString(), time_checking.ToString(), date_of_incoming.ToString(), time_of_checkout.ToString(),  date_of_outcoming.ToString(), booking_type.ToString(), adults.ToString(),sum.ToString(), payed.ToString(), (sum - payed).ToString(),source.ToString(), type_of_meal.ToString(), comment.ToString(), date_of_creating.ToString(), Birthday.ToString(), passport_series.ToString(), passport_code.ToString(), passport_outcome_date.ToString(),passport_u1.ToString(),passport_u2.ToString(), passport_whom_given.ToString());
            //dgvBooking.Rows[dgvBooking.Rows.Count - 1].Cells[0].Value = id_booking.ToString();
            //dgvBooking.Rows[dgvBooking.Rows.Count - 1].Cells[1].Value = room_id.ToString();
            //dgvBooking.Rows[dgvBooking.Rows.Count - 1].Cells[2].Value = name.ToString();
            //dgvBooking.Rows[dgvBooking.Rows.Count - 1].Cells[3].Value = number_of_all_places.ToString();
            //dgvBooking.Rows[dgvBooking.Rows.Count - 1].Cells[4].Value = time_checking.ToString();
            //dgvBooking.Rows[dgvBooking.Rows.Count - 1].Cells[5].Value = date_of_incoming.ToString();
            //dgvBooking.Rows[dgvBooking.Rows.Count - 1].Cells[6].Value = time_of_checkout.ToString();
            //dgvBooking.Rows[dgvBooking.Rows.Count - 1].Cells[7].Value = date_of_outcoming.ToString();
            //dgvBooking.Rows[dgvBooking.Rows.Count - 1].Cells[8].Value = booking_type.ToString();
            //dgvBooking.Rows[dgvBooking.Rows.Count - 1].Cells[9].Value = adults.ToString();
            //dgvBooking.Rows[dgvBooking.Rows.Count - 1].Cells[10].Value = sum.ToString();
            //dgvBooking.Rows[dgvBooking.Rows.Count - 1].Cells[11].Value = payed.ToString();
            //dgvBooking.Rows[dgvBooking.Rows.Count - 1].Cells[12].Value = (sum - payed).ToString();
            //dgvBooking.Rows[dgvBooking.Rows.Count - 1].Cells[13].Value = source.ToString();
            //dgvBooking.Rows[dgvBooking.Rows.Count - 1].Cells[14].Value = type_of_meal.ToString();
            //dgvBooking.Rows[dgvBooking.Rows.Count - 1].Cells[15].Value = comment.ToString();
            //dgvBooking.Rows[dgvBooking.Rows.Count - 1].Cells[16].Value = date_of_creating.ToString();
            //dgvBooking.Rows[dgvBooking.Rows.Count - 1].Cells[17].Value = Birthday.ToString();
            //dgvBooking.Rows[dgvBooking.Rows.Count - 1].Cells[18].Value = passport_series.ToString();
            //dgvBooking.Rows[dgvBooking.Rows.Count - 1].Cells[19].Value = passport_code.ToString();
            //dgvBooking.Rows[dgvBooking.Rows.Count - 1].Cells[20].Value = passport_outcome_date.ToString();
            //dgvBooking.Rows[dgvBooking.Rows.Count - 1].Cells[21].Value = passport_u1.ToString();
            //dgvBooking.Rows[dgvBooking.Rows.Count - 1].Cells[22].Value = passport_u2.ToString();
            //dgvBooking.Rows[dgvBooking.Rows.Count - 1].Cells[23].Value = passport_whom_given.ToString();
        }

       // ReplacingToDatabase(index_editing_string, room_id3, room_id2, txtname.Text, Decimal.ToInt16(nudAdults.Value + nudChildren.Value), nudHour.Value.ToString() + ":" + nudMinute.Value.ToString(), dtpCheckin.Value.ToString(), nudOutcomeHour.Value.ToString() + ":" + nudOutcomeMinute.Value.ToString(), dtpOutcome.Value.ToString(), bookingtype, Decimal.ToInt16(nudChildren.Value), Int16.Parse(txtmoney.Text), Int16.Parse(txtPayed.Text), bookingsource, mealType, rtfComment.Text, DateTime.Today, dtpBirthday.Value, txtSN.Text, txtNum.Text, dtpDateOfOutcome.Value, txtCodeU1.Text, txtCodeU2.Text, txtWhomItWasGiven.Text);
        public void ReplacingToDatabase(int index_editing_string,string id_booking, string room_id, string name, int number_of_all_places, string time_checking, string date_of_incoming, string time_of_checkout, string date_of_outcoming, BookingType booking_type, int adults, int sum, int payed, BookingSource source, MealType type_of_meal, string comment, DateTime date_of_creating, DateTime Birthday, string passport_series, string passport_code, DateTime passport_outcome_date, string passport_u1, string passport_u2, string passport_whom_given)
        {
            //  dgvBooking.Rows.Add(id_booking.ToString(), room_id.ToString(), name.ToString(), number_of_all_places.ToString(), time_checking.ToString(), date_of_incoming.ToString(), time_of_checkout.ToString(), date_of_outcoming.ToString(), booking_type.ToString(), adults.ToString(), sum.ToString(), payed.ToString(), (sum - payed).ToString(), source.ToString(), type_of_meal.ToString(), comment.ToString(), date_of_creating.ToString(), Birthday.ToString(), passport_series.ToString(), passport_code.ToString(), passport_outcome_date.ToString(), passport_u1.ToString(), passport_u2.ToString(), passport_whom_given.ToString());
            dgvBooking.Rows[index_editing_string].Cells[0].Value = id_booking.ToString();
            dgvBooking.Rows[index_editing_string].Cells[1].Value = room_id.ToString();
            dgvBooking.Rows[index_editing_string].Cells[2].Value = name.ToString();
            dgvBooking.Rows[index_editing_string].Cells[3].Value = number_of_all_places.ToString();
            dgvBooking.Rows[index_editing_string].Cells[4].Value = time_checking.ToString();
            dgvBooking.Rows[index_editing_string].Cells[5].Value = date_of_incoming.ToString();
            dgvBooking.Rows[index_editing_string].Cells[6].Value = time_of_checkout.ToString();
            dgvBooking.Rows[index_editing_string].Cells[7].Value = date_of_outcoming.ToString();
            dgvBooking.Rows[index_editing_string].Cells[8].Value = booking_type.ToString();
            dgvBooking.Rows[index_editing_string].Cells[9].Value = adults.ToString();
            dgvBooking.Rows[index_editing_string].Cells[10].Value = sum.ToString();
            dgvBooking.Rows[index_editing_string].Cells[11].Value = payed.ToString();
            dgvBooking.Rows[index_editing_string].Cells[12].Value = (sum - payed).ToString();
            dgvBooking.Rows[index_editing_string].Cells[13].Value = source.ToString();
            dgvBooking.Rows[index_editing_string].Cells[14].Value = type_of_meal.ToString();
            dgvBooking.Rows[index_editing_string].Cells[15].Value = comment.ToString();
            dgvBooking.Rows[index_editing_string].Cells[16].Value = date_of_creating.ToString();
            dgvBooking.Rows[index_editing_string].Cells[17].Value = Birthday.ToString();
            dgvBooking.Rows[index_editing_string].Cells[18].Value = passport_series.ToString();
            dgvBooking.Rows[index_editing_string].Cells[19].Value = passport_code.ToString();
            dgvBooking.Rows[index_editing_string].Cells[20].Value = passport_outcome_date.ToString();
            dgvBooking.Rows[index_editing_string].Cells[21].Value = passport_u1.ToString();
            dgvBooking.Rows[index_editing_string].Cells[22].Value = passport_u2.ToString();
            dgvBooking.Rows[index_editing_string].Cells[23].Value = passport_whom_given.ToString();
        }

        public int getBookingRowByID(string booking_id)
        {
            for (int i = 0; i<dgvBooking.Rows.Count - 1; i++)
            {
                if (dgvBooking.Rows[i].Cells[1].Value != null)
                {
                    if (dgvBooking.Rows[i].Cells[1].Value.ToString() == booking_id)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public int getBookingRowByName(string name)
        {
            for (int i = 0; i < dgvBooking.Rows.Count - 1; i++)
            {
                if (dgvBooking.Rows[i].Cells[2].Value != null)
                {
                    if (dgvBooking.Rows[i].Cells[2].Value.ToString() == name)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public string showMeTheID(int str_n)
        {
           if (dgvBooking.Rows[str_n].Cells[1].Value != null)
           {
                return dgvBooking.Rows[str_n].Cells[1].Value.ToString();
           }
           else
           {
                return "null";
           }
        }

        public string showMeTheNames(int str_n)
        {
            if (dgvBooking.Rows[str_n].Cells[2].Value != null)
            {
                return dgvBooking.Rows[str_n].Cells[2].Value.ToString();
            }
            else
            {
                return "null";
            }
        }

        public string showMeThePlaces(int str_n)
        {
            if (dgvBooking.Rows[str_n].Cells[3].Value != null)
            {
                return dgvBooking.Rows[str_n].Cells[3].Value.ToString();
            }
            else
            {
                return "null";
            }
        }

        public string showMeTheCheckinTime(int str_n)
        {
            if (dgvBooking.Rows[str_n].Cells[4].Value != null)
            {
                return dgvBooking.Rows[str_n].Cells[4].Value.ToString();
            }
            else
            {
                return "null";
            }
        }

        public string showMeTheCheckinDate(int str_n)
        {
            if (dgvBooking.Rows[str_n].Cells[5].Value != null)
            {
                return dgvBooking.Rows[str_n].Cells[5].Value.ToString();
            }
            else
            {
                return "null";
            }
        }

        public string showMeTheCheckOutTime(int str_n)
        {
            if (dgvBooking.Rows[str_n].Cells[6].Value != null)
            {
                return dgvBooking.Rows[str_n].Cells[6].Value.ToString();
            }
            else
            {
                return "null";
            }
        }

        public string showMeTheCheckOutDate(int str_n)
        {
            if (dgvBooking.Rows[str_n].Cells[7].Value != null)
            {
                return dgvBooking.Rows[str_n].Cells[7].Value.ToString();
            }
            else
            {
                return "null";
            }
        }

        public string showMeTheStatus(int str_n)
        {
            if (dgvBooking.Rows[str_n].Cells[8].Value != null)
            {
                return dgvBooking.Rows[str_n].Cells[8].Value.ToString();
            }
            else
            {
                return "null";
            }
        }

       public string showMeTheSum(int str_n)
        {
            if (dgvBooking.Rows[str_n].Cells[10].Value != null)
            {
                return dgvBooking.Rows[str_n].Cells[10].Value.ToString();
            }
            else
            {
                return "null";
            }
        }

        public string showMeThePayed(int str_n)
        {
            if (dgvBooking.Rows[str_n].Cells[11].Value != null)
            {
                return dgvBooking.Rows[str_n].Cells[11].Value.ToString();
            }
            else
            {
                return "null";
            }
        }

        public string showMeTheMealType(int str_n)
        {
            if (dgvBooking.Rows[str_n].Cells[13].Value != null)
            {
                return dgvBooking.Rows[str_n].Cells[13].Value.ToString();
            }
            else
            {
                return "null";
            }
        }

        public string showMeTheCreationDate(int str_n)
        {
            if (dgvBooking.Rows[str_n].Cells[7].Value != null)
            {
                return dgvBooking.Rows[str_n].Cells[7].Value.ToString();
            }
            else
            {
                return "null";
            }
        }

        public string showMeTheBirthday(int str_n)
        {
            if (dgvBooking.Rows[str_n].Cells[7].Value != null)
            {
                return dgvBooking.Rows[str_n].Cells[7].Value.ToString();
            }
            else
            {
                return "null";
            }
        }
        
        public int getNumBookings()
        {
            int num = 0;
            for (int i = 0; i<dgvBooking.Rows.Count - 1;i++)
            {
                if (dgvBooking.Rows[i].Cells[1] != null)
                {
                    num++;
                }
            }
            return num;
        }

        public List<string> getAllBirthdays()
        {
            List<string> birthdays = new List<string>();
            foreach(DataGridViewRow dgvr in dgvBooking.Rows)
            {
                if (dgvr.Cells[16].Value != null)
                {
                    birthdays.Add(dgvr.Cells[16].Value.ToString());
                }
            }
            return birthdays;
        }

       

        public List<string> getAllMealTypes()
        {
            List<string> mealtypes = new List<string>();
            foreach (DataGridViewRow dgvr in dgvBooking.Rows)
            {
                if (dgvr.Cells[13].Value != null)
                {
                    mealtypes.Add(dgvr.Cells[13].Value.ToString());
                }
            }
            return mealtypes;
        }

        public List<string> getAllPayed()
        {
            List<string> payed = new List<string>();
            foreach (DataGridViewRow dgvr in dgvBooking.Rows)
            {
                if (dgvr.Cells[11].Value != null)
                {
                    payed.Add(dgvr.Cells[11].Value.ToString());
                }
            }
            return payed;
        }

        public List<string> getAllSum()
        {
            List<string> sums = new List<string>();
            foreach (DataGridViewRow dgvr in dgvBooking.Rows)
            {
                if (dgvr.Cells[10].Value != null)
                {
                    sums.Add(dgvr.Cells[10].Value.ToString());
                }
            }
            return sums;
        }

        public List<string> getAllNames()
        {
            List<string> names = new List<string>();
            foreach (DataGridViewRow dgvr in dgvBooking.Rows)
            {
                if (dgvr.Cells[2].Value != null)
                {
                    names.Add(dgvr.Cells[2].Value.ToString());
                }
            }
            return names;
        }

        public List<string> getAllCheckOutTimes()
        {
            List<string> checkout_times = new List<string>();
            foreach (DataGridViewRow dgvr in dgvBooking.Rows)
            {
                if (dgvr.Cells[6].Value != null)
                {
                    checkout_times.Add(dgvr.Cells[6].Value.ToString());
                }
            }
            return checkout_times;
        }

        public List<string> getAllCheckInTimes()
        {
            List<string> checkin_times = new List<string>();
            foreach (DataGridViewRow dgvr in dgvBooking.Rows)
            {
                if (dgvr.Cells[4].Value != null)
                {
                    checkin_times.Add(dgvr.Cells[4].Value.ToString());
                }
            }
            return checkin_times;
        }

        public List<string> getAllCheckOutDates()
        {
            List<string> checkout_date = new List<string>();
            foreach (DataGridViewRow dgvr in dgvBooking.Rows)
            {
                if (dgvr.Cells[7].Value != null)
                {
                    checkout_date.Add(dgvr.Cells[7].Value.ToString());
                }
            }
            return checkout_date;
        }

        public List<string> getAllCheckInDates()
        {
            List<string> checkin_date = new List<string>();
            foreach (DataGridViewRow dgvr in dgvBooking.Rows)
            {
                if (dgvr.Cells[5].Value != null)
                {
                    checkin_date.Add(dgvr.Cells[5].Value.ToString());
                }
            }
            return checkin_date;
        }

        const string table_name = "BookingList";

        public void BookingList_LoadXSD()
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "\\" + table_name + ".db"))
            {
                try
                {

                    DataSet ds = new DataSet();
                    ds.ReadXmlSchema(Directory.GetCurrentDirectory() + "\\" + table_name + ".db");
                    ds.ReadXml(Directory.GetCurrentDirectory() + "\\" + table_name + ".db");
                    DataTable dt = new DataTable();

                    dt = ds.Tables[0];
                    dt.TableName = table_name;

                    for (int r = 0; r < dt.Rows.Count; r++)
                    {
                        dgvBooking.Rows.Add();
                        for (int c = 0; c < dt.Columns.Count; c++)
                        {

                            if (dt.Rows[r].ItemArray[c] != null) dgvBooking.Rows[r].Cells[c].Value = dt.Rows[r].ItemArray[c];
                            string a;
                            if (dt.Rows[r].ItemArray[c] != null) a = dt.Rows[r].ItemArray[c].ToString();

                        }
                    }

                }
                catch (Exception ex)
                {
                    //ErrorShow("0x4", "Произошла ошибка во время импорта таблицы из файла подкачки " + ex.Message);
                }


            }
        }
        public void ClearRowsClear()
        {
            for (int i = 0; i < dgvBooking.RowCount - 1; i++)
            {

                if (dgvBooking.Rows[i].Cells[0].Value == null)
                {
                    dgvBooking.Rows.RemoveAt(i);
                    i--;
                }
                else if (dgvBooking.Rows[i].Cells[0].Value.ToString() == "")
                {
                    dgvBooking.Rows.RemoveAt(i);
                    i--;
                }
                else if (dgvBooking.Rows[i].Cells[0].Value.ToString() == " ")
                {
                    dgvBooking.Rows.RemoveAt(i);
                    i--;
                }
            }
        }

        public void BookingList_SaveXSD()
        {
            try
            {
                for (int r = 0; r < dgvBooking.Rows.Count; r++)
                {
                    for (int c = 0; c < dgvBooking.Columns.Count; c++)
                    {
                        if (dgvBooking[c, r].Value != null)
                        {
                            if (dgvBooking[c, r].Value.ToString() == "") dgvBooking[c, r].Value = " ";
                        }
                    }
                }

                if (File.Exists(Directory.GetCurrentDirectory() + "\\" + table_name + ".db"))
                {
                    try
                    {
                        if (File.Exists(Directory.GetCurrentDirectory() + "\\" + table_name + ".db")) File.Delete(AppDomain.CurrentDomain.BaseDirectory + "\\" + table_name + ".xml");
                        File.Move(Directory.GetCurrentDirectory() + "\\" + table_name + ".db", Directory.GetCurrentDirectory() + "\\" + table_name + ".bak");
                    }
                    catch (Exception ex)
                    {
                        //ErrorShow("0x3a", "Не удалось создать резервную копию файла подкачки (Код 1)! " + ex.Message);

                    }
                    finally
                    {
                        DataTable dt = new DataTable();
                        foreach (DataGridViewColumn col in dgvBooking.Columns)
                        {
                            dt.Columns.Add(col.Name);
                        }

                        foreach (DataGridViewRow row in dgvBooking.Rows)
                        {
                            DataRow dRow = dt.NewRow();
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                dRow[cell.ColumnIndex] = cell.Value;
                            }
                            dt.Rows.Add(dRow);
                        }

                        foreach (DataRow DataRow in dt.Rows)
                        {
                            for (int j = 0; j < DataRow.ItemArray.Length; j++)
                            {
                                if (DataRow.ItemArray[j] == DBNull.Value)
                                    DataRow.SetField(j, string.Empty);
                            }
                        }

                        dt.TableName = table_name;
                        dt.WriteXml(Directory.GetCurrentDirectory() + "\\" + table_name + ".db");
                    }
                }
                else
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        foreach (DataGridViewColumn col in dgvBooking.Columns)
                        {
                            dt.Columns.Add(col.Name);
                        }

                        foreach (DataGridViewRow row in dgvBooking.Rows)
                        {
                            DataRow dRow = dt.NewRow();
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                dRow[cell.ColumnIndex] = cell.Value;
                            }
                            dt.Rows.Add(dRow);
                        }

                        foreach (DataRow DataRow in dt.Rows)
                        {
                            for (int j = 0; j < DataRow.ItemArray.Length; j++)
                            {
                                if (DataRow.ItemArray[j] == DBNull.Value)
                                    DataRow.SetField(j, string.Empty);
                            }
                        }
                        dt.TableName = table_name;
                        dt.WriteXml(Directory.GetCurrentDirectory() + "\\" + table_name + ".db", XmlWriteMode.WriteSchema);

                    }
                    catch (Exception ex)
                    {
                        //ErrorShow("0x3b", "Не удалось создать резервную копию файла подкачки! (Код 2)! " + ex.Message);
                    }

                }
            }
            catch (Exception ex)
            {
                //ErrorShow("0x3c", "Произошла ошибка во время импорта таблицы из файла подкачки  (Код 3)! " + ex.Message);
            }
        }

        private void BookingList_Load(object sender, EventArgs e)
        {
            isShown = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
