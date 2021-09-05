using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerPMS
{
    static class Program
    {


        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 
        public static OnlineStatusCountdown onsc = new OnlineStatusCountdown();
        public static BookingList bl = new BookingList();
        public static Core.SysFunctions csf = new Core.SysFunctions();
       // public static RTFFullScreenViewer rtffsv = new RTFFullScreenViewer();
        public static HotelsList hl = new HotelsList();
        public static Database db = new Database();
        public static AddNewBooking anb = new AddNewBooking();
        public static PassportVisualChecker pvc = new PassportVisualChecker();

        //public static MainForm mf = new MainForm();

        [STAThread]

        static void Main()
        {
           // Application.EnableVisualStyles();
          //  Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new MainForm());
        }
    }
}
