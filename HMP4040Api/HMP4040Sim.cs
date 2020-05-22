using RohdeSchwarz.Hmp4000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMP4040Api
{
    public class HMP4040Sim : HMP4040
    {
        const int maxOutput = 4;
        bool m_enableInstrumentQuery;
        double [] m_outputVoltageLevel = new double[maxOutput];
        double [] m_outputCurrentLevel = new double[maxOutput];
        double[] m_overVoltageProtectionLevel = new double[maxOutput];
        bool[] m_outputEnable = new bool[maxOutput];

        public HMP4040Sim()
        {

        }
        public HMP4040Sim(string cs) : base (cs)
        {

        }

        public override bool Initialize(out string IDQueryResponse, out string outMesage)
        {
            IDQueryResponse = "Simulator ok";
            outMesage = string.Empty;
            return true;
        }

        public override void SetOutputVoltageLevel(Output outputChannel, double value)
        {
            m_outputVoltageLevel[(int)m_selectedOutputChannel - 1] = value;
        }

        public override void GetOutputVoltageLevel(Output outputChannel, out double value)
        {
            value = m_outputVoltageLevel[(int)m_selectedOutputChannel - 1];
        }

        public override void GetOutputCurrentLevel(Output outputChannel, out double value)
        {
            value = m_outputCurrentLevel[(int)m_selectedOutputChannel - 1];
        }

        public override void SetOutputCurrentLevel(Output outputChannel, double value)
        {
            m_outputCurrentLevel[(int)m_selectedOutputChannel - 1] = value;
        }

        public override void SetOverVoltageProtectionLevel(Output outputChannel, double value)
        {
            m_overVoltageProtectionLevel[(int)m_selectedOutputChannel - 1] = value;
        }

        public override void GetOverVoltageProtectionLevel(Output outputChannel, out double value)
        {
            value = m_overVoltageProtectionLevel[(int)m_selectedOutputChannel - 1];
        }

        public override void SelectOutputChannel(Output outputChannel)
        {
            m_selectedOutputChannel = outputChannel;
        }
        public override void SetOutputEnable(Output outputChannel, bool enable)
        {
            m_outputEnable[(int)m_selectedOutputChannel - 1] = enable;
        }

        public override void GetOutputEnable(Output outputChannel, out bool enable)
        {
            enable = m_outputEnable[(int)m_selectedOutputChannel - 1];
        }

        public override bool EnableInstrumentQuery
        {
            get
            {
                return m_enableInstrumentQuery;
            }
            set
            {
                m_enableInstrumentQuery = value;
            }
        }
        public override bool SelfTest(out string selfTestResult, out string outMessage)
        {
            selfTestResult = "Self test ok";
            outMessage = string.Empty;
            return true;
        }

        Random r = new Random();
        public override void MeasureDCVoltage(Output outputChannel, out double value)
        {
            value = r.NextDouble() * 10;
        }

        public override void Close()
        {
            
        }

        public override void MeasureDCCurrent(Output outputChannel, out double value)
        {
            value = r.NextDouble() * 10;
        }
        bool m_allSelectedChannelOn;
        public override bool AllSelectedChannelOn
        {
            get
            {
                return m_allSelectedChannelOn;
            }
            set
            {
                m_allSelectedChannelOn = value;
            }
        }

    }
}
