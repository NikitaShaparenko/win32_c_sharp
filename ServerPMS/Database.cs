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
    public partial class Database : Form
    {

        public bool isShown = false;

        public Database()
        {
            InitializeComponent();
        }

        public void AddToDatabase(string id, string name, int adults, int children)
        {
            int lastRow = dgvDatabase.Rows.Count;
            dgvDatabase.Rows.Add();
            dgvDatabase.Rows[lastRow].Cells[0].Value = id;
            dgvDatabase.Rows[lastRow].Cells[1].Value = name;
            dgvDatabase.Rows[lastRow].Cells[2].Value = adults.ToString();
            dgvDatabase.Rows[lastRow].Cells[3].Value = children.ToString();
        }

        public int DatabaseRowsCounter()
        {
            int rws = 0;
            for (int i = 0; i< dgvDatabase.Rows.Count; i++)
            {
                if (dgvDatabase[0,i].Value != null)
                {
                    rws++;
                }
            }
            return rws;
        }

        public int getRowByID(int id)
        {
            int num_str = 0;
            
            for(int i = 0; i<dgvDatabase.Rows.Count; i++)
            {
                if (dgvDatabase.Rows[i].Cells[0].Value != null)
                {
                    if (dgvDatabase.Rows[i].Cells[0].Value.ToString() == id.ToString())
                    {
                        return num_str;
                    }
                    num_str++;
                }
            }
            return num_str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.WindowState = FormWindowState.Minimized;
        }

        const string table_name = "Database";

        public string getAllPlaces()
        {
            List<string> places_adults = new List<string>();
            List<string> places_children = new List<string>();

            foreach (DataGridViewRow dgvr in dgvDatabase.Rows)
            {
                if (dgvr.Cells[2].Value != null)
                {
                    places_adults.Add(dgvr.Cells[2].Value.ToString());
                    places_children.Add(dgvr.Cells[3].Value.ToString());
                }
            }

            int sum_adults = 0;
            int sum_children = 0;

            List<int> places_adults_int = new List<int>();
            List<int> places_children_int = new List<int>();

            foreach(string str in places_adults)
            {
                places_adults_int.Add(Int16.Parse(str));    
            }

            foreach (string str in places_children)
            {
                places_children_int.Add(Int16.Parse(str));
            }

           for (int i = 0; i < places_adults_int.Count;i++)
            {
                sum_adults += places_adults_int[i];
                sum_children += places_children_int[i];
            }

            return (sum_adults + "+" + sum_children).ToString();
        }
        public void ClearRowsClear()
        {
            for (int i = 0; i < dgvDatabase.RowCount - 1; i++)
            {

                if (dgvDatabase.Rows[i].Cells[0].Value == null)
                {
                    dgvDatabase.Rows.RemoveAt(i);
                    i--;
                }
                else if (dgvDatabase.Rows[i].Cells[0].Value.ToString() == "")
                {
                    dgvDatabase.Rows.RemoveAt(i);
                    i--;
                }
                else if (dgvDatabase.Rows[i].Cells[0].Value.ToString() == " ")
                {
                    dgvDatabase.Rows.RemoveAt(i);
                    i--;
                }
            }
        }
        public void Database_LoadXSD()
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
                        dgvDatabase.Rows.Add();
                        for (int c = 0; c < dt.Columns.Count; c++)
                        {

                            if (dt.Rows[r].ItemArray[c] != null) dgvDatabase.Rows[r].Cells[c].Value = dt.Rows[r].ItemArray[c];
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
        public void Database_SaveXSD()
        {
            try
            {
                for (int r = 0; r < dgvDatabase.Rows.Count; r++)
                {
                    for (int c = 0; c < dgvDatabase.Columns.Count; c++)
                    {
                        if (dgvDatabase[c, r].Value != null)
                        {
                            if (dgvDatabase[c, r].Value.ToString() == "") dgvDatabase[c, r].Value = " ";
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
                        foreach (DataGridViewColumn col in dgvDatabase.Columns)
                        {
                            dt.Columns.Add(col.Name);
                        }

                        foreach (DataGridViewRow row in dgvDatabase.Rows)
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
                        foreach (DataGridViewColumn col in dgvDatabase.Columns)
                        {
                            dt.Columns.Add(col.Name);
                        }

                        foreach (DataGridViewRow row in dgvDatabase.Rows)
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
    }
}
