using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerPMS
{
    public partial class uc_todaymenu : UserControl
    {
        public uc_todaymenu()
        {
            InitializeComponent();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Filler_txtRPToday(string input)
        {
            txtRPToday.Text = input;
        }
        public void Filler_txt1DayIncoming(string input)
        {
            txt1DayIncoming.Text = input;
        }
        public void Filler_txt1DayOutcoming(string input)
        {
            txt1DayOutcoming.Text = input;
        }
        public void Filler_txt1DayLiving(string input)
        {
            txt1DayLiving.Text = input;
        }
        public void Filler_txt1DayBirthdays(string input)
        {
            txt1DayBirthdays.Text = input;
        }
        public void Filler_txt1DayTotalRooms(string input)
        {
            txt1DayTotalRooms.Text = input;
        }
        public void Filler_txt1DayTotalPlaces(string input)
        {
            txt1DayTotalPlaces.Text = input;
        }
        public void Filler_txt1DayAvaliableRooms(string input)
        {
            txt1DayAvaliableRooms.Text = input;
        }
        public void Filler_txt1DayOccupatedRooms(string input)
        {
            txt1DayOccupatedRooms.Text = input;
        }
        public void Filler_txt1DayOccupation(string input)
        {
            txt1DayOccupation.Text = input;
        }

    }
}
