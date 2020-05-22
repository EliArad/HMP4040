using RohdeSchwarz.Hmp4000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HMP4040Api
{
    public class HMP4040
    {
        string m_connectionstring;
        Hmp4000 driver;
        //"USB0::0x0AAD::0x0117::100405::INSTR"
        protected Output m_selectedOutputChannel = Output.Channel1;
        public HMP4040(string cs)
        {
            m_connectionstring = cs;
        }
        public HMP4040()
        {

        }
        public virtual bool Initialize(out string IDQueryResponse, out string outMesage)
        {
            lock (this)
            {
                if (m_initialize == true)
                {
                    outMesage = "Already Initialzed";
                    IDQueryResponse = driver.System.IDQueryResponse;
                    return true;
                }
                outMesage = string.Empty;
                IDQueryResponse = string.Empty;
                try
                {
                    string optionString = "Timeout = 5000";
                    driver = new Hmp4000(m_connectionstring, false, false, optionString);
                    driver.System.IOTimeout = 5000;
                    IDQueryResponse = driver.System.IDQueryResponse;
                    m_initialize = true;
                    return true;
                }
                catch (Exception err)
                {
                    outMesage = err.Message;
                    return false;
                }
            }
        }

        public virtual void SetOutputVoltageLevel(Output outputChannel, double value)
        {
            lock (this)
            {
                if (outputChannel != m_selectedOutputChannel)
                {
                    SelectOutputChannel(outputChannel);
                }

                driver.VoltageAndCurrent.OutputVoltageLevel = value;
                Thread.Sleep(10);
                while (driver.VoltageAndCurrent.OutputVoltageLevel != value)
                {
                    if (m_initialize == false)
                        break;
                    Thread.Sleep(10);
                    driver.VoltageAndCurrent.OutputVoltageLevel = value;
                }
            }
        }

        public virtual void GetOutputVoltageLevel(Output outputChannel, out double value)
        {
            lock (this)
            {
                if (outputChannel != m_selectedOutputChannel)
                {
                    SelectOutputChannel(outputChannel);
                }

                value = driver.VoltageAndCurrent.OutputVoltageLevel;
            }
        }

        public virtual void SetOutputCurrentLevel(Output outputChannel, double value)
        {
            lock (this)
            {
                if (outputChannel != m_selectedOutputChannel)
                {
                    SelectOutputChannel(outputChannel);
                }
                driver.VoltageAndCurrent.OutputCurrentLevel = value;
            }
        }

        public virtual void GetOutputCurrentLevel(Output outputChannel, out double value)
        {
            lock (this)
            {
                if (outputChannel != m_selectedOutputChannel)
                {
                    SelectOutputChannel(outputChannel);
                }
                value = driver.VoltageAndCurrent.OutputCurrentLevel;
            }
        }

        public virtual bool AllSelectedChannelOn
        {
            set
            {
                lock (this)
                {
                    driver.BasicOperation.MasterEnabled = value;
                    while (driver.BasicOperation.MasterEnabled != value)
                    {
                        if (m_initialize == false)
                            break;
                        Thread.Sleep(10);
                    }
                }
            }
            get
            {
                lock (this)
                {
                    return driver.BasicOperation.MasterEnabled;
                }
            }
        }

        public virtual void SetOverVoltageProtectionLevel(Output outputChannel, double value)
        {
            lock (this)
            {
                if (outputChannel != m_selectedOutputChannel)
                {
                    SelectOutputChannel(outputChannel);
                }
                driver.VoltageAndCurrent.OverVoltageProtectionLevel = value;
            }
        }

        public virtual void GetOverVoltageProtectionLevel(Output outputChannel, out double value)
        {
            lock (this)
            {
                if (outputChannel != m_selectedOutputChannel)
                {
                    SelectOutputChannel(outputChannel);
                }
                value = driver.VoltageAndCurrent.OverVoltageProtectionLevel;
            }
        }

        public virtual void SelectOutputChannel(Output outputChannel)
        {
            
            m_selectedOutputChannel = outputChannel;
            driver.BasicOperation.SelectedChannel = outputChannel;
            
        }
        public virtual void SetOutputEnable(Output outputChannel, bool enable)
        {
            lock (this)
            {
                if (outputChannel != m_selectedOutputChannel)
                {
                    SelectOutputChannel(outputChannel);
                }
                driver.BasicOperation.OutputEnabled = enable;
                while (driver.BasicOperation.OutputEnabled != enable)
                {
                    if (m_initialize == false)
                        break;
                    driver.BasicOperation.OutputEnabled = enable;
                    Thread.Sleep(10);
                }
            }
        }

        bool m_initialize = false;
        public virtual void Close()
        {
            lock (this)
            {
                if (driver != null)
                {
                    driver.BasicOperation.MasterEnabled = false;
                    while (driver.BasicOperation.MasterEnabled != false)
                    {
                        Thread.Sleep(10);
                    }
                    m_initialize = false;
                    Thread.Sleep(1000);
                    driver.Close();
                }
            }
        }
        public virtual void MeasureDCVoltage(Output outputChannel, out double value)
        {
            lock (this)
            {
                if (outputChannel != m_selectedOutputChannel)
                {
                    SelectOutputChannel(outputChannel);
                }
                value = driver.Measurement.DCVoltage;
            }
        }

        public virtual void MeasureDCCurrent(Output outputChannel, out double value)
        {
            lock (this)
            {
                if (outputChannel != m_selectedOutputChannel)
                {
                    SelectOutputChannel(outputChannel);
                }
                value = driver.Measurement.DCCurrent;
            }
        }

        public virtual void GetOutputEnable(Output outputChannel, out bool enable)
        {
            lock (this)
            {
                if (outputChannel != m_selectedOutputChannel)
                {
                    SelectOutputChannel(outputChannel);
                }
                enable = driver.BasicOperation.OutputEnabled;
            }
        }


        public virtual bool EnableInstrumentQuery
        {
       
            set
            {
                lock (this)
                {
                    // If speed is critical, switch the QueryInstrumentStatus status OFF
                    // By default, the QueryInstrumentStatus value is ON
                    driver.DriverOperation.QueryInstrumentStatus = value;
                }
            }
            get
            {
                lock (this)
                {
                    return driver.DriverOperation.QueryInstrumentStatus;
                }
            }        
        }

      
        public virtual bool SelfTest(out string selfTestResult, out string outMessage)
        {
            lock (this)
            {
                selfTestResult = string.Empty;
                outMessage = string.Empty;

                try
                {
                    var x = driver.System.SelfTest();
                    selfTestResult = x.Message;
                    return true;
                }
                catch (Exception err)
                {
                    return false;
                }
            }
        }
    }
}
