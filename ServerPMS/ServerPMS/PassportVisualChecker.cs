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
    public partial class PassportVisualChecker : Form
    {
        public PassportVisualChecker()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tProgress_Tick(object sender, EventArgs e)
        {
            txtpb.Text = pbProgress.Value.ToString() + "%";
        }

        /*
         * mode: 
         * 0 - ok
         * 1 - warning
         * 2 - error
         */

        bool first = false;
        bool second = false;
        bool third = false;
        bool fourth = false;
        bool fifth = false;

        public int[] error_bits = { 1, 1, 1, 1, 1 };
        public int[] ok_bits = { 1, 1, 1, 1, 1 };
        public int[] warning_bits = { 1, 1, 1, 1, 1 };

        public void PercentsLocator()
        {
            txtpb.Location = new Point(pbProgress.Location.X + pbProgress.Size.Width / 2, pbProgress.Location.Y);
        }

        public void SetMark(int step,int mode)
        {
            switch(step)
            {
                case 1:
                    switch(mode)
                    {
                        case 0:
                             picFirst.BackgroundImage = Properties.Resources.ok75px;
                            break;

                        case 1:
                            picFirst.BackgroundImage = Properties.Resources.warning75px;
                            break;

                        default:
                            picFirst.BackgroundImage = Properties.Resources.Error75px;
                            break;
                    }
                    
                    break;
                case 2:
                    switch (mode)
                    {
                        case 0:
                            picSecond.BackgroundImage = Properties.Resources.ok75px;
                            break;

                        case 1:
                            picSecond.BackgroundImage = Properties.Resources.warning75px;
                            break;

                        default:
                            picSecond.BackgroundImage = Properties.Resources.Error75px;
                            break;
                    }
                    break;
                case 3:
                    switch (mode)
                    {
                        case 0:
                            picThird.BackgroundImage = Properties.Resources.ok75px;
                            break;

                        case 1:
                            picThird.BackgroundImage = Properties.Resources.warning75px;
                            break;

                        default:
                            picThird.BackgroundImage = Properties.Resources.Error75px;
                            break;
                    }
                    break;
                case 4:
                    switch (mode)
                    {
                        case 0:
                            picFourth.BackgroundImage = Properties.Resources.ok75px;
                            break;

                        case 1:
                            picFourth.BackgroundImage = Properties.Resources.warning75px;
                            break;

                        default:
                            picFourth.BackgroundImage = Properties.Resources.Error75px;
                            break;
                    }
                    break;
                case 5:
                    switch (mode)
                    {
                        case 0:
                            picFifth.BackgroundImage = Properties.Resources.ok75px;
                            break;

                        case 1:
                            picFifth.BackgroundImage = Properties.Resources.warning75px;
                            break;

                        default:
                            picFifth.BackgroundImage = Properties.Resources.Error75px;
                            break;
                    }
                    break;
            }
        }

        private void PassportVisualChecker_Load(object sender, EventArgs e)
        {
            PercentsLocator();
        }

        public void StatusSetMaker(int ssm)
        {
            /*
             * 0 - ok
             * 1 - warning
             * 2 - error
             */

            switch(ssm)
            {
                case 0:
                    txtStatus.Text = "Статус проверки: Паспорт успешно автоматически проверен";
                    txtStatus.ForeColor = Color.DarkGreen;
                    break;
                case 1:
                    txtStatus.Text = "Статус проверки: Паспорт проверен с незначительными несостыковками";
                    txtStatus.ForeColor = Color.Yellow;
                    break;
                default:
                    txtStatus.Text = "Статус проверки: Паспорт проверен. Критические несостыковки ";
                    txtStatus.ForeColor = Color.DarkRed;
                    break;
            }
        }
    
    }
}
