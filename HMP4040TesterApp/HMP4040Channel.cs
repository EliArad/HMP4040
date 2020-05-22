using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMP4040Api;
using RohdeSchwarz.Hmp4000;

namespace HMP4040TesterApp
{
    public partial class HMP4040Channel : UserControl
    {
        Output m_outputChannel;
        HMP4040 m_hmp = null;

        public HMP4040Channel()
        {
            InitializeComponent();
        }

        public void LoadControl(Output c, string chanelName)
        {
            groupBox1.Text = chanelName;
            m_outputChannel = c;
            tsOutputEnable.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Fancy;
            tsOutputEnable.Size = new Size(100, 30);
            tsOutputEnable.OnText = "ON";
            tsOutputEnable.OnFont = new Font(this.Font.FontFamily, 10, FontStyle.Bold);
            tsOutputEnable.OnForeColor = Color.White;
            tsOutputEnable.OffText = "OFF";
            tsOutputEnable.OffFont = new Font(this.Font.FontFamily, 10, FontStyle.Bold);
            tsOutputEnable.OffForeColor = Color.White;
        }
        
        public void Connected(HMP4040 hmp)
        {                        
            try
            {
                if (m_hmp != null && hmp == null)
                {
                    m_hmp.SetOutputEnable(m_outputChannel, false);
                    tsOutputEnable.Checked = false;
                }

                if (hmp != null)
                {
                    hmp.GetOutputEnable(m_outputChannel, out bool enable);
                    tsOutputEnable.Checked = enable;
                    lbOnOff.On = enable;

                    double value;
                    hmp.GetOutputVoltageLevel(m_outputChannel, out value);
                    txtOutputVoltageLevel.Text = value.ToString();
                    ssVoltage.Text = value.ToString();
                    hmp.GetOverVoltageProtectionLevel(m_outputChannel, out value);
                    txtOverProtectionLevel.Text = value.ToString();
                    hmp.GetOutputCurrentLevel(m_outputChannel, out value);
                    txtOutputCurrentLevel.Text = value.ToString();
                }
                m_hmp = hmp;

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        public void ReadValues()
        {
            m_hmp.MeasureDCCurrent(m_outputChannel, out double currentValue);
            ssCurrent.Value = currentValue.ToString();

            m_hmp.MeasureDCVoltage(m_outputChannel, out double voltageValue);
            ssMeasureDCVoltage.Value = voltageValue.ToString();

            double value;
            m_hmp.GetOutputVoltageLevel(m_outputChannel, out value);
            ssVoltage.Value = value.ToString();
            m_hmp.GetOverVoltageProtectionLevel(m_outputChannel, out value);
            txtOverProtectionLevel.Text = value.ToString();
            m_hmp.GetOutputCurrentLevel(m_outputChannel, out value);
            txtOutputCurrentLevel.Text = value.ToString();

        }
        void SetCurrentValue(double value)
        {
            ssCurrent.Value = value.ToString();
        }
        void SetVoltageValue(double value)
        {
            ssVoltage.Value = value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtOverProtectionLevel.ForeColor = Color.Black;
            bool b = double.TryParse(txtOverProtectionLevel.Text, out double value);
            if (b == true)
            {
                m_hmp.SetOverVoltageProtectionLevel(m_outputChannel, value);
                txtOverProtectionLevel.ForeColor = Color.Green;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtOutputCurrentLevel.ForeColor = Color.Black;
            bool b = double.TryParse(txtOutputCurrentLevel.Text, out double value);
            if (b == true)
            {
                m_hmp.SetOutputCurrentLevel(m_outputChannel, value);
                txtOutputCurrentLevel.ForeColor = Color.Green;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtOutputVoltageLevel.ForeColor = Color.Black;
            bool b = double.TryParse(txtOutputVoltageLevel.Text, out double value);
            if (b == true)
            {
                m_hmp.SetOutputVoltageLevel(m_outputChannel, value);
                txtOutputVoltageLevel.ForeColor = Color.Green;
            }
        }

        private void tsOutputEnable_CheckedChanged(object sender, EventArgs e)
        {
            m_hmp.SetOutputEnable(m_outputChannel, tsOutputEnable.Checked);
            m_hmp.GetOutputEnable(m_outputChannel, out bool enable);
            lbOnOff.On = enable;
        }
    }
}
