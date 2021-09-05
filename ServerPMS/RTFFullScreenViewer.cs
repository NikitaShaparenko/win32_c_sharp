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
    public partial class RTFFullScreenViewer : Form
    {

        public bool isShown = false;
        public RTFFullScreenViewer(string rtftext)
        {
            InitializeComponent();
            rtfText.Text = rtftext;
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
