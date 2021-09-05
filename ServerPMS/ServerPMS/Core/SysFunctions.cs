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

namespace ServerPMS.Core
{
    public partial class SysFunctions : Form
    {
        public SysFunctions()
        {
            InitializeComponent();
        }

        public string CSV_UnitCode_getNameByCode(string input)
        {
            string csvPath = Directory.GetCurrentDirectory() + "\\fms_unit.csv";

            string s_csv ="" ;
            string s;
            StreamReader f = new StreamReader(csvPath, Encoding.UTF8);
            while ((s = f.ReadLine()) != null)
            {
                if (s.Contains(input))
                {
                    s = s.Replace(input, "");
                    s = s.Replace(",", "");
                    s_csv += s;
                }
            }
            f.Close();
            return s_csv;
        }

        public string CSV_UnitCode_getCodeByName(string input)
        {
            string csvPath = Directory.GetCurrentDirectory() + "\\fms_unit.csv";

            string s_csv = "";
            string s;
            StreamReader f = new StreamReader(csvPath, Encoding.UTF8);
            while ((s = f.ReadLine()) != null)
            {
                if (s.Contains(input))
                {
                    s = s.Replace(input, "");
                    s = s.Replace(",", "");
                    s_csv += s + Environment.NewLine;
                }
            }
            f.Close();
            return s_csv;
        }

        public bool CSV_UnitCodeFullMatching(string input_code, string input_fms)
        {
            string csvPath = Directory.GetCurrentDirectory() + "\\fms_unit.csv";

            string s_csv;
            string s;
            StreamReader f = new StreamReader(csvPath, Encoding.UTF8);
            while ((s = f.ReadLine()) != null)
            {
                if (s == input_code + "," + input_fms)
                {
                    return true;
                }
            }
            f.Close();
            return false;
        }

        public bool CSV_CheckForInvalidPassport(string serie, string number)
        {
            string csvPath = Directory.GetCurrentDirectory() + "\\fms_base.csv";

            string s_csv;
            string s;
            StreamReader f = new StreamReader(csvPath, Encoding.UTF8);
            while ((s = f.ReadLine()) != null)
            {
                if (s == serie + "," + number)
                {
                    return true;
                }
            }
            f.Close();
          return false;
        }

        public string CSV_CheckForConst(string input)
        {
            string csvPath = Directory.GetCurrentDirectory() + "\\fms_const.csv";

            string s_csv = "";
            string s;
            StreamReader f = new StreamReader(csvPath, Encoding.UTF8);
            while ((s = f.ReadLine()) != null)
            {
                if (s.Contains(input))
                {
                    s = s.Replace(input, "");
                    s = s.Replace(",", "");
                    s_csv += s + Environment.NewLine;
                }
            }
            f.Close();
            return s_csv;
        }

    }
}
