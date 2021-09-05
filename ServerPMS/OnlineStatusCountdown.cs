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
    public partial class OnlineStatusCountdown : Form
    {
        public bool isShown = false;
        public OnlineStatusCountdown()
        {
            InitializeComponent();
        }

    void OnLoad_MealType()
    {
            
        }

        void OnLoad_GuestTime()
        {
            lstGuestTime.Items.Clear();
            List<string> lst = Program.bl.getAllCheckInDates();

            foreach (string str in lst)
            {
                lstGuestTime.Items.Add(str);
            }
        }

    void OnLoad_BirthdayTime()
    {
            lstBirthdayTime.Items.Clear();
            List<string> lst = Program.bl.getAllBirthdays();

            foreach (string str in lst)
            {
                lstBirthdayTime.Items.Add(str);
            }
        }

    void OnLoad_RepairingTime()
    {
            lstBirthdayTime.Items.Clear();
    }

    void OnLoad_Reserve()
    {

    }

    void OnLoad_MealTypes()
    {
            lstMealTime.Items.Clear();
            List<string> lst = Program.bl.getAllMealTypes();

            foreach (string str in lst)
            {
                lstMealTime.Items.Add(str);
            }
        }

        void OnLoad_CleaningTime()
    {

    }

    void OnLoad_DebtTime()
    {
        lstDebtTime.Items.Clear();
        List<string> lst = Program.bl.getAllSum();
        List<string> lst2 = Program.bl.getAllPayed();

            int cnt = 0;

            if (lst.Count > lst2.Count)
            {
                cnt = lst.Count;
            }
            else
            {
                cnt = lst2.Count;
            }

            List<int> lst3 = new List<int>(cnt);
            for (int i = 0; i < cnt; i++)
            {
                lst3.Add(Int16.Parse(lst[i]) - Int16.Parse(lst2[i]));
            }

            for (int i = 0; i < cnt; i++)
            {
                lstDebtTime.Items.Add(lst3[i]);
            }


        }

    void OnLoad_OutgoingTime()
    {
            lstOutgoingTime.Items.Clear();
            List<string> lst = Program.bl.getAllCheckOutDates();
            List<string> lst2 = Program.bl.getAllCheckOutTimes();

            int cnt = 0;

            if (lst.Count > lst2.Count)
            {
               cnt = lst.Count;
            }
            else
            {
               cnt = lst2.Count;
            }

            for (int i = 0; i<cnt;i++)
            {
                lstOutgoingTime.Items.Add(lst[i] + " " + lst2[i]);
            }
        }

        void OnLoad_IngoingTime()
        {
            lstGuestTime.Items.Clear();

            List<string> lst = Program.bl.getAllCheckInDates();
            List<string> lst2 = Program.bl.getAllCheckInTimes();

            int cnt = 0;

            if (lst.Count > lst2.Count)
            {
                cnt = lst.Count;
            }
            else
            {
                cnt = lst2.Count;
            }

            for (int i = 0; i < cnt; i++)
            {
                lstGuestTime.Items.Add(lst[i] + " " + lst2[i]);
            }
        }

        private void OnlineStatusCountdown_Load(object sender, EventArgs e)
        {
            OnLoad_MealType();
            OnLoad_BirthdayTime();
            OnLoad_MealTypes();
            OnLoad_OutgoingTime();
            OnLoad_IngoingTime();
            OnLoad_DebtTime();
        }
    }
}