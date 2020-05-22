using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMP4040TesterApp
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            txtVisaName.Text = AppSettings.Instance.Config.visaName;

            using (var searcher = new ManagementObjectSearcher
               ("SELECT * FROM WIN32_SerialPort"))
            {
                string[] portnames = SerialPort.GetPortNames();
                var ports = searcher.Get().Cast<ManagementBaseObject>().ToList();
                var tList = (from n in portnames
                             join p in ports on n equals p["DeviceID"].ToString()
                             select n + " - " + p["Caption"]).ToList();

                foreach (string s in tList)
                {
                    if (s.Contains("HO 732") == true)
                    {
                        string tmp = s.Substring(s.IndexOf('(') + 1);
                        tmp = tmp.Replace(')', ' ');
                        tmp = tmp.Trim();
                        Console.Write(tmp);
                        tmp = tmp.Substring(3);
                        txtVisaName.Text = "ASRL" + tmp + "::INSTR";
                        return;
                    }
                }
            }


        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtVisaName.Text == string.Empty)
            {
                MessageBox.Show("Please set visa address");
                return;
            }
            AppSettings.Instance.Config.visaName = txtVisaName.Text;
            AppSettings.Instance.Save();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
