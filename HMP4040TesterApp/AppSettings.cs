using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace HMP4040TesterApp
{
     

    public class AppConfig
    {
        public string visaName;
  
    }

    public sealed class AppSettings
    {
        private static AppSettings instance = null;
        private static readonly object padlock = new object();     
        AppConfig m_config;
        string m_fileName;

        AppSettings()
        {


        }
        public AppConfig Config
        {
            get
            {
                return m_config;
            }
        }

        public void Default()
        {
            
            m_config.visaName = "USB0::0x0AAD::0x0117::100405::INSTR";
                
        }
        
        public string Save()
        {
            try
            {
                 
                string json = JsonConvert.SerializeObject(m_config);
                string jsonFormatted = JValue.Parse(json).ToString(Formatting.Indented);                  
                File.WriteAllText(m_fileName, jsonFormatted);
                
                return "ok";
            }
            catch (Exception err)
            {
                return err.Message;
            }
        }
        void ValidConfig()
        {
            
        }
        public string Load(string fileName)
        {
            try
            {
                m_fileName = fileName;
                if (File.Exists(m_fileName) == false)
                {
                    m_config = new AppConfig();
                    Default();
                    Save();
                    ValidConfig();
                    return "file not found";
                }
                string text = File.ReadAllText(m_fileName);
                m_config = JsonConvert.DeserializeObject<AppConfig>(text);
                if (m_config == null)
                {
                    m_config = new AppConfig();
                    Default();
                    Save();
                }
                ValidConfig();                 
                return "ok";
            }
            catch (Exception err)
            {
                throw (new SystemException(err.Message));
            }
        }
        public void Create()
        {
            m_config = new AppConfig();
        }
        public static AppSettings Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new AppSettings();
                        }
                    }
                }
                return instance;
            }
        }
    }

}
