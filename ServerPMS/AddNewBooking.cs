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
    public partial class AddNewBooking : Form
    {
        public AddNewBooking()
        {
            InitializeComponent();
        }

       public bool isShown = false;
       public int mode = 0;
       bool started_passed = false;
       int index_editing_string = 0;

        public void IES_Setter(int ies)
        {
            index_editing_string = ies;
        }
       /* 
        * mode: 0 - создание брони
        * mode: 1 - просмотр уже существующих броней
        * mode: 2 - редактирование уже существующих броней
        */
         
        public void ModeChanger(int mc)
        {
           mode = mc;
           switch(mode)
           {
                case 1:
                    this.Text = "Просмотр существующей брони";
                    cmbBookingSource.Enabled = false;
                    cmbBookingStatus.Enabled = false;
                    cmbMealType.Enabled = false;
                    cmbRoomDatabaseSelector.Enabled = false;

                    txtCodeU1.ReadOnly = true;
                    txtCodeU2.ReadOnly = true;
                    txtID.Enabled = false;
                    txtmoney.ReadOnly = true;
                    txtname.ReadOnly = true;
                    txtNum.ReadOnly = true;
                    txtPayed.ReadOnly = true;
                    txtRoomID.Enabled = false;
                    txtSN.ReadOnly = true;
                    txtToday.Enabled = false;
                    txtWhomItWasGiven.ReadOnly = true;

                    bCheckoutSet10Hours.Enabled = false;
                    bCheckoutSet11Hours.Enabled = false;
                    bCheckoutSet12Hours.Enabled = false;

                    bCheckoutSet10Minute.Enabled = false;
                    bCheckoutSet15Minute.Enabled = false;
                    bCheckoutSet30Minute.Enabled = false;
                    bCheckoutSet45Minute.Enabled = false;

                    bSet14Hours.Enabled = false;
                    bSet13Hours.Enabled = false;
                    bSet12Hours.Enabled = false;

                    bSet0Minute.Enabled = false;
                    bSet15Minute.Enabled = false;
                    bSet30Minute.Enabled = false;
                    bSet45Minute.Enabled = false;

                    rtfComment.ReadOnly = true;

                    nudAdults.ReadOnly = true;
                    nudChildren.ReadOnly = true;
                    nudHour.ReadOnly = true;
                    nudMinute.ReadOnly = true;
                    nudOutcomeHour.ReadOnly = true;
                    nudOutcomeMinute.ReadOnly = true;

                    dtpBirthday.Enabled = false;
                    dtpCheckin.Enabled = false;
                    dtpDateOfOutcome.Enabled = false;
                    dtpOutcome.Enabled = false;

                    bSave.Text = "(Нет действий)";
                    bSave.Visible = false;

                    break;
                case 2:
                    this.Text = "Редактирование существующей брони";

                    cmbBookingSource.Enabled = true;
                    cmbBookingStatus.Enabled = true;
                    cmbMealType.Enabled = true;
                    cmbRoomDatabaseSelector.Enabled = true;

                    txtCodeU1.ReadOnly = false;
                    txtCodeU2.ReadOnly = false;
                    txtID.Enabled = true;
                    txtmoney.ReadOnly = false;
                    txtname.ReadOnly = false;
                    txtNum.ReadOnly = false;
                    txtPayed.ReadOnly = false;
                    txtRoomID.Enabled = true;
                    txtSN.ReadOnly = false;
                    txtToday.Enabled = true;
                    txtWhomItWasGiven.ReadOnly = false;

                    bCheckoutSet10Hours.Enabled = true;
                    bCheckoutSet11Hours.Enabled = true;
                    bCheckoutSet12Hours.Enabled = true;

                    bCheckoutSet10Minute.Enabled = true;
                    bCheckoutSet15Minute.Enabled = true;
                    bCheckoutSet30Minute.Enabled = true;
                    bCheckoutSet45Minute.Enabled = true;

                    bSet14Hours.Enabled = true;
                    bSet13Hours.Enabled = true;
                    bSet12Hours.Enabled = true;

                    bSet0Minute.Enabled = true;
                    bSet15Minute.Enabled = true;
                    bSet30Minute.Enabled = true;
                    bSet45Minute.Enabled = true;

                    rtfComment.ReadOnly = false;

                    nudAdults.ReadOnly = false;
                    nudChildren.ReadOnly = false;
                    nudHour.ReadOnly = false;
                    nudMinute.ReadOnly = false;
                    nudOutcomeHour.ReadOnly = false;
                    nudOutcomeMinute.ReadOnly = false;

                    dtpBirthday.Enabled = true;
                    dtpCheckin.Enabled = true;
                    dtpDateOfOutcome.Enabled = true;
                    dtpOutcome.Enabled = true;

                    bSave.Text = "Сохранить изменения";
                    bSave.Visible = true;

                    break;
                default:
                    this.Text = "Новая бронь";

                    cmbBookingSource.Enabled = true;
                    cmbBookingStatus.Enabled = true;
                    cmbMealType.Enabled = true;
                    cmbRoomDatabaseSelector.Enabled = true;

                    txtCodeU1.ReadOnly = false;
                    txtCodeU2.ReadOnly = false;
                    txtID.Enabled = true;
                    txtmoney.ReadOnly = false;
                    txtname.ReadOnly = false;
                    txtNum.ReadOnly = false;
                    txtPayed.ReadOnly = false;
                    txtRoomID.Enabled = true;
                    txtSN.ReadOnly = false;
                    txtToday.Enabled = true;
                    txtWhomItWasGiven.ReadOnly = false;

                    bCheckoutSet10Hours.Enabled = true;
                    bCheckoutSet11Hours.Enabled = true;
                    bCheckoutSet12Hours.Enabled = true;

                    bCheckoutSet10Minute.Enabled = true;
                    bCheckoutSet15Minute.Enabled = true;
                    bCheckoutSet30Minute.Enabled = true;
                    bCheckoutSet45Minute.Enabled = true;

                    bSet14Hours.Enabled = true;
                    bSet13Hours.Enabled = true;
                    bSet12Hours.Enabled = true;

                    bSet0Minute.Enabled = true;
                    bSet15Minute.Enabled = true;
                    bSet30Minute.Enabled = true;
                    bSet45Minute.Enabled = true;

                    rtfComment.ReadOnly = false;

                    nudAdults.ReadOnly = false;
                    nudChildren.ReadOnly = false;
                    nudHour.ReadOnly = false;
                    nudMinute.ReadOnly = false;
                    nudOutcomeHour.ReadOnly = false;
                    nudOutcomeMinute.ReadOnly = false;

                    dtpBirthday.Enabled = true;
                    dtpCheckin.Enabled = true;
                    dtpDateOfOutcome.Enabled = true;
                    dtpOutcome.Enabled = true;

                    //----------------
                    cmbBookingSource.Text = "";
                    cmbBookingStatus.Text = "";
                    cmbMealType.Text = "";
                    cmbRoomDatabaseSelector.Text = "";

                    txtCodeU1.Text = "";
                    txtCodeU2.Text = "";
                    txtmoney.Text = "";
                    txtname.Text = "";
                    txtNum.Text = "";
                    txtPayed.Text = "";
                    txtRoomID.Text = "";
                    txtSN.Text = "";
                    txtWhomItWasGiven.Text = "";

                    rtfComment.Text = "";

                    nudAdults.Text = "";
                    nudChildren.Text = "";
                    nudHour.Text = "";
                    nudMinute.Text = "";
                    nudOutcomeHour.Text = "";
                    nudOutcomeMinute.Text = "";

                    dtpBirthday.Text = "";
                    dtpCheckin.Text = "";
                    dtpDateOfOutcome.Text = "";
                    dtpOutcome.Text = "";

                    started_passed = false;
                    Starter();
                    //----------------

                    bSave.Text = "Оформить бронирование";
                    bSave.Visible = true;

                    break;

           }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void AddNewBooking_Load(object sender, EventArgs e)
        {
            Starter();
        }

        public void Starter()
        {
            if (!started_passed)
            {
                string id_gen = "";
                string gen_part = "";
                Random rnd = new Random();

                for (int i = 0; i < 7; i++)
                {
                    gen_part += GenByAlphabet(rnd.Next(0, 26));
                }

                txtID.Text = GenByDate();
                txtToday.Text = "Дата бронирования: (сегодня): " + DateTime.Today.ToShortDateString();

                cmbBookingStatus.SelectedIndex = 0;
                cmbBookingSource.SelectedIndex = 0;
                cmbMealType.SelectedIndex = 0;
                RoomGen();

                if (cmbRoomDatabaseSelector.Items.Count > 0)
                {
                    cmbRoomDatabaseSelector.SelectedIndex = 0;
                }

                //Program.bl.BookingList_LoadXSD();
                //Program.bl.Show();

                isShown = true;
                started_passed = true;
            }
            

        }

        string GenByDate()
        {
            string dtnow = DateTime.Now.ToString();
            dtnow = dtnow.Replace(":", "");
            dtnow = dtnow.Replace(" ", "");
            dtnow = dtnow.Replace("_", "");
            dtnow = dtnow.Replace("-", "");
            dtnow = dtnow.Replace(" ", "");
            dtnow = dtnow.Replace(".", "");

            return "ID бронирования: " + dtnow;
        }

        char GenByAlphabet(int num)
        {
            if (num >= 1)
            {
                if (num <= 26)
                {
                    return (char)(64 + num);
                }
            }
            else if (num > 26)
            {
                return (char)(97 + num);
            }
            return (char)(0);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.WindowState = FormWindowState.Minimized;
        }

        void RoomGen()
        {
            int rows_non_empty = 0;

            for (int i = 0; i<Program.db.dgvDatabase.Rows.Count;i++)
            {
                if (Program.db.dgvDatabase[0,i].Value != null)
                {
                    if(Program.db.dgvDatabase[0, i].Value.ToString() != "" || Program.db.dgvDatabase[0,i].Value.ToString() != " ")
                    {
                        rows_non_empty++;
                    }
                }
            }
            for (int j = 0; j< rows_non_empty; j++)
            {
                cmbRoomDatabaseSelector.Items.Add(Program.db.dgvDatabase[1, j].Value.ToString() + " (" + Program.db.dgvDatabase[2, j].Value.ToString() + " + " + Program.db.dgvDatabase[3, j].Value.ToString() + ")" + " [ ID:= " + Program.db.dgvDatabase[0, j].Value.ToString() + " ]");
            }
  
        }

        private void bSet10Hours_Click(object sender, EventArgs e)
        {
            nudHour.Value = 12;
        }

        private void bSet12Hours_Click(object sender, EventArgs e)
        {
            nudHour.Value = 13;
        }

        private void bSet30Minute_Click(object sender, EventArgs e)
        {
            nudMinute.Value = 30;
        }

        private void bSet45Minute_Click(object sender, EventArgs e)
        {
            nudMinute.Value = 45;
        }

        private void txtSN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSN_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtSN.TextLength >= 4)
            {
                if (e.KeyCode == Keys.Back)
                {
                    e.SuppressKeyPress = false;
                }
                else if (e.KeyCode == Keys.Left)
                {
                    e.SuppressKeyPress = false;
                }
                else if (e.KeyCode == Keys.Right)
                {
                    e.SuppressKeyPress = false;
                }
                else
                {
                    e.SuppressKeyPress = true;
                }

            }

        }
        private void txtSN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            char first = txtSN.Text[0];
            char second = txtSN.Text[1];

            string OKATO = first.ToString() + second.ToString();

            string msg1 = "Данные по серии: " + Environment.NewLine;
            string msg2 = "Номер региона (ОКАТО): ";
            string msg3 = "Название региона: ";
            string msg4 = "Административный центр: ";

            switch (OKATO)
            {
                case "01":
                    rtfPassportChecks.Text = msg1 + msg2 + "01" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Алтайский край" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Барнаул" + Environment.NewLine;
                    break;
                case "03":
                    rtfPassportChecks.Text = msg1 + msg2 + "03" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Краснодарский край" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Краснодар" + Environment.NewLine;
                    break;
                case "04":
                    rtfPassportChecks.Text = msg1 + msg2 + "04" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Красноярский край" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Красноярск" + Environment.NewLine;
                    break;
                case "05":
                    rtfPassportChecks.Text = msg1 + msg2 + "05" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Приморский край" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Владивосток" + Environment.NewLine;
                    break;
                case "07":
                    rtfPassportChecks.Text = msg1 + msg2 + "07" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Ставропольский край" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Ставрополь" + Environment.NewLine;
                    break;
                case "08":
                    rtfPassportChecks.Text = msg1 + msg2 + "08" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Хабаровский край" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Хабаровск" + Environment.NewLine;
                    break;
                case "10":
                    rtfPassportChecks.Text = msg1 + msg2 + "10" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Амурская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Благовещенск" + Environment.NewLine;
                    break;
                case "11":
                    rtfPassportChecks.Text = msg1 + msg2 + "11" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Архангельская область (возможно, Ненецкий автономный округ)" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Архангельск / г. Нарьян-Мар" + Environment.NewLine;
                    break;
                case "12":
                    rtfPassportChecks.Text = msg1 + msg2 + "12" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Астраханская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Астрахань" + Environment.NewLine;
                    break;
                case "14":
                    rtfPassportChecks.Text = msg1 + msg2 + "14" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Белгородская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Белгород" + Environment.NewLine;
                    break;
                case "15":
                    rtfPassportChecks.Text = msg1 + msg2 + "15" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Брянская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Брянск" + Environment.NewLine;
                    break;
                case "17":
                    rtfPassportChecks.Text = msg1 + msg2 + "17" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Владимирская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Владимир" + Environment.NewLine;
                    break;
                case "18":
                    rtfPassportChecks.Text = msg1 + msg2 + "18" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Волгоградская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Волгоград" + Environment.NewLine;
                    break;
                case "19":
                    rtfPassportChecks.Text = msg1 + msg2 + "19" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Вологодская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Вологда" + Environment.NewLine;
                    break;
                case "20":
                    rtfPassportChecks.Text = msg1 + msg2 + "20" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Воронежская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Воронеж" + Environment.NewLine;
                    break;
                case "22":
                    rtfPassportChecks.Text = msg1 + msg2 + "22" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Нижегородская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Нижний Новгород" + Environment.NewLine;
                    break;
                case "24":
                    rtfPassportChecks.Text = msg1 + msg2 + "24" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Ивановская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Иваново" + Environment.NewLine;
                    break;
                case "25":
                    rtfPassportChecks.Text = msg1 + msg2 + "25" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Иркутская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Иркутск" + Environment.NewLine;
                    break;
                case "26":
                    rtfPassportChecks.Text = msg1 + msg2 + "26" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Республика Ингушетия" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Магас" + Environment.NewLine;
                    break;
                case "27":
                    rtfPassportChecks.Text = msg1 + msg2 + "27" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Калининградская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Калининград" + Environment.NewLine;
                    break;
                case "28":
                    rtfPassportChecks.Text = msg1 + msg2 + "28" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Тверская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Тверь" + Environment.NewLine;
                    break;
                case "29":
                    rtfPassportChecks.Text = msg1 + msg2 + "29" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Калужская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Калуга" + Environment.NewLine;
                    break;
                case "30":
                    rtfPassportChecks.Text = msg1 + msg2 + "30" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Камчатский край" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Петропавловск-Камчатский" + Environment.NewLine;
                    break;
                case "32":
                    rtfPassportChecks.Text = msg1 + msg2 + "32" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Кемеровская область - Кузбасс" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Кемерово" + Environment.NewLine;
                    break;
                case "33":
                    rtfPassportChecks.Text = msg1 + msg2 + "33" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Кировская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Киров" + Environment.NewLine;
                    break;
                case "34":
                    rtfPassportChecks.Text = msg1 + msg2 + "34" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Костромская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Кострома" + Environment.NewLine;
                    break;
                case "35":
                    rtfPassportChecks.Text = msg1 + msg2 + "35" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Республика Крым" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Симферополь" + Environment.NewLine;
                    break;
                case "36":
                    rtfPassportChecks.Text = msg1 + msg2 + "36" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Самарская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Самара" + Environment.NewLine;
                    break;
                case "37":
                    rtfPassportChecks.Text = msg1 + msg2 + "37" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Курганская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Курган" + Environment.NewLine;
                    break;
                case "38":
                    rtfPassportChecks.Text = msg1 + msg2 + "38" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Курская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Курск" + Environment.NewLine;
                    break;
                case "40":
                    rtfPassportChecks.Text = msg1 + msg2 + "40" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Город Федерального значения" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Санкт-Петербург" + Environment.NewLine;
                    break;
                case "41":
                    rtfPassportChecks.Text = msg1 + msg2 + "41" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Ленинградская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Санкт-Петербург" + Environment.NewLine;
                    break;
                case "42":
                    rtfPassportChecks.Text = msg1 + msg2 + "42" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Липецкая область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Липецк" + Environment.NewLine;
                    break;
                case "44":
                    rtfPassportChecks.Text = msg1 + msg2 + "44" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Магаданская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Магадан" + Environment.NewLine;
                    break;
                case "45":
                    rtfPassportChecks.Text = msg1 + msg2 + "45" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Столица, город федерального значения" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Москва" + Environment.NewLine;
                    break;
                case "46":
                    rtfPassportChecks.Text = msg1 + msg2 + "46" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Московская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Москва" + Environment.NewLine;
                    break;
                case "47":
                    rtfPassportChecks.Text = msg1 + msg2 + "47" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Мурманская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Мурманск" + Environment.NewLine;
                    break;
                case "49":
                    rtfPassportChecks.Text = msg1 + msg2 + "49" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Новгородская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Новгород" + Environment.NewLine;
                    break;
                case "50":
                    rtfPassportChecks.Text = msg1 + msg2 + "50" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Новосибирская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Новосибирск" + Environment.NewLine;
                    break;
                case "52":
                    rtfPassportChecks.Text = msg1 + msg2 + "52" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Омская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Омск" + Environment.NewLine;
                    break;
                case "53":
                    rtfPassportChecks.Text = msg1 + msg2 + "53" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Оренбургская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Оренбург" + Environment.NewLine;
                    break;
                case "54":
                    rtfPassportChecks.Text = msg1 + msg2 + "54" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Орловская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Орёл" + Environment.NewLine;
                    break;
                case "56":
                    rtfPassportChecks.Text = msg1 + msg2 + "56" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Пензенская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Пенза" + Environment.NewLine;
                    break;
                case "57":
                    rtfPassportChecks.Text = msg1 + msg2 + "57" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Пермский край" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Пермь" + Environment.NewLine;
                    break;
                case "58":
                    rtfPassportChecks.Text = msg1 + msg2 + "58" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Псковская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Псков" + Environment.NewLine;
                    break;
                case "60":
                    rtfPassportChecks.Text = msg1 + msg2 + "60" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Ростовская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Ростов-на-Дону" + Environment.NewLine;
                    break;
                case "61":
                    rtfPassportChecks.Text = msg1 + msg2 + "61" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Рязанская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Рязань" + Environment.NewLine;
                    break;
                case "63":
                    rtfPassportChecks.Text = msg1 + msg2 + "63" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Саратовская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Саратов" + Environment.NewLine;
                    break;
                case "64":
                    rtfPassportChecks.Text = msg1 + msg2 + "64" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Сахалинская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Южно-Сахалинск" + Environment.NewLine;
                    break;
                case "65":
                    rtfPassportChecks.Text = msg1 + msg2 + "65" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Свердловская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Екатеринбург" + Environment.NewLine;
                    break;
                case "66":
                    rtfPassportChecks.Text = msg1 + msg2 + "66" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Смоленская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Смоленск" + Environment.NewLine;
                    break;
                case "67":
                    rtfPassportChecks.Text = msg1 + msg2 + "67" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Город федерального значения" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Севастополь" + Environment.NewLine;
                    break;
                case "68":
                    rtfPassportChecks.Text = msg1 + msg2 + "68" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Тамбовская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Тамбов" + Environment.NewLine;
                    break;
                case "69":
                    rtfPassportChecks.Text = msg1 + msg2 + "69" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Томская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Томск" + Environment.NewLine;
                    break;
                case "70":
                    rtfPassportChecks.Text = msg1 + msg2 + "70" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Тульская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Тула" + Environment.NewLine;
                    break;
                case "71":
                    rtfPassportChecks.Text = msg1 + msg2 + "71" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Тюменская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Тюмень" + Environment.NewLine;
                    break;
                case "73":
                    rtfPassportChecks.Text = msg1 + msg2 + "73" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Ульяновская область " + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Ульяновск" + Environment.NewLine;
                    break;
                case "75":
                    rtfPassportChecks.Text = msg1 + msg2 + "75" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Челябинская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Челябинск" + Environment.NewLine;
                    break;
                case "76":
                    rtfPassportChecks.Text = msg1 + msg2 + "76" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Забайкальский край" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Чита" + Environment.NewLine;
                    break;
                case "77":
                    rtfPassportChecks.Text = msg1 + msg2 + "77" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Чукотский автономный округ" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Анадырь" + Environment.NewLine;
                    break;
                case "78":
                    rtfPassportChecks.Text = msg1 + msg2 + "78" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Ярославская область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Ярославль" + Environment.NewLine;
                    break;
                case "79":
                    rtfPassportChecks.Text = msg1 + msg2 + "79" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Республика Адыгея(Адыгея)" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Майкоп" + Environment.NewLine;
                    break;
                case "80":
                    rtfPassportChecks.Text = msg1 + msg2 + "80" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Республика Башкортостан" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Уфа" + Environment.NewLine;
                    break;
                case "81":
                    rtfPassportChecks.Text = msg1 + msg2 + "81" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Республика Бурятия" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Улан-Удэ" + Environment.NewLine;
                    break;
                case "82":
                    rtfPassportChecks.Text = msg1 + msg2 + "82" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Республика Дагестан" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Махачкала" + Environment.NewLine;
                    break;
                case "83":
                    rtfPassportChecks.Text = msg1 + msg2 + "83" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Кабардино - Балкарская Республика" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Нальчик" + Environment.NewLine;
                    break;
                case "84":
                    rtfPassportChecks.Text = msg1 + msg2 + "84" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Республика Алтай" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Горно-Алтайск" + Environment.NewLine;
                    break;
                case "85":
                    rtfPassportChecks.Text = msg1 + msg2 + "85" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Республика Калмыкия" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Элиста" + Environment.NewLine;
                    break;
                case "86":
                    rtfPassportChecks.Text = msg1 + msg2 + "86" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Республика Карелия" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Петрозаводск" + Environment.NewLine;
                    break;
                case "87":
                    rtfPassportChecks.Text = msg1 + msg2 + "87" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Республика Коми" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Сыктывкар" + Environment.NewLine;
                    break;
                case "88":
                    rtfPassportChecks.Text = msg1 + msg2 + "88" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Республика Марий Эл" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Йошкар - Ола" + Environment.NewLine;
                    break;
                case "89":
                    rtfPassportChecks.Text = msg1 + msg2 + "89" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Республика Мордовия" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Саранск" + Environment.NewLine;
                    break;
                case "90":
                    rtfPassportChecks.Text = msg1 + msg2 + "90" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Республика Северная Осетия-Алания" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Владикавказ" + Environment.NewLine;
                    break;
                case "91":
                    rtfPassportChecks.Text = msg1 + msg2 + "91" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Карачаево-Черкесская Республика " + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Черкесск" + Environment.NewLine;
                    break;
                case "92":
                    rtfPassportChecks.Text = msg1 + msg2 + "92" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Республика Татарстан (Татарстан) " + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Казань" + Environment.NewLine;
                    break;
                case "93":
                    rtfPassportChecks.Text = msg1 + msg2 + "93" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Республика Тыва" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Кызыл" + Environment.NewLine;
                    break;
                case "94":
                    rtfPassportChecks.Text = msg1 + msg2 + "94" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Удмуртская Республика" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Ижевск" + Environment.NewLine;
                    break;
                case "95":
                    rtfPassportChecks.Text = msg1 + msg2 + "95" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Республика Хакасия" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Абакан" + Environment.NewLine;
                    break;
                case "96":
                    rtfPassportChecks.Text = msg1 + msg2 + "96" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Чеченская Республика" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Грозный" + Environment.NewLine;
                    break;
                case "97":
                    rtfPassportChecks.Text = msg1 + msg2 + "97" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Чувашская Республика - Чуваши" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Чебоксары" + Environment.NewLine;
                    break;
                case "98":
                    rtfPassportChecks.Text = msg1 + msg2 + "98" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Республика Саха (Якутия)" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Якутск" + Environment.NewLine;
                    break;
                case "99":
                    rtfPassportChecks.Text = msg1 + msg2 + "99" + Environment.NewLine;
                    rtfPassportChecks.Text += msg3 + "Еврейская автономная область" + Environment.NewLine;
                    rtfPassportChecks.Text += msg4 + "г. Биробиджан" + Environment.NewLine;
                    break;
                default:
                    rtfPassportChecks.Text = msg1 + msg2 + Environment.NewLine + "Проверка по коду ОКАТО не пройдена! Паспорт не может быть действительным" + Environment.NewLine;
                    Program.pvc.error_bits[0] = Program.pvc.error_bits[0] * 0;
                    break;
            }

            char third = txtSN.Text[2];
            char fourth = txtSN.Text[3];

            string year = third.ToString() + fourth.ToString();
            int year_c = Int16.Parse(year);

            if (year_c >= 97 && year_c <= 99)
            {
                year_c += 1900;
            }
            else
            {
                year_c += 2000;
            }

            rtfPassportChecks.Text += "Год печати бланка для паспорта: " + year_c.ToString() + Environment.NewLine;

            int year_d = dtpDateOfOutcome.Value.Year - year_c;
            if (year_d <= 3 && year_d > -5)
            {
                rtfPassportChecks.Text += "Серия паспорта соответствует требованиям" + Environment.NewLine;
            }
            else
            {
                rtfPassportChecks.Text += "Серия из прошлого или будушего - паспорт недействительный" + Environment.NewLine;
            }

            txtWhomItWasGiven.Text.ToUpper();
            if (txtWhomItWasGiven.Text.Contains("ОБЛАСТИ"))
            {
                txtWhomItWasGiven.Text.Replace("ОБЛАСТИ", "ОБЛ.");
            }
            if (txtWhomItWasGiven.Text.Contains("ОТДЕЛОМ ВНУТРЕННИХ ДЕЛ"))
            {
                txtWhomItWasGiven.Text.Replace("ОТДЕЛОМ ВНУТРЕННИХ ДЕЛ", "ОВД");
            }
            if (txtWhomItWasGiven.Text.Contains("ГОР."))
            {
                txtWhomItWasGiven.Text.Replace("ГОР.", "Г.");
            }

            if (txtWhomItWasGiven.Text.Contains("Г.А"))
            {
                txtWhomItWasGiven.Text.Replace("Г.А", "Г. А");
            }
            else if (txtWhomItWasGiven.Text.Contains("Г.Б"))
            {
                txtWhomItWasGiven.Text.Replace("Г.Б", "Г. Б");
            }
            else if (txtWhomItWasGiven.Text.Contains("Г.В"))
            {
                txtWhomItWasGiven.Text.Replace("Г.В", "Г. В");
            }
            else if (txtWhomItWasGiven.Text.Contains("Г.Г"))
            {
                txtWhomItWasGiven.Text.Replace("Г.Г", "Г. Г");
            }
            else if (txtWhomItWasGiven.Text.Contains("Г.Д"))
            {
                txtWhomItWasGiven.Text.Replace("Г.Д", "Г. Д");
            }
            else if (txtWhomItWasGiven.Text.Contains("Г.Е"))
            {
                txtWhomItWasGiven.Text.Replace("Г.Е", "Г. Е");
            }
            else if (txtWhomItWasGiven.Text.Contains("Г.Ё"))
            {
                txtWhomItWasGiven.Text.Replace("Г.Ё", "Г. Ё");
            }
            else if (txtWhomItWasGiven.Text.Contains("Г.Ж"))
            {
                txtWhomItWasGiven.Text.Replace("Г.Ж", "Г. Ж");
            }
            else if (txtWhomItWasGiven.Text.Contains("Г.З"))
            {
                txtWhomItWasGiven.Text.Replace("Г.З", "Г. З");
            }
            else if (txtWhomItWasGiven.Text.Contains("Г.И"))
            {
                txtWhomItWasGiven.Text.Replace("Г.И", "Г. И");
            }
            else if (txtWhomItWasGiven.Text.Contains("Г.К"))
            {
                txtWhomItWasGiven.Text.Replace("Г.К", "Г. К");
            }
            else if (txtWhomItWasGiven.Text.Contains("Г.Л"))
            {
                txtWhomItWasGiven.Text.Replace("Г.Л", "Г. Л");
            }
            else if (txtWhomItWasGiven.Text.Contains("Г.М"))
            {
                txtWhomItWasGiven.Text.Replace("Г.М", "Г. М");
            }
            else if (txtWhomItWasGiven.Text.Contains("Г.Н"))
            {
                txtWhomItWasGiven.Text.Replace("Г.Н", "Г. Н");
            }
            else if (txtWhomItWasGiven.Text.Contains("Г.О"))
            {
                txtWhomItWasGiven.Text.Replace("Г.О", "Г. О");
            }
            else if (txtWhomItWasGiven.Text.Contains("Г.П"))
            {
                txtWhomItWasGiven.Text.Replace("Г.П", "Г. П");
            }
            else if (txtWhomItWasGiven.Text.Contains("Г.Р"))
            {
                txtWhomItWasGiven.Text.Replace("Г.Р", "Г. Р");
            }
            else if (txtWhomItWasGiven.Text.Contains("Г.С"))
            {
                txtWhomItWasGiven.Text.Replace("Г.С", "Г. С");
            }
            else if (txtWhomItWasGiven.Text.Contains("Г.Т"))
            {
                txtWhomItWasGiven.Text.Replace("Г.Т", "Г. Т");
            }
            else if (txtWhomItWasGiven.Text.Contains("Г.У"))
            {
                txtWhomItWasGiven.Text.Replace("Г.У", "Г. У");
            }
            else if (txtWhomItWasGiven.Text.Contains("Г.Ф"))
            {
                txtWhomItWasGiven.Text.Replace("Г.Ф", "Г. Ф");
            }
            else if (txtWhomItWasGiven.Text.Contains("Г.Х"))
            {
                txtWhomItWasGiven.Text.Replace("Г.Х", "Г. Х");
            }
            else if (txtWhomItWasGiven.Text.Contains("Г.Ц"))
            {
                txtWhomItWasGiven.Text.Replace("Г.Ц", "Г. Ц");
            }
            else if (txtWhomItWasGiven.Text.Contains("Г.Ч"))
            {
                txtWhomItWasGiven.Text.Replace("Г.Ч", "Г. Ч");
            }
            else if (txtWhomItWasGiven.Text.Contains("Г.Ш"))
            {
                txtWhomItWasGiven.Text.Replace("Г.Ш", "Г. Ш");
            }
            else if (txtWhomItWasGiven.Text.Contains("Г.Щ"))
            {
                txtWhomItWasGiven.Text.Replace("Г.Щ", "Г. Щ");
            }
            else if (txtWhomItWasGiven.Text.Contains("Г.Ы"))
            {
                txtWhomItWasGiven.Text.Replace("Г.Ы", "Г. Ы");
            }
            else if (txtWhomItWasGiven.Text.Contains("Г.Э"))
            {
                txtWhomItWasGiven.Text.Replace("Г.Э", "Г. Э");
            }
            else if (txtWhomItWasGiven.Text.Contains("Г.Ю"))
            {
                txtWhomItWasGiven.Text.Replace("Г.Ю", "Г. Ю");
            }
            else if (txtWhomItWasGiven.Text.Contains("Г.Я"))
            {
                txtWhomItWasGiven.Text.Replace("Г.Я", "Г. Я");
            }

            int t_code = Int16.Parse(txtCodeU1.Text[2].ToString());

            rtfPassportChecks.Text += "Проверка типа подразделения, выдавшего паспорт:" + Environment.NewLine;
            switch (t_code)
            {

                case 0:
                    {
                        rtfPassportChecks.Text += "Отдел УФМС России" + Environment.NewLine;
                    }
                    break;

                case 1:
                    {
                        rtfPassportChecks.Text += "Отдел ГУВД или МВД региона" + Environment.NewLine;
                    }
                    break;

                case 2:
                    {
                        rtfPassportChecks.Text += "УВД или ОВД района или города" + Environment.NewLine;
                    }
                    break;

                case 3:
                    {
                        rtfPassportChecks.Text += "Отделение полиции (обычно в посёлке, деревне, селе)" + Environment.NewLine;
                    }
                    break;
                default:
                    {
                        rtfPassportChecks.Text += Environment.NewLine + "НЕ удалось проверить тип подразделения! Недействительный контрольный код" + Environment.NewLine;
                    
                    }
                    break;
            }

            rtfPassportChecks.Text += Environment.NewLine + "Проверка номера паспорта:" + Environment.NewLine;

            int num_passport = Int32.Parse(txtNum.Text);
            if (num_passport >= 000101 && num_passport <= 999999)
            {
                rtfPassportChecks.Text += "Номер пасспорта соответствует требованиям" + Environment.NewLine;
            }
            else
            {
                rtfPassportChecks.Text += "Несуществующий номер: допускается от 000101 до 999999" + Environment.NewLine;
            }

            int const_fz_num = Int16.Parse(txtCodeU1.Text[0].ToString() + txtCodeU1.Text[1].ToString());
            string csvfc = Program.csf.CSV_CheckForConst(txtCodeU1.Text[0].ToString() + txtCodeU1.Text[1].ToString());

            rtfPassportChecks.Text += "Данные субъекта по номеру паспорта: код " + txtNum.Text[0].ToString() + txtNum.Text[1].ToString() + ", " + csvfc + Environment.NewLine;

            if (csvfc == "81")
            {
                rtfPassportChecks.Text += "Код 81 принадлежал Коми-Пермяцкому автономному округу, который в 2005 году был включен в состав Пермского края" + Environment.NewLine;
            }
            else if (csvfc == "82")
            {
                rtfPassportChecks.Text += "Код 82 принадлежал Корякскому автономному округу, который в 2007 году был включен в состав Камчатского края.В 2014 году освободившийся код был выделен вступившей в состав Российской Федерации Республике Крым" + Environment.NewLine;
            }
            else if (csvfc == "84")
            {
                rtfPassportChecks.Text += "Код 84 принадлежал Таймырскому(Долгано-Ненецкому) автономному округу, который в 2007 году был включен в состав Красноярского края" + Environment.NewLine;
            }
            else if (csvfc == "85")
            {
                rtfPassportChecks.Text += "Код 85 принадлежал Усть-Ордынскому Бурятскому автономному округу, который в 2008 году был включен в состав Иркутской области" + Environment.NewLine;
            }
            else if (csvfc == "88")
            {
                rtfPassportChecks.Text += "Код 88 принадлежал Эвенкийскому автономному округу, который в 2007 году был включен в состав Красноярского края" + Environment.NewLine;
            }

            else if (csvfc == "59")
            {
                rtfPassportChecks.Text += "В тексте конституции по состоянию на 1992 год Пермский край назывался Пермской областью" + Environment.NewLine;
            }
            else if (csvfc == "41")
            {
                rtfPassportChecks.Text += "В тексте конституции по состоянию на 1992 год Камчатский край назывался Камчатской областью" + Environment.NewLine;
            }
            else if (csvfc == "75")
            {
                rtfPassportChecks.Text += "В тексте конституции по состоянию на 1992 год Забайкальский край назывался Читинской областью." + Environment.NewLine;
            }
            else if (csvfc == "88")
            {
                rtfPassportChecks.Text += "Код 88 принадлежал Эвенкийскому автономному округу, который в 2007 году был включен в состав Красноярского края" + Environment.NewLine;
            }
            else if (csvfc == "04" | csvfc == "4")
            {
                rtfPassportChecks.Text += "В тексте конституции по состоянию на 1992 год Республика Алтай называлась Горным Алтаем" + Environment.NewLine;
            }

            rtfPassportChecks.Text += Environment.NewLine + "Проверка возраста:" + Environment.NewLine;

            int age = Int16.Parse((DateTime.Now.Year - dtpBirthday.Value.Year).ToString());

            if (age < 14)
            {
                rtfPassportChecks.Text += "Паспорт невозможно выдать ребёнку до 14 лет" + Environment.NewLine;
            }
            else if (age >= 14 && age < 20)
            {
                rtfPassportChecks.Text += "Первый паспорт: выдан человеку с 14 до 20 лет" + Environment.NewLine;
                DateTime calc = new DateTime();
                calc = dtpBirthday.Value;

                int calc_b = dtpBirthday.Value.Year;
                int calc_o = dtpDateOfOutcome.Value.Year;

                calc_o -= calc_b;
                calc.AddYears(-calc_o);

                var calc2 = (dtpDateOfOutcome.Value - dtpBirthday.Value).Duration();
                if (calc2.Days >= 31)
                {
                    rtfPassportChecks.Text += "Паспорт получен с просрочкой" + Environment.NewLine;
                }
                else
                {
                    rtfPassportChecks.Text += "Первый не был просрочен" + Environment.NewLine;
                }
                int age_diff = dtpBirthday.Value.Year + 14;

                if (age_diff >= dtpBirthday.Value.Year + 14 && age_diff <= dtpBirthday.Value.Year + 20)
                {
                    rtfPassportChecks.Text += "В данный момент паспорт не просрочен" + Environment.NewLine;
                }
                else
                {
                    rtfPassportChecks.Text += "В данный момент паспорт ЯВЛЯЕТСЯ ПРОСРОЧЕННЫМ" + Environment.NewLine;
                }
            }
            else if (age >= 20 && age < 45)
            {
                rtfPassportChecks.Text += "Второй паспорт: выдан человеку с 20 до 45 лет" + Environment.NewLine;
                DateTime calc = new DateTime();
                calc = dtpBirthday.Value;

                int calc_b = dtpBirthday.Value.Year;
                int calc_o = dtpDateOfOutcome.Value.Year;

                calc_o -= calc_b;
                calc.AddYears(-calc_o);

                var calc2 = (dtpDateOfOutcome.Value - dtpBirthday.Value).Duration();
                if (calc2.Days >= 31)
                {
                    rtfPassportChecks.Text += "Паспорт получен с просрочкой" + Environment.NewLine;
                }
                else
                {
                    rtfPassportChecks.Text += "Первый не был просрочен" + Environment.NewLine;
                }
                int age_diff = dtpBirthday.Value.Year + 20;

                if (age_diff >= dtpBirthday.Value.Year + 20 && age_diff <= dtpBirthday.Value.Year + 45)
                {
                    rtfPassportChecks.Text += "В данный момент паспорт не просрочен" + Environment.NewLine;
                }
                else
                {
                    rtfPassportChecks.Text += "В данный момент паспорт ЯВЛЯЕТСЯ ПРОСРОЧЕННЫМ" + Environment.NewLine;
                }
            }
            else if (age >= 45)
            {
                rtfPassportChecks.Text += "Третий паспорт: выдан человеку с 45 лет" + Environment.NewLine;
                DateTime calc = new DateTime();
                calc = dtpBirthday.Value;

                int calc_b = dtpBirthday.Value.Year;
                int calc_o = dtpDateOfOutcome.Value.Year;

                calc_o -= calc_b;
                calc.AddYears(-calc_o);

                var calc2 = (dtpDateOfOutcome.Value - dtpBirthday.Value).Duration();
                if (calc2.Days >= 31)
                {
                    rtfPassportChecks.Text += "Паспорт получен с просрочкой" + Environment.NewLine;
                }
                else
                {
                    rtfPassportChecks.Text += "Первый не был просрочен" + Environment.NewLine;
                }
                int age_diff = dtpBirthday.Value.Year + 45;

                if (age_diff >= dtpBirthday.Value.Year + 45)
                {
                    rtfPassportChecks.Text += "В данный момент паспорт не просрочен" + Environment.NewLine;
                }
                else
                {
                    rtfPassportChecks.Text += "В данный момент паспорт ЯВЛЯЕТСЯ ПРОСРОЧЕННЫМ" + Environment.NewLine;
                }
            }
            else
            {
                rtfPassportChecks.Text += "Невозможно проверить паспорт по дате рождения! Вероятно, она некорректная" + Environment.NewLine;
            }

            if (Program.csf.CSV_UnitCodeFullMatching(txtCodeU1.Text + "-" + txtCodeU2.Text, txtWhomItWasGiven.Text.ToUpper()))
            {
                rtfPassportChecks.Text += "Полное совпадение кода подразделения и наименование выдающего центра" + Environment.NewLine;
            }
            else
            {
                rtfPassportChecks.Text += "Есть расхождения в коде подразделения и наименовании выдающего центра:" + Environment.NewLine + Environment.NewLine;
                rtfPassportChecks.Text += "Заявлено: Код подразделения = " + txtCodeU1.Text + "-" + txtCodeU2.Text + Environment.NewLine;
                rtfPassportChecks.Text += "Данный код подразделения принадлежит: " + Program.csf.CSV_UnitCode_getNameByCode(txtCodeU1.Text + "-" + txtCodeU2.Text) + Environment.NewLine + Environment.NewLine;
                rtfPassportChecks.Text += "Также заявлено: Выдан = " + txtWhomItWasGiven.Text + Environment.NewLine;
                rtfPassportChecks.Text += "Данному подразделению назначен код: " + Program.csf.CSV_UnitCode_getCodeByName(txtWhomItWasGiven.Text) + Environment.NewLine;
            }
            rtfPassportChecks.Text += Environment.NewLine + "Проверка по номеру:" + Environment.NewLine + "Проверка по базе недействительных паспортов:" + Environment.NewLine;

            if (Program.csf.CSV_CheckForInvalidPassport(txtSN.Text, txtNum.Text) == true)
            {
                rtfPassportChecks.Text += "Паспорт НЕДЕЙСТВИТЕЛЕН!" + Environment.NewLine + Environment.NewLine + "ВНИМАНИЕ! Данный паспорт не прошёл проверку на подлинность! Он должен был быть изъят, сдан, уничтожен" + Environment.NewLine + "Паспорт был проверен по локальной базе данных недействительных паспортов, полученной из открытых источников МВД" + Environment.NewLine + "Требуется обязательная перепроверка в онлайн-источниках!" + Environment.NewLine;
            }
            else
            {
                rtfPassportChecks.Text += "Паспорт действителен, отсутствует в локальной базе недействительных паспортов, полученной из открытых источников МВД" + Environment.NewLine;
            }

        }

        private void rtfPassportChecks_Click(object sender, EventArgs e)
        {
            //Program.rtffsv.rtfText.Text = rtfPassportChecks.Text;

            //if (Program.rtffsv.isShown)
            //{
            //    Program.rtffsv.WindowState = FormWindowState.Normal;
            //    Program.rtffsv.Visible = true;
            //    Program.rtffsv.Focus();
            //    Program.rtffsv.BringToFront();
            //}
            //else
            //{
            //    Program.rtffsv.Show();
            //}

            RTFFullScreenViewer rtfsv = new RTFFullScreenViewer(rtfPassportChecks.Text);
            rtfsv.Show();
        }

        private void txtNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtNum.TextLength >= 6)
            {
                if (e.KeyCode == Keys.Back)
                {
                    e.SuppressKeyPress = false;
                }
                else if (e.KeyCode == Keys.Left)
                {
                    e.SuppressKeyPress = false;
                }
                else if (e.KeyCode == Keys.Right)
                {
                    e.SuppressKeyPress = false;
                }
                else
                {
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodeU1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodeU2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodeU1_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtCodeU1.TextLength >= 3)
            {
                if (e.KeyCode == Keys.Back)
                {
                    e.SuppressKeyPress = false;
                }
                else if (e.KeyCode == Keys.Left)
                {
                    e.SuppressKeyPress = false;
                }
                else if (e.KeyCode == Keys.Right)
                {
                    e.SuppressKeyPress = false;
                }
                else
                {
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void txtCodeU2_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtCodeU2.TextLength >= 3)
            {
                if (e.KeyCode == Keys.Back)
                {
                    e.SuppressKeyPress = false;
                }
                else if (e.KeyCode == Keys.Left)
                {
                    e.SuppressKeyPress = false;
                }
                else if (e.KeyCode == Keys.Right)
                {
                    e.SuppressKeyPress = false;
                }
                else
                {
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void bSet15Minute_Click(object sender, EventArgs e)
        {
            nudMinute.Value = 15;
        }

        private void bSet14Hours_Click(object sender, EventArgs e)
        {
            nudHour.Value = 14;
        }

        private void nudHour_ValueChanged(object sender, EventArgs e)
        {
            switch (nudHour.Value)
            {
                case 0: HoursText.Text = "часов";
                    break;
                case 1: HoursText.Text = "час";
                    break;
                case 2: HoursText.Text = "часа";
                    break;
                case 3: HoursText.Text = "часа";
                    break;
                case 4: HoursText.Text = "часа";
                    break;
                case 5: HoursText.Text = "часов";
                    break;
                case 6: HoursText.Text = "часов";
                    break;
                case 7: HoursText.Text = "часов";
                    break;
                case 8: HoursText.Text = "часов";
                    break;
                case 9: HoursText.Text = "часов";
                    break;
                case 10: HoursText.Text = "часов";
                    break;
                case 11: HoursText.Text = "часов";
                    break;
                case 12: HoursText.Text = "часов";
                    break;
                case 13: HoursText.Text = "часов";
                    break;
                case 14: HoursText.Text = "часов";
                    break;
                case 15: HoursText.Text = "часов";
                    break;
                case 16: HoursText.Text = "часов";
                    break;
                case 17: HoursText.Text = "часов";
                    break;
                case 18: HoursText.Text = "часов";
                    break;
                case 19: HoursText.Text = "часов";
                    break;
                case 20: HoursText.Text = "часов";
                    break;
                case 21: HoursText.Text = "час";
                    break;
                case 22: HoursText.Text = "часа";
                    break;
                case 23: HoursText.Text = "часа";
                    break;
                default:
                    HoursText.Text = "часов";
                    break;
            }
        }

        private void nudMinute_ValueChanged(object sender, EventArgs e)
        {
            switch (nudMinute.Value)
            {
                case 1:
                    MinutesText.Text = "минута";
                    break;
                case 2:
                    MinutesText.Text = "минуты";
                    break;
                case 3:
                    MinutesText.Text = "минуты";
                    break;
                case 4:
                    MinutesText.Text = "минуты";
                    break;

                case 21:
                    MinutesText.Text = "минута";
                    break;
                case 22:
                    MinutesText.Text = "минуты";
                    break;
                case 23:
                    MinutesText.Text = "минуты";
                    break;
                case 24:
                    MinutesText.Text = "минуты";
                    break;


                case 31:
                    MinutesText.Text = "минута";
                    break;
                case 32:
                    MinutesText.Text = "минуты";
                    break;
                case 33:
                    MinutesText.Text = "минуты";
                    break;
                case 34:
                    MinutesText.Text = "минуты";
                    break;

                case 41:
                    MinutesText.Text = "минута";
                    break;
                case 42:
                    MinutesText.Text = "минуты";
                    break;
                case 43:
                    MinutesText.Text = "минуты";
                    break;
                case 44:
                    MinutesText.Text = "минуты";
                    break;

                case 51:
                    MinutesText.Text = "минута";
                    break;
                case 52:
                    MinutesText.Text = "минуты";
                    break;
                case 53:
                    MinutesText.Text = "минуты";
                    break;
                case 54:
                    MinutesText.Text = "минуты";
                    break;

                default:
                    MinutesText.Text = "минут";
                    break;

            }
        }

        private void bSet0Minute_Click(object sender, EventArgs e)
        {
            nudMinute.Value = 0;
        }

        private void bCheckoutSet10Hours_Click(object sender, EventArgs e)
        {
            nudOutcomeHour.Value = 10;
        }

        private void bCheckoutSet12Hours_Click(object sender, EventArgs e)
        {
            nudOutcomeHour.Value = 12;
        }

        private void bCheckoutSet14Hours_Click(object sender, EventArgs e)
        {
            nudOutcomeHour.Value = 14;
        }

        private void bCheckoutSet10Minute_Click(object sender, EventArgs e)
        {
            nudOutcomeMinute.Value = 0;
        }

        private void bCheckoutSet15Minute_Click(object sender, EventArgs e)
        {
            nudOutcomeMinute.Value = 15;
        }

        private void bCheckoutSet30Minute_Click(object sender, EventArgs e)
        {
            nudOutcomeMinute.Value = 30;
        }

        private void bCheckoutSet45Minute_Click(object sender, EventArgs e)
        {
            nudOutcomeMinute.Value = 45;
        }

        private void bCheckoutSet11Hours_Click(object sender, EventArgs e)
        {
            nudOutcomeHour.Value = 11;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (cmbRoomDatabaseSelector.Text == "")
            {
                MessageBox.Show("Не выбрана комната!");
            }
            else if (dtpCheckin.Value >= dtpOutcome.Value)
            {
                MessageBox.Show("Дата заселения не может быть позже даты выселения");
            }
            else
            {
                if (cmbRoomDatabaseSelector.Items.Contains(txtname.Text))
                {
                    using (NotifyIcon icon = new NotifyIcon())
                    {
                        icon.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
                        icon.Visible = true;
                        icon.ShowBalloonTip(3000, "Внимание!", "Дублирование брони отклонено", ToolTipIcon.Info);
                    }
                }
                else if (cmbRoomDatabaseSelector.Text != "")
                {
                    MealType mealType = new MealType();
                    mealType = MealType.OB;

                    BookingType bookingtype = new BookingType();
                    bookingtype = BookingType.non_confirmed;

                    BookingSource bookingsource = new BookingSource();
                    bookingsource = BookingSource.travel_agency;

                    switch (cmbMealType.SelectedIndex)
                    {
                        case 0:
                            mealType = ServerPMS.MealType.OB;
                            break;
                        case 1:
                            mealType = ServerPMS.MealType.BB;
                            break;
                        case 2:
                            mealType = ServerPMS.MealType.HB;
                            break;
                        case 3:
                            mealType = ServerPMS.MealType.FB;
                            break;
                        case 4:
                            mealType = ServerPMS.MealType.AI;
                            break;
                        case 5:
                            mealType = ServerPMS.MealType.UAI;
                            break;
                        case 6:
                            mealType = ServerPMS.MealType.HBPlus;
                            break;
                        case 7:
                            mealType = ServerPMS.MealType.FBPlus;
                            break;
                        default:
                            mealType = ServerPMS.MealType.OB;
                            break;
                    }

                    switch (cmbBookingStatus.SelectedIndex)
                    {

                        case 0:
                            bookingtype = ServerPMS.BookingType.confirmed;
                            break;
                        case 1:
                            bookingtype = ServerPMS.BookingType.non_confirmed;
                            break;
                        case 2:
                            bookingtype = ServerPMS.BookingType.accommodation;
                            break;
                        case 3:
                            bookingtype = ServerPMS.BookingType.overbooking;
                            break;
                        case 4:
                            bookingtype = ServerPMS.BookingType.dening;
                            break;
                        default:
                            bookingtype = ServerPMS.BookingType.non_confirmed;
                            break;
                    }

                    switch (cmbBookingSource.SelectedIndex)
                    {

                        case 0:
                            bookingsource = ServerPMS.BookingSource.reception;
                            break;
                        case 1:
                            bookingsource = ServerPMS.BookingSource.travel_agency;
                            break;

                        default:
                            bookingsource = ServerPMS.BookingSource.reception;
                            break;
                    }
                    string room_id2;

                    if (txtRoomID.Text == "Комната:")
                    {
                        room_id2 = txtRoomID.Text;
                        room_id2.Replace("Комната: ", "");
                    }
                    else
                    {
                        room_id2 = "Неопознаная комната";
                    }
                    string room_id3 = txtID.Text;
                    room_id3.Replace("ID бронирования:", "");

                    Program.bl.Show();
                    //public void AddBookingToDatabase(string id_booking, string name, string number_of_places, string time_checking, string date_of_incoming, string time_of_checkout, string date_of_outcoming, BookingType booking_type, int adults, decimal sum, decimal payed, string source, MealType type_of_meal, string comment, DateTime date_of_creating, DateTime Birthday)
                    if (mode == 0)
                    {
                        Program.bl.AddBookingToDatabase(room_id3, room_id2, txtname.Text, Decimal.ToInt16(nudAdults.Value + nudChildren.Value), nudHour.Value.ToString() + ":" + nudMinute.Value.ToString(), dtpCheckin.Value.ToString(), nudOutcomeHour.Value.ToString() + ":" + nudOutcomeMinute.Value.ToString(), dtpOutcome.Value.ToString(), bookingtype, Decimal.ToInt16(nudChildren.Value), Int16.Parse(txtmoney.Text), Int16.Parse(txtPayed.Text), bookingsource, mealType, rtfComment.Text, DateTime.Today, dtpBirthday.Value, txtSN.Text, txtNum.Text, dtpDateOfOutcome.Value, txtCodeU1.Text, txtCodeU2.Text, txtWhomItWasGiven.Text);
                    }
                    else
                    {
                        Program.bl.ReplacingToDatabase(index_editing_string,room_id3, room_id2, txtname.Text, Decimal.ToInt16(nudAdults.Value + nudChildren.Value), nudHour.Value.ToString() + ":" + nudMinute.Value.ToString(), dtpCheckin.Value.ToString(), nudOutcomeHour.Value.ToString() + ":" + nudOutcomeMinute.Value.ToString(), dtpOutcome.Value.ToString(), bookingtype, Decimal.ToInt16(nudChildren.Value), Int16.Parse(txtmoney.Text), Int16.Parse(txtPayed.Text), bookingsource, mealType, rtfComment.Text, DateTime.Today, dtpBirthday.Value, txtSN.Text, txtNum.Text, dtpDateOfOutcome.Value, txtCodeU1.Text, txtCodeU2.Text, txtWhomItWasGiven.Text);
                    }
                    Program.bl.ClearRowsClear();
                    Program.db.ClearRowsClear();

                    Program.bl.BookingList_SaveXSD();
                    Program.db.Database_SaveXSD();
                }
                else
                {
                    MessageBox.Show("Не выбрана комната!");
                }
            }
        }

        private void rtfPassportChecks_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
