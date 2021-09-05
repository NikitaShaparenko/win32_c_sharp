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
    public partial class uc_toppanel : UserControl
    {
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

        }

        private void bSettings_Click(object sender, EventArgs e)
        {

        }
    }
}
