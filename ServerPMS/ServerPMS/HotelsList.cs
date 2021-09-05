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
    public partial class HotelsList : Form
    {
        public HotelsList()
        {
            InitializeComponent();
        }

        int adults = 1;
        int children = 0;
        bool mode_new = true;
        public bool isShown = false;
        private void rbExisting_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void HotelsList_Load(object sender, EventArgs e)
        {
            //rbNew.Enabled = false;
            //rbExisting.Enabled = false;
            txtid.Text = GenByDate();
            MigrateDB_ToThis();
        }

        private void tPlaces_Tick(object sender, EventArgs e)
        {

            txtChildrenPlaces.ReadOnly = false;
            txtAdultPlaces.ReadOnly = false;

            txtChildrenPlaces.Text = children.ToString();
            txtAdultPlaces.Text = adults.ToString();

            txtChildrenPlaces.ReadOnly = true;
            txtAdultPlaces.ReadOnly = true;

            if (mode_new)
            {
                rbNew.Checked = true;
                rbExisting.Checked = false;
               // txtid.Text = GenByDate();
                txtAction.Text = "Добавление номеров";
            }
            else
            {
                rbNew.Checked = false;
                rbExisting.Checked = true;
                txtAction.Text = "Редактирование";
                //dgvHL.ClearSelection();
            }
        }

        private void bAdultsPlusOne_Click(object sender, EventArgs e)
        {
            if (adults <= 5)
            {
                adults++;
            }
        }

        private void bChildrenPlusOne_Click(object sender, EventArgs e)
        {
            if (children <= 5)
            {
                children++;
            }
        }

        private void bAdultsMinusOne_Click(object sender, EventArgs e)
        {
            if (adults > 1)
            {
                adults--;
            }
        }

        private void bChildrenMinusOne_Click(object sender, EventArgs e)
        {
            if (children > 0)
            {
                children--;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHL.SelectedRows.Count > 0)
            {
                mode_new = false;
                rbNew.Checked = false;
                rbExisting.Checked = true;
                //txtAction.Text = "Редактирование" + dgvHL.SelectedRows[0].Index.ToString();
                txtAction.Text = "Редактирование";
            }
            else
            {
                mode_new = true;
                rbNew.Checked = true;
                rbExisting.Checked = false;
                txtAction.Text = "Добавление номеров";

            }

        }

        private void rbNew_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNew.Checked)
            {
                mode_new = true;
                txtid.Text = GenByDate();
                rbNew.Checked = true;
                rbExisting.Checked = false;
                txtAction.Text = "Добавление номеров";
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

            return dtnow;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.WindowState = FormWindowState.Minimized;
        }

        public void MigrateDB_ToThis()
        {
            int a = 0;

            int p_all = 0;
            int p_c = 0;
            int p_a = 0;

            dgvHL.Rows.Clear();

            for (int i = 0; i < Program.db.dgvDatabase.Rows.Count; i++)
            {
                if (Program.db.dgvDatabase.Rows[i].Cells[0].Value != null)
                {
                    dgvHL.Rows.Add(Program.db.dgvDatabase.Rows[i].Cells[0].Value.ToString(), Program.db.dgvDatabase.Rows[i].Cells[1].Value.ToString(), Int16.Parse(Program.db.dgvDatabase.Rows[i].Cells[2].Value.ToString()), Int16.Parse(Program.db.dgvDatabase.Rows[i].Cells[3].Value.ToString()), Program.db.dgvDatabase.Rows[i].Cells[4].Value.ToString(), Program.db.dgvDatabase.Rows[i].Cells[5].Value.ToString());
                    //dgvHL.Rows.Add();
                    //dgvHL.Rows[a].Cells[0].Value = Program.db.dgvDatabase.Rows[i].Cells[0].Value.ToString();
                    //dgvHL.Rows[a].Cells[1].Value = Program.db.dgvDatabase.Rows[i].Cells[1].Value.ToString();
                    //p_all = Int16.Parse(Program.db.dgvDatabase.Rows[i].Cells[2].Value.ToString());
                    //p_a = Int16.Parse(Program.db.dgvDatabase.Rows[i].Cells[3].Value.ToString());
                    //p_c = p_all - p_a;
                    //dgvHL.Rows[a].Cells[2].Value = p_a.ToString();
                    //dgvHL.Rows[a].Cells[3].Value = p_c.ToString();
                    //dgvHL.Rows[a].Cells[4].Value = Program.db.dgvDatabase.Rows[i].Cells[4].Value.ToString();
                    //dgvHL.Rows[a].Cells[5].Value = Program.db.dgvDatabase.Rows[i].Cells[5].Value.ToString();
                }
                a++;
            }


        }

        public void MigrateDB_ToThat()
        {
            int a = 0;

            int p_all = 0;
            int p_c = 0;
            int p_a = 0;

            for (int i = 0; i < dgvHL.Rows.Count; i++)
            {
                if (dgvHL.Rows[i].Cells[0].Value != null)
                {
                    Program.db.dgvDatabase.Rows[i].Cells[0].Value = dgvHL.Rows[a].Cells[0].Value.ToString();
                    Program.db.dgvDatabase.Rows[i].Cells[1].Value = dgvHL.Rows[a].Cells[1].Value.ToString(); 
                    p_all = Int16.Parse(Program.db.dgvDatabase.Rows[i].Cells[2].Value.ToString());
                    p_a = Int16.Parse(Program.db.dgvDatabase.Rows[i].Cells[3].Value.ToString());
                    p_c = p_all - p_a;
                    dgvHL.Rows[a].Cells[2].Value = p_a.ToString();
                    dgvHL.Rows[a].Cells[3].Value = p_c.ToString();
                    Program.db.dgvDatabase.Rows[i].Cells[4].Value = dgvHL.Rows[a].Cells[4].Value.ToString();
                    Program.db.dgvDatabase.Rows[i].Cells[5].Value = dgvHL.Rows[a].Cells[5].Value.ToString();
                }
                a++;
            }
        }
        int rows = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            if (txtRoomName.Text != "")
            {
                if (mode_new)
                {
                    ;
                    rows++;
                    //dgvHL.Rows.Add();
                    //Program.db.dgvDatabase.Rows.Add();
                }
                else
                {
                    //rows = Program.db.getRowByID(Int16.Parse(txtid.Text));
                    rows = dgvHL.SelectedRows[0].Index;
                }
                databaseFill(rows);
                // MigrateDB_ToThat();

                MigrateDB_ToThis();
                txtid.Text = GenByDate();

                Program.bl.ClearRowsClear();
                Program.db.ClearRowsClear();

                Program.bl.BookingList_SaveXSD();
                Program.db.Database_SaveXSD();
            }

        }

        public void databaseFill(int row)
        {
            Program.db.dgvDatabase.Rows.Add(txtid.Text, txtRoomName.Text, txtAdultPlaces.Text, txtChildrenPlaces.Text, numCost1Daily.Value.ToString(), numCost2Weekends.Value.ToString());

            //Program.db.dgvDatabase.Rows[row].Cells[0].Value = txtid.Text;
            //Program.db.dgvDatabase.Rows[row].Cells[1].Value = txtRoomName.Text;
            //Program.db.dgvDatabase.Rows[row].Cells[2].Value = txtAdultPlaces.Text;
            //Program.db.dgvDatabase.Rows[row].Cells[3].Value = txtChildrenPlaces.Text;
            //Program.db.dgvDatabase.Rows[row].Cells[4].Value = numCost1Daily.Value.ToString();
            //Program.db.dgvDatabase.Rows[row].Cells[5].Value = numCost2Weekends.Value.ToString();
        }

        public void getUpload()
        {
           
        }
    }
}
