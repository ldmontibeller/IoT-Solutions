using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwinCAT.Ads;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace AdsMqtt
{
    public partial class Form1 : Form
    {
        TcAdsClient _adsClient = new TcAdsClient();
        MqttClient _mqttClient;
        string clientId = Guid.NewGuid().ToString();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                /*** Connect to TwinCAT *******************************************/

                _adsClient.Connect(851); // Connect to local TwinCAT runtime
                StateInfo state = _adsClient.ReadState();
                if (state.AdsState != AdsState.Run)
                    throw new Exception("TwinCAT must be in Run state!");
                
                /******************************************************************/


                /*** Connect to MQTT Broker ***************************************/

                _mqttClient = new MqttClient("iot.eclipse.org");
                _mqttClient.Connect(clientId);

                /******************************************************************/
        

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button_ReadTcData_Click(object sender, EventArgs e)
        {
            try
            {
                int handle = _adsClient.CreateVariableHandle("MAIN.udCounter");
                uint data = (uint)_adsClient.ReadAny(handle, typeof(uint));
                _adsClient.DeleteVariableHandle(handle);
                textBox_Data.Text = data.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button_WriteMqttData_Click(object sender, EventArgs e)
        {
            try
            {
                // publish a message on topic topic with QoS 2 
                _mqttClient.Publish("hamk/data/from/twincat", Encoding.UTF8.GetBytes(textBox_Data.Text), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_mqttClient != null)
                _mqttClient.Disconnect();

            if(_adsClient != null)
            {
                _adsClient.Disconnect();
                _adsClient.Dispose();
            }
                
        }
    }
}
