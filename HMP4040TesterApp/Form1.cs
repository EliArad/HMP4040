using HMP4040Api;
using RohdeSchwarz.Hmp4000;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMP4040TesterApp
{
    public partial class Form1 : Form
    {
        HMP4040 m_hmp;

        Thread m_hmpReadThread;
        public Form1()
        {
            InitializeComponent();

            try
            {
                Control.CheckForIllegalCrossThreadCalls = false;
                hmP4040Channel1.Enabled = false;
                hmP4040Channel2.Enabled = false;
                hmP4040Channel3.Enabled = false;
                hmP4040Channel4.Enabled = false;

                SkinButton(btnOnOff);
                SkinButton(tgMasterOnOff); ;



                hmP4040Channel1.LoadControl(Output.Channel1, "Channel 1");
                hmP4040Channel2.LoadControl(Output.Channel2, "Channel 2");
                hmP4040Channel3.LoadControl(Output.Channel3, "Channel 3");
                hmP4040Channel4.LoadControl(Output.Channel4, "Channel 4");

                AppSettings.Instance.Load("HMP4040App.json");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        void SkinButton(JCS.ToggleSwitch ts)
        {
            ts.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Fancy;
            ts.Size = new Size(100, 30);
            ts.OnText = "ON";
            ts.OnFont = new Font(this.Font.FontFamily, 10, FontStyle.Bold);
            ts.OnForeColor = Color.White;
            ts.OffText = "OFF";
            ts.OffFont = new Font(this.Font.FontFamily, 10, FontStyle.Bold);
            ts.OffForeColor = Color.White;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Settings s = new Settings();
            s.ShowDialog();

        }

        bool m_connected = false;

        void HMPReader()
        {
            HMP4040Channel[] hmpControl = { hmP4040Channel1, hmP4040Channel2, hmP4040Channel3  , hmP4040Channel4};

            while (m_connected== true)
            {
                for (int i = 1; i < 5; i++)
                {
                    hmpControl[i - 1].ReadValues();                    
                }
                Thread.Sleep(100);
            }

        }
        private void btnOnOff_CheckedChanged(object sender, EventArgs e)
        {
            if (btnOnOff.Checked == true)
            {
                m_hmp = new HMP4040(AppSettings.Instance.Config.visaName);
                if (m_hmp.Initialize(out string idQueryResponse, out string outMessage) == false)
                {
                    MessageBox.Show("Initialize failed: " + outMessage);
                }
                else
                {
                    this.Text = "HMP4040 - Connected";
                    hmP4040Channel1.Enabled = true;
                    hmP4040Channel2.Enabled = true;
                    hmP4040Channel3.Enabled = true;
                    hmP4040Channel4.Enabled = true;

                    hmP4040Channel1.Connected(m_hmp);
                    hmP4040Channel2.Connected(m_hmp);
                    hmP4040Channel3.Connected(m_hmp);
                    hmP4040Channel4.Connected(m_hmp);
                    m_connected = true;
                    m_hmpReadThread = new Thread(HMPReader);
                    m_hmpReadThread.Start();
                }
            }
            else
            {
                m_connected = false;
                if (m_hmpReadThread != null)
                    m_hmpReadThread.Join();

                hmP4040Channel1.Connected(null);
                hmP4040Channel2.Connected(null);
                hmP4040Channel3.Connected(null);
                hmP4040Channel4.Connected(null);
                hmP4040Channel1.Enabled = false;
                hmP4040Channel2.Enabled = false;
                hmP4040Channel3.Enabled = false;
                hmP4040Channel4.Enabled = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_connected = false;
            if (m_hmpReadThread != null)
                m_hmpReadThread.Join();

            if (m_hmp != null)
                m_hmp.Close();
        }

        private void hmP4040Channel1_Load(object sender, EventArgs e)
        {

        }

        private void toggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            m_hmp.AllSelectedChannelOn = tgMasterOnOff.Checked;
        }
    }
}
